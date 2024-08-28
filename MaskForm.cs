using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_V2_with_net48
{
    public partial class MaskForm : Form
    {
        public MaskForm(Point point, Size size)
        {
            InitializeComponent();
            Opacity = 0.8;
            BackColor = Color.LightSlateGray;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            //位置和大小跟随主界面
            Location = point;
            Size = size;
        }
        private void MaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
