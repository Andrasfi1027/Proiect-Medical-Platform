using GMap.NET.WindowsForms;

namespace WinFormsApp1.Extension
{
    public static class GMapControlExtension //naming convention
    {
        public static void RefreshMap(this GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
    }
}