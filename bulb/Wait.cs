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
    class Wait
    {
        public static void Gif(Form form)
        {
            PictureBox pictureBox;
            pictureBox = new PictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = global::bulb.Properties.Resources.wait;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = form.Size;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            ((ISupportInitialize)(pictureBox)).BeginInit();
            form.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }
    }
}
