using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GabMouseColorPicker.Properties;
using GabSoftware.Utils;

namespace GabMouseColorPicker
{
    public partial class frmMain : Form
    {
        internal GabKeyboardHook kah;
        private Boolean CaptureMouse = true;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void kah_KeyDown(object sender, KeyEventArgs e)
        {
            this.DoAction(e, this.ContainsFocus);
        }

        private void DoAction(KeyEventArgs touche, bool hasFocus)
        {
            if (touche.KeyCode == Keys.Space && touche.Control)
            {
                touche.Handled = true;
                this.CaptureMouse = !this.CaptureMouse;
                if (this.CaptureMouse == true)
                {
                    this.lblStatus.ForeColor = Color.DarkGreen;
                    this.lblStatus.Text = "Active";
                }
                else
                {
                    this.lblStatus.ForeColor = Color.DarkRed;
                    this.lblStatus.Text = "Stopped";
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // On charge les settings
            this.chkAutoCopy.Checked = Settings.Default.GMCPSetting_General_AutoCopy;
            this.rbHex.Checked = Settings.Default.GMCPSetting_General_HexValues;
            this.rbBase10.Checked = !Settings.Default.GMCPSetting_General_HexValues;
            this.rbMouse.Checked = Settings.Default.GMCPSetting_General_MousePointer;
            this.rbPosition.Checked = !Settings.Default.GMCPSetting_General_MousePointer;

            //On capture toutes les touches même si on a pas le focus
            this.kah = new GabKeyboardHook(true);
            this.kah.KeyDown += new KeyEventHandler(this.kah_KeyDown);

            //On lance le timer principal
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point pt;
            if (this.rbMouse.Checked == true && this.CaptureMouse == true )
            {
            // Get the current mouse position (screen coordinates).
                pt = MousePosition;
            }
            else
            {
                try
                {
                    pt = new Point(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
                }
                catch
                {
                    pt = new Point(0, 0);
                }
            }

            // Call the three external functions.
            Color clr;
            IntPtr hdcScreen = CreateDC("Display", null, null, IntPtr.Zero);
            int cr = GetPixel(hdcScreen, pt.X, pt.Y);
            DeleteDC(hdcScreen);

            // Convert a Win32 COLORREF to a .NET Color object

            clr = Color.FromArgb((cr & 0x000000FF),
                                 (cr & 0x0000FF00) >> 8,
                                 (cr & 0x00FF0000) >> 16);
            
            panel1.BackColor = clr;
            txtX.Text = pt.X.ToString();
            txtY.Text = pt.Y.ToString();

            //hexa ou base 10
            if (rbBase10.Checked == true)
            {
                txtR.Text = clr.R.ToString("000");
                txtG.Text = clr.G.ToString("000");
                txtB.Text = clr.B.ToString("000");
                txtCopy.Text = txtR.Text + "," + txtG.Text + "," + txtB.Text;
            }
            else
            {
                txtR.Text = clr.R.ToString("X2");
                txtG.Text = clr.G.ToString("X2");
                txtB.Text = clr.B.ToString("X2");
                txtCopy.Text = "#" + txtR.Text + txtG.Text + txtB.Text;
            }

            //copie dans le presse papier
            txtCopy.SelectAll();
            if (this.chkAutoCopy.Checked == true) txtCopy.Copy();
            
        }


        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDC(string strDriver, string strDevice,
                                             string strOutput, IntPtr pData);
        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern int GetPixel(IntPtr hdc, int x, int y);

        private void rbMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                txtX.Enabled = false;
                txtY.Enabled = false;
            }
            else
            {
                txtX.Enabled = true;
                txtY.Enabled = true;
            }
        }

        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }







    //public class Win32APICall
    //{
    //    [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
    //    public static extern IntPtr DeleteDC(IntPtr hdc);

    //    [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
    //    public static extern IntPtr DeleteObject(IntPtr hObject);

    //    [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
    //    public static extern bool BitBlt(IntPtr hdcDest, int nXDest,
    //        int nYDest, int nWidth, int nHeight, IntPtr hdcSrc,
    //        int nXSrc, int nYSrc, int dwRop);

    //    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
    //    public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc,
    //        int nWidth, int nHeight);

    //    [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
    //    public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

    //    [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
    //    public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobjBmp);

    //    [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
    //    public static extern IntPtr GetDesktopWindow();

    //    [DllImport("user32.dll", EntryPoint = "GetDC")]
    //    public static extern IntPtr GetDC(IntPtr hWnd);

    //    [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
    //    public static extern int GetSystemMetrics(int nIndex);

    //    [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
    //    public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

    //    public static Bitmap GetDesktop( int x, int y, int w, int h)
    //    {
    //        int screenX;
    //        int screenY;
    //        IntPtr hBmp;
    //        IntPtr hdcScreen = GetDC(GetDesktopWindow());
    //        IntPtr hdcCompatible = CreateCompatibleDC(hdcScreen);

    //        screenX = GetSystemMetrics(0);
    //        screenY = GetSystemMetrics(1);
    //        hBmp = CreateCompatibleBitmap(hdcScreen, screenX, screenY);

    //        if (hBmp != IntPtr.Zero)
    //        {
    //            IntPtr hOldBmp = (IntPtr)SelectObject(hdcCompatible, hBmp);
    //            //BitBlt(hdcCompatible, 0, 0, screenX, screenY, hdcScreen, 0, 0, 13369376);

                
    //            BitBlt(hdcCompatible, 0, 0, screenX, screenY, hdcScreen, 0, 0, 13369376);

    //            SelectObject(hdcCompatible, hOldBmp);
    //            DeleteDC(hdcCompatible);
    //            ReleaseDC(GetDesktopWindow(), hdcScreen);

    //            Bitmap bmp = System.Drawing.Image.FromHbitmap(hBmp);

    //            DeleteObject(hBmp);
    //            GC.Collect();

    //            return bmp;
    //        }

    //        return null;
    //    }
    //}







}