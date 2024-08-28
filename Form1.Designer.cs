using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.AutoClickPage = new System.Windows.Forms.TabPage();
            this.autoclickTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.changeClickTypeHotkeyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.autoClickModeEP = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.doubleClickSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.RMB_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.LMB_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.clickKindLabel = new MaterialSkin.Controls.MaterialLabel();
            this.delayTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.unitComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.hotkeyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.macroPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.aboutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.qqGroupLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.contentUsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.authorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.langComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.tipsLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl.SuspendLayout();
            this.AutoClickPage.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.autoClickModeEP.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AutoClickPage);
            this.TabControl.Controls.Add(this.macroPage);
            this.TabControl.Controls.Add(this.settingsPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(847, 518);
            this.TabControl.TabIndex = 0;
            // 
            // AutoClickPage
            // 
            this.AutoClickPage.BackColor = System.Drawing.Color.White;
            this.AutoClickPage.Controls.Add(this.autoclickTitleLabel);
            this.AutoClickPage.Controls.Add(this.materialCard1);
            this.AutoClickPage.Location = new System.Drawing.Point(4, 28);
            this.AutoClickPage.Name = "AutoClickPage";
            this.AutoClickPage.Padding = new System.Windows.Forms.Padding(3);
            this.AutoClickPage.Size = new System.Drawing.Size(839, 486);
            this.AutoClickPage.TabIndex = 0;
            this.AutoClickPage.Text = "AutoClick";
            // 
            // autoclickTitleLabel
            // 
            this.autoclickTitleLabel.AutoSize = true;
            this.autoclickTitleLabel.Depth = 0;
            this.autoclickTitleLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.autoclickTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.autoclickTitleLabel.Location = new System.Drawing.Point(10, 14);
            this.autoclickTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoclickTitleLabel.Name = "autoclickTitleLabel";
            this.autoclickTitleLabel.Size = new System.Drawing.Size(109, 33);
            this.autoclickTitleLabel.TabIndex = 1;
            this.autoclickTitleLabel.Text = "AutoClick";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.changeClickTypeHotkeyComboBox);
            this.materialCard1.Controls.Add(this.autoClickModeEP);
            this.materialCard1.Controls.Add(this.hotkeyComboBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 57);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(818, 417);
            this.materialCard1.TabIndex = 0;
            // 
            // changeClickTypeHotkeyComboBox
            // 
            this.changeClickTypeHotkeyComboBox.AutoResize = false;
            this.changeClickTypeHotkeyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.changeClickTypeHotkeyComboBox.Depth = 0;
            this.changeClickTypeHotkeyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.changeClickTypeHotkeyComboBox.DropDownHeight = 174;
            this.changeClickTypeHotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeClickTypeHotkeyComboBox.DropDownWidth = 121;
            this.changeClickTypeHotkeyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.changeClickTypeHotkeyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeClickTypeHotkeyComboBox.FormattingEnabled = true;
            this.changeClickTypeHotkeyComboBox.Hint = "Change click type hot key";
            this.changeClickTypeHotkeyComboBox.IntegralHeight = false;
            this.changeClickTypeHotkeyComboBox.ItemHeight = 43;
            this.changeClickTypeHotkeyComboBox.Items.AddRange(new object[] {
            "F2",
            "Mouse side button 1",
            "Mouse side button 2",
            "Custom..."});
            this.changeClickTypeHotkeyComboBox.Location = new System.Drawing.Point(13, 351);
            this.changeClickTypeHotkeyComboBox.MaxDropDownItems = 4;
            this.changeClickTypeHotkeyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.changeClickTypeHotkeyComboBox.Name = "changeClickTypeHotkeyComboBox";
            this.changeClickTypeHotkeyComboBox.Size = new System.Drawing.Size(788, 49);
            this.changeClickTypeHotkeyComboBox.StartIndex = 0;
            this.changeClickTypeHotkeyComboBox.TabIndex = 4;
            this.changeClickTypeHotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.changeClickTypeHotkeyComboBox_SelectedIndexChanged);
            // 
            // autoClickModeEP
            // 
            this.autoClickModeEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoClickModeEP.Controls.Add(this.doubleClickSwitch);
            this.autoClickModeEP.Controls.Add(this.materialCard2);
            this.autoClickModeEP.Controls.Add(this.delayTextBox);
            this.autoClickModeEP.Controls.Add(this.unitComboBox);
            this.autoClickModeEP.Depth = 0;
            this.autoClickModeEP.Description = "";
            this.autoClickModeEP.ExpandHeight = 256;
            this.autoClickModeEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.autoClickModeEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.autoClickModeEP.Location = new System.Drawing.Point(17, 14);
            this.autoClickModeEP.Margin = new System.Windows.Forms.Padding(16);
            this.autoClickModeEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoClickModeEP.Name = "autoClickModeEP";
            this.autoClickModeEP.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.autoClickModeEP.ShowValidationButtons = false;
            this.autoClickModeEP.Size = new System.Drawing.Size(788, 256);
            this.autoClickModeEP.TabIndex = 7;
            this.autoClickModeEP.Title = "Auto Click";
            // 
            // doubleClickSwitch
            // 
            this.doubleClickSwitch.AutoSize = true;
            this.doubleClickSwitch.Depth = 0;
            this.doubleClickSwitch.Location = new System.Drawing.Point(8, 200);
            this.doubleClickSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.doubleClickSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.doubleClickSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.doubleClickSwitch.Name = "doubleClickSwitch";
            this.doubleClickSwitch.Ripple = true;
            this.doubleClickSwitch.Size = new System.Drawing.Size(211, 37);
            this.doubleClickSwitch.TabIndex = 6;
            this.doubleClickSwitch.Text = "Enable Double Click";
            this.doubleClickSwitch.UseVisualStyleBackColor = true;
            this.doubleClickSwitch.CheckedChanged += new System.EventHandler(this.doubleClickSwitch_CheckedChanged_1);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.RMB_RadioButton);
            this.materialCard2.Controls.Add(this.LMB_RadioButton);
            this.materialCard2.Controls.Add(this.clickKindLabel);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(9, 58);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(762, 60);
            this.materialCard2.TabIndex = 2;
            // 
            // RMB_RadioButton
            // 
            this.RMB_RadioButton.AutoSize = true;
            this.RMB_RadioButton.Depth = 0;
            this.RMB_RadioButton.Location = new System.Drawing.Point(640, 10);
            this.RMB_RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.RMB_RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RMB_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RMB_RadioButton.Name = "RMB_RadioButton";
            this.RMB_RadioButton.Ripple = true;
            this.RMB_RadioButton.Size = new System.Drawing.Size(107, 37);
            this.RMB_RadioButton.TabIndex = 1;
            this.RMB_RadioButton.TabStop = true;
            this.RMB_RadioButton.Text = "右键/RMB";
            this.RMB_RadioButton.UseVisualStyleBackColor = true;
            // 
            // LMB_RadioButton
            // 
            this.LMB_RadioButton.AutoSize = true;
            this.LMB_RadioButton.Checked = true;
            this.LMB_RadioButton.Depth = 0;
            this.LMB_RadioButton.Location = new System.Drawing.Point(91, 10);
            this.LMB_RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.LMB_RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LMB_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LMB_RadioButton.Name = "LMB_RadioButton";
            this.LMB_RadioButton.Ripple = true;
            this.LMB_RadioButton.Size = new System.Drawing.Size(106, 37);
            this.LMB_RadioButton.TabIndex = 0;
            this.LMB_RadioButton.TabStop = true;
            this.LMB_RadioButton.Text = "左键/LMB";
            this.LMB_RadioButton.UseVisualStyleBackColor = true;
            // 
            // clickKindLabel
            // 
            this.clickKindLabel.AutoSize = true;
            this.clickKindLabel.Depth = 0;
            this.clickKindLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.clickKindLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.clickKindLabel.Location = new System.Drawing.Point(14, 19);
            this.clickKindLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickKindLabel.Name = "clickKindLabel";
            this.clickKindLabel.Size = new System.Drawing.Size(65, 19);
            this.clickKindLabel.TabIndex = 1;
            this.clickKindLabel.Text = "Click type";
            // 
            // delayTextBox
            // 
            this.delayTextBox.AnimateReadOnly = false;
            this.delayTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.delayTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.delayTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delayTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.delayTextBox.Depth = 0;
            this.delayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.delayTextBox.HideSelection = true;
            this.delayTextBox.Hint = "Input CPS/Click Delay(ms)";
            this.delayTextBox.LeadingIcon = null;
            this.delayTextBox.Location = new System.Drawing.Point(9, 135);
            this.delayTextBox.MaxLength = 32767;
            this.delayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.PasswordChar = '\0';
            this.delayTextBox.PrefixSuffixText = null;
            this.delayTextBox.ReadOnly = false;
            this.delayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delayTextBox.SelectedText = "";
            this.delayTextBox.SelectionLength = 0;
            this.delayTextBox.SelectionStart = 0;
            this.delayTextBox.ShortcutsEnabled = true;
            this.delayTextBox.Size = new System.Drawing.Size(578, 48);
            this.delayTextBox.TabIndex = 0;
            this.delayTextBox.TabStop = false;
            this.delayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.delayTextBox.TrailingIcon = null;
            this.delayTextBox.UseSystemPasswordChar = false;
            // 
            // unitComboBox
            // 
            this.unitComboBox.AutoResize = false;
            this.unitComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.unitComboBox.Depth = 0;
            this.unitComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.unitComboBox.DropDownHeight = 174;
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.DropDownWidth = 121;
            this.unitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.unitComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.IntegralHeight = false;
            this.unitComboBox.ItemHeight = 43;
            this.unitComboBox.Items.AddRange(new object[] {
            "CPS",
            "延迟/Delay(ms)"});
            this.unitComboBox.Location = new System.Drawing.Point(593, 134);
            this.unitComboBox.MaxDropDownItems = 4;
            this.unitComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(178, 49);
            this.unitComboBox.StartIndex = 0;
            this.unitComboBox.TabIndex = 1;
            // 
            // hotkeyComboBox
            // 
            this.hotkeyComboBox.AutoResize = false;
            this.hotkeyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hotkeyComboBox.Depth = 0;
            this.hotkeyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hotkeyComboBox.DropDownHeight = 174;
            this.hotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotkeyComboBox.DropDownWidth = 121;
            this.hotkeyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hotkeyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotkeyComboBox.FormattingEnabled = true;
            this.hotkeyComboBox.Hint = "Click hot key";
            this.hotkeyComboBox.IntegralHeight = false;
            this.hotkeyComboBox.ItemHeight = 43;
            this.hotkeyComboBox.Items.AddRange(new object[] {
            "F8",
            "Mouse side button 1",
            "Mouse side button 2",
            "Custom..."});
            this.hotkeyComboBox.Location = new System.Drawing.Point(13, 289);
            this.hotkeyComboBox.MaxDropDownItems = 4;
            this.hotkeyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.hotkeyComboBox.Name = "hotkeyComboBox";
            this.hotkeyComboBox.Size = new System.Drawing.Size(788, 49);
            this.hotkeyComboBox.StartIndex = 0;
            this.hotkeyComboBox.TabIndex = 2;
            this.hotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.hotkeyComboBox_SelectedIndexChanged);
            // 
            // macroPage
            // 
            this.macroPage.BackColor = System.Drawing.Color.White;
            this.macroPage.Location = new System.Drawing.Point(4, 28);
            this.macroPage.Name = "macroPage";
            this.macroPage.Padding = new System.Windows.Forms.Padding(3);
            this.macroPage.Size = new System.Drawing.Size(839, 486);
            this.macroPage.TabIndex = 1;
            this.macroPage.Text = "Macro";
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.White;
            this.settingsPage.Controls.Add(this.materialLabel8);
            this.settingsPage.Controls.Add(this.aboutLabel);
            this.settingsPage.Controls.Add(this.materialCard8);
            this.settingsPage.Controls.Add(this.langComboBox);
            this.settingsPage.Controls.Add(this.tipsLabel1);
            this.settingsPage.Controls.Add(this.settingsTitleLabel);
            this.settingsPage.Location = new System.Drawing.Point(4, 28);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(839, 486);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "Settings";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(293, 594);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(321, 23);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "©2022-2024 luomoSoft.All right reserved.";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Depth = 0;
            this.aboutLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.aboutLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.aboutLabel.Location = new System.Drawing.Point(12, 148);
            this.aboutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(57, 28);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.Text = "About";
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.materialCard3);
            this.materialCard8.Controls.Add(this.contentUsLabel);
            this.materialCard8.Controls.Add(this.materialLabel4);
            this.materialCard8.Controls.Add(this.authorLabel);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(6, 178);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(819, 190);
            this.materialCard8.TabIndex = 3;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.qqGroupLabel);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(11, 88);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(791, 84);
            this.materialCard3.TabIndex = 5;
            // 
            // qqGroupLabel
            // 
            this.qqGroupLabel.AutoSize = true;
            this.qqGroupLabel.Depth = 0;
            this.qqGroupLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.qqGroupLabel.Location = new System.Drawing.Point(16, 14);
            this.qqGroupLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.qqGroupLabel.Name = "qqGroupLabel";
            this.qqGroupLabel.Size = new System.Drawing.Size(167, 23);
            this.qqGroupLabel.TabIndex = 3;
            this.qqGroupLabel.Text = "QQ Group: 963035295";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(16, 37);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(265, 23);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "E-mail:luomotongxue@gmail.com";
            // 
            // contentUsLabel
            // 
            this.contentUsLabel.AutoSize = true;
            this.contentUsLabel.Depth = 0;
            this.contentUsLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contentUsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.contentUsLabel.Location = new System.Drawing.Point(16, 55);
            this.contentUsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.contentUsLabel.Name = "contentUsLabel";
            this.contentUsLabel.Size = new System.Drawing.Size(104, 28);
            this.contentUsLabel.TabIndex = 2;
            this.contentUsLabel.Text = "Content Us";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 33);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(1, 0);
            this.materialLabel4.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Depth = 0;
            this.authorLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorLabel.Location = new System.Drawing.Point(17, 14);
            this.authorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(145, 23);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Author: luomoSoft";
            // 
            // langComboBox
            // 
            this.langComboBox.AutoResize = false;
            this.langComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langComboBox.Depth = 0;
            this.langComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.langComboBox.DropDownHeight = 174;
            this.langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langComboBox.DropDownWidth = 121;
            this.langComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.langComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.IntegralHeight = false;
            this.langComboBox.ItemHeight = 43;
            this.langComboBox.Items.AddRange(new object[] {
            "简体中文",
            "English"});
            this.langComboBox.Location = new System.Drawing.Point(4, 87);
            this.langComboBox.MaxDropDownItems = 4;
            this.langComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(821, 49);
            this.langComboBox.StartIndex = 0;
            this.langComboBox.TabIndex = 2;
            this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
            // 
            // tipsLabel1
            // 
            this.tipsLabel1.AutoSize = true;
            this.tipsLabel1.Depth = 0;
            this.tipsLabel1.Font = new System.Drawing.Font("思源黑体 CN Regular", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tipsLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.tipsLabel1.Location = new System.Drawing.Point(6, 56);
            this.tipsLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tipsLabel1.Name = "tipsLabel1";
            this.tipsLabel1.Size = new System.Drawing.Size(139, 28);
            this.tipsLabel1.TabIndex = 1;
            this.tipsLabel1.Text = "语言/Language";
            // 
            // settingsTitleLabel
            // 
            this.settingsTitleLabel.AutoSize = true;
            this.settingsTitleLabel.Depth = 0;
            this.settingsTitleLabel.Font = new System.Drawing.Font("思源黑体 CN Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.settingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.settingsTitleLabel.Location = new System.Drawing.Point(6, 12);
            this.settingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsTitleLabel.Name = "settingsTitleLabel";
            this.settingsTitleLabel.Size = new System.Drawing.Size(93, 33);
            this.settingsTitleLabel.TabIndex = 0;
            this.settingsTitleLabel.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 585);
            this.Controls.Add(this.TabControl);
            this.DrawerTabControl = this.TabControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker V2";
            this.TabControl.ResumeLayout(false);
            this.AutoClickPage.ResumeLayout(false);
            this.AutoClickPage.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.autoClickModeEP.ResumeLayout(false);
            this.autoClickModeEP.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private TabPage AutoClickPage;
        private TabPage macroPage;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel clickKindLabel;
        private MaterialSkin.Controls.MaterialLabel autoclickTitleLabel;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialRadioButton LMB_RadioButton;
        private MaterialSkin.Controls.MaterialComboBox unitComboBox;
        private MaterialSkin.Controls.MaterialComboBox hotkeyComboBox;
        private TabPage settingsPage;
        private MaterialSkin.Controls.MaterialComboBox langComboBox;
        private MaterialSkin.Controls.MaterialLabel tipsLabel1;
        private MaterialSkin.Controls.MaterialLabel settingsTitleLabel;
        private MaterialSkin.Controls.MaterialRadioButton RMB_RadioButton;
        private MaterialSkin.Controls.MaterialTextBox2 delayTextBox;
        private MaterialSkin.Controls.MaterialComboBox changeClickTypeHotkeyComboBox;
        private MaterialSkin.Controls.MaterialLabel aboutLabel;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel authorLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel qqGroupLabel;
        private MaterialSkin.Controls.MaterialLabel contentUsLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSwitch doubleClickSwitch;
        private MaterialSkin.Controls.MaterialExpansionPanel autoClickModeEP;
        private MaterialSkin.Controls.MaterialCard materialCard3;
    }
}
