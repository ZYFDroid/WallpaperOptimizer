using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using WallpaperOptimizer.lib;

namespace WallpaperOptimizer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);
        const uint SPI_GETDESKWALLPAPER = 0x0073;
        const uint SPI_SETDESKWALLPAPER = 20;
        public static string GetWallpaperPath()
        {
            StringBuilder wallPaperPath = new StringBuilder(1024);
            if (SystemParametersInfo(SPI_GETDESKWALLPAPER, 1024, wallPaperPath, 0))
            {
                return wallPaperPath.ToString();
            }
            return null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        Image wallpaper = null;
        Image processed = null;

        private Image GetCheckerboardBackground()
        {
            Bitmap bmp = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.FillRectangle(Brushes.LightGray, 0, 0, 16, 16);
            g.FillRectangle(Brushes.LightGray, 16, 16, 16, 16);
            g.Dispose();
            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgWallpaper.BackgroundImage = GetCheckerboardBackground();
            string wallpaperPath = GetWallpaperPath();
            if(wallpaperPath != null && System.IO.File.Exists(wallpaperPath))
            {
                wallpaper = readImage(wallpaperPath);
                imgWallpaper.Image = wallpaper;
            }
            cmbIconLocation.SelectedIndex = 0;
        }

        private void numBlurRadius_ValueChanged(object sender, EventArgs e)
        {
            lblBlurAreaSustain.Text = numBlurAreaSustain.Value.ToString();
            lblBlurBrightness.Text = (numBlurBrightness.Value-64).ToString();
            lblBlurRadius.Text = numBlurRadius.Value.ToString();
            lblBlurWidth.Text = (((float)numBlurWidth.Value) / 100f).ToString();
        }

        public void Process()
        {
            processed?.Dispose();
            processed = new Bitmap(wallpaper); // 创建一个新的图像，在这里开始处理

            int blurLayerHeight = 256; //缩小再模糊，处理更快
            int blurLayerWidth = blurLayerHeight * processed.Width / processed.Height ;
            Bitmap bluredBitmap = new Bitmap(blurLayerWidth, blurLayerHeight);
            Graphics gr = Graphics.FromImage(bluredBitmap);
            int brightness = numBlurBrightness.Value - 64;
            float fBrightness = ((float)brightness) / 80;
            // 亮度范围：0.2 - 1.8 （其实就是每个像素乘以多少）
            DrawUtils.drawBrightnessImage(gr, processed, 0, 0, blurLayerWidth, blurLayerHeight, fBrightness);
            gr.Dispose();

            GaussianBlur blur = new GaussianBlur(numBlurRadius.Value);
            Bitmap bluredBitmap2 = blur.ProcessImage(bluredBitmap);
            bluredBitmap.Dispose();
            bluredBitmap = bluredBitmap2;

            // 0=left; 1=top; 2=right; 3=bottom;
            int blurArea = cmbIconLocation.SelectedIndex;

            // 模糊总区域
            float blurPercent = (float)numBlurWidth.Value / 10000f;
            // 开始渐变淡出模糊的位置，再这个位置之前都是模糊的图像，从这个位置之后再开始淡出
            float sustainPercent = (float)numBlurAreaSustain.Value / 100f;

            int blurAreaLen = blurArea % 2 == 0 ? blurLayerWidth : blurLayerHeight;

            FastBitmap fbmp = new FastBitmap(bluredBitmap);
            fbmp.LockBits();

            for (int i = 0; i < blurAreaLen; i++)
            {
                float alpha = 1.0f;
                float position = (float)i / (float)blurAreaLen;

                float sustainPosition = blurPercent * sustainPercent;
                if(position <= sustainPosition)
                {
                    alpha = 1.0f; //开始淡出前
                }
                if(position > sustainPosition && position <= blurPercent)
                {
                    // 开始淡出
                    alpha = 1.0f - (position - sustainPosition) / (blurPercent - sustainPosition);
                }
                if(position > blurPercent)
                {
                    alpha = 0f; // 淡出之后
                }
                if(blurArea % 2 == 0)
                {
                    int wpos = i;
                    if(blurArea == 2)
                    {
                        wpos = blurLayerWidth - 1 - i;
                    }
                    for (int j = 0; j < blurLayerHeight; j++)
                    {
                        Color c = fbmp.GetPixel(wpos, j);
                        fbmp.SetPixel(wpos, j, Color.FromArgb((int)Math.Floor(alpha * 255),c));
                    }
                }
                else
                {
                    int hpos = i;
                    if (blurArea == 3)
                    {
                        hpos = blurLayerHeight - 1 - i;
                    }
                    for (int j = 0; j < blurLayerWidth; j++)
                    {
                        Color c = fbmp.GetPixel(j,hpos);
                        fbmp.SetPixel(j,hpos, Color.FromArgb((int)Math.Floor(alpha * 255), c));
                    }
                }
            }

            fbmp.UnlockBits();
            Graphics renderTarget = Graphics.FromImage(processed);
            renderTarget.DrawImage(bluredBitmap, 0, 0, processed.Width + (processed.Height / blurLayerHeight), processed.Height+ (processed.Height / blurLayerHeight));
            renderTarget.Dispose();
            imgWallpaper.Image = processed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var temp = button2.Text;
            button2.Enabled = false;
            button2.Text = "处理中";
            Application.DoEvents();
            Process();
            button2.Enabled = true;
            button2.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(processed == null)
            {
                Process();
                Application.DoEvents();
            }
            if(saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using(FileStream f = File.Create(path))
                {
                    processed.Save(f, ImageFormat.Png);
                }
            } 
        }
        public Image readImage(string path)
        {
            using (FileStream f = File.OpenRead(path))
            {
                return Image.FromStream(f);
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                wallpaper = readImage(openFileDialog.FileName);
                imgWallpaper.Image = wallpaper;
                processed = null;
            }
        }

        private void btnSetWallpaper_Click(object sender, EventArgs e)
        {
            if (processed == null)
            {
                Process();
                Application.DoEvents();
            }
            string defaultPath =Path.Combine(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"),"com.zyfdroid.wallpaperoptimizer");
            if (!Directory.Exists(defaultPath))
            {
                Directory.CreateDirectory(defaultPath);
            }
            string filePath = Path.Combine(defaultPath, "wallpaper.png");
            processed.Save(filePath);

            if(Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                if(Environment.OSVersion.Version.Major >= 10)
                {
                    SetWallpaperWin10(filePath);
                }
                else
                {
                    SetWallpaperWin7(filePath);
                }
            }
            else
            {
                MessageBox.Show("此系统版本不受支持。");
            }
        }

        private void SetWallpaperWin7(string filePath)
        {

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, new StringBuilder(filePath), 1);
        }

        private void SetWallpaperWin10(string path)
        {
            IDesktopWallpaper wallpaperManager = (IDesktopWallpaper)new DesktopWallpaper();
            wallpaperManager.SetWallpaper(null, path);
        }
    }
}