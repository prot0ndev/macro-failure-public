using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private bool autoClickerEnabled = false;
        private bool autoClickerReady = false;

        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                if (autoClickerReady)
                {
                    autoClickerEnabled = !autoClickerEnabled;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Autoclicker_Tick(object sender, EventArgs e)
        {
            if (autoClickerEnabled)
            {
                if (!Bounds.Contains(PointToClient(MousePosition)))
                {
                    mouse_event(0x02, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(10);
                    mouse_event(0x04, 0, 0, 0, 0);
                }
            }
        }


        private void StartAutoClick()
        {
            autoClickerEnabled = true;
            autoClickerReady = true;
            Autoclicker.Interval = (int)(1000.0 / CPSbar.Value);
            Autoclicker.Start();
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = false;
        }

        private void StopAutoClick()
        {
            autoClickerEnabled = false;
            autoClickerReady = false;
            Autoclicker.Stop();
            ButtonStart.Enabled = true;
            ButtonStop.Enabled = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartAutoClick();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            StopAutoClick();
        }

        private void CPSbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPStext.Text = CPSbar.Value.ToString();
        }
    }
}
