using MaterialSkin.Controls;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker_V2
{
    public partial class ChooseHotkeyDialog : MaterialForm
    {
        private Keys _key;
        private string _keyName;

        public Keys Key
        {
            get
            {
                return _key;
            }
            private set
            {
                _key = value;
            }
        }

        public string KeyName
        {
            get
            {
                return _keyName;
            }
            set
            {
                _keyName = value;
            }
        }

        public ChooseHotkeyDialog()
        {
            InitializeComponent();
            SetWindowRegion();
            KeyPreview = true;
        }

        private void ChooseHotkeyDialog_KeyDown(object sender, KeyEventArgs e)
        {
            Key = e.KeyCode;
            KeyName = e.KeyCode.ToString();
            hotkeyLabel.Text = e.KeyCode.ToString();
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 50);
            this.Region = new Region(FormPath);

        }
        /// <summary>
        /// 绘制圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        /// <summary>
        /// 窗体size发生改变时重新设置Region属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseHotkeyDialog_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }
    }
}
