using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace UwU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            SoundPlayer rap = new SoundPlayer("rap.wav");
            rap.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("UwU");
        }
    }
}