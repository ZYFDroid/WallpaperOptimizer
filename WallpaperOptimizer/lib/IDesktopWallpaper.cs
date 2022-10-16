using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperOptimizer.lib
{
    [ComImport]
    [Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDesktopWallpaper
    {
        void SetWallpaper([MarshalAs(UnmanagedType.LPWStr)][In] string monitorID, [MarshalAs(UnmanagedType.LPWStr)][In] string wallpaper);

        void GetWallpaper([MarshalAs(UnmanagedType.LPWStr)][In] string monitorID, [MarshalAs(UnmanagedType.LPWStr)][Out] out string wallpaper);

        void GetMonitorDevicePathAt([MarshalAs(UnmanagedType.U4)][In] uint monitorIndex, [MarshalAs(UnmanagedType.LPWStr)][Out] out string monitorID);

        void GetMonitorDevicePathCount([MarshalAs(UnmanagedType.U4)][Out] out uint count);
    }

    [ComImport]
    [Guid("C2CF3110-460E-4fc1-B9D0-8A1C0C9CC4BD")]
    public class DesktopWallpaper
    {
    }
}
