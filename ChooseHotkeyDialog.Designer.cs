using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker_V2
{
    partial class ChooseHotkeyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hotkeyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.okButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Depth = 0;
            this.hotkeyLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hotkeyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.hotkeyLabel.Location = new System.Drawing.Point(258, 118);
            this.hotkeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hotkeyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(121, 67);
            this.hotkeyLabel.TabIndex = 0;
            this.hotkeyLabel.Text = "None";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(515, 278);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(112, 36);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消/Cancel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // okButton
            // 
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.okButton.Depth = 0;
            this.okButton.HighEmphasis = true;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(432, 278);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.okButton.Size = new System.Drawing.Size(77, 36);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "确定/Ok";
            this.okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.okButton.UseAccentColor = false;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // ChooseHotkeyDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(632, 320);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.hotkeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseHotkeyDialog";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a hot key/选择热键";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChooseHotkeyDialog_KeyDown);
            this.Resize += new System.EventHandler(this.ChooseHotkeyDialog_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel hotkeyLabel;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton okButton;
    }
}