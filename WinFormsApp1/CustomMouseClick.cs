using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1
{
    internal class CustomMouseClick
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int
        dy, int cButtons, int dwExtraInfo);

        public const int LMBDown = 0x02;
        public const int LMBUp = 0x04;

        public void ClickAt(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(LMBDown, x, y, 0, 0);
            mouse_event(LMBUp, x, y, 0, 0);
        }
    }
}
