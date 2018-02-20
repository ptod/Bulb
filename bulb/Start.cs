using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace bulb
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            #region Thead animation wait
            var wait = new Thread(() =>
            {
                TaskWait();
            });
            #endregion
            #region Thead progressbar
            var tpgs = new Thread(() =>
            {
                TaskProgressBar();
            });
            #endregion
            #region Thead work
            var work = new Thread(() =>
            {
                Work();
            });
            #endregion
            #region Start thead
            wait.Start();
            tpgs.Start();
            work.Start();
            #endregion
        }

        private void Work()
        {
            
        }

        private void TaskProgressBar()
        {

        }

        private void TaskWait()
        {
            PictureBox pictureBox;
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = global::bulb.Properties.Resources.wait;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(256, 187);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            ((ISupportInitialize)(pictureBox)).BeginInit();

            panel1.Controls.Add(pictureBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wait.Gif(this);
        }
    }
}
