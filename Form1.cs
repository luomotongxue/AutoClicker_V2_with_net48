using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using AutoClicker_V2_with_net48;

namespace AutoClicker_V2
{
    public partial class Form1 : MaterialForm
    {
        public const int MK_LBUTTON = 0x01; 
        public const int MK_RBUTTON = 0x02;
        private const int WM_HOTKEY = 0x0312;
        // snackbar������չʾ��Ϣ��
        private MaterialSnackBar snackBar = new MaterialSnackBar();
        // �Ƿ�ʹ���ȼ���
        private static string clickKindString = "";
        // �����ȼ���Ĭ��ΪF8��
        private Keys clickHotkey = Keys.F8;
        // �л���������ȼ���Ĭ��ΪF2��
        private Keys clickTypeHotkey = Keys.F2;
        // �����ݼ���ʶ����0Ϊ��ʹ�ã�1Ϊ���1��2Ϊ���2��
        private int xButton = 0;
        private int clickTypeXButton = 0;
        // �Ƿ��Լ������λ��
        private bool useDelay = false;
        // ���/CPS ֵ��
        private int value = 0;
        // ���ڴ洢ʵ�������㾲̬�������á�
#nullable enable
        private static Form1? _instance;
#nullable disable
        private IKeyboardMouseEvents _keyboardMouseEvents;

        public Form1()
        {
            InitializeComponent();

            // ��ֵʵ��������
            _instance = this;

            _keyboardMouseEvents = Hook.GlobalEvents();
            _keyboardMouseEvents.MouseClick += _keyboardMouseEvents_MouseClick;
            _keyboardMouseEvents.KeyDownTxt += _keyboardMouseEvents_KeyDownTxt;

            AutoClicker_V2.Click.timer.Elapsed += AutoClicker_V2.Click.Timer_Elapsed;
            AutoClicker_V2.Click.timer.AutoReset = true;

            // Ĭ��Ϊ��������
            updateLang("zh_cn");
        }

        private void _keyboardMouseEvents_KeyDownTxt(object sender, KeyDownTxtEventArgs e)
        {
            if (e.KeyEvent.KeyCode == clickHotkey && xButton == 0)
            {
                if (AutoClicker_V2.Click.isClicking)
                {
                    StopClick();
                }
                else
                {
                    StartClick();
                }
            }
            else if (e.KeyEvent.KeyCode == clickTypeHotkey && clickTypeXButton == 0)
            {
                ChangeClickType();
            }
        }

        private void _keyboardMouseEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.XButton1)
            {
                if (clickTypeXButton == 1)
                {
                    ChangeClickType();
                }
                if (xButton == 1)
                {
                    StartClick();
                }
            }
            else if (e.Button == MouseButtons.XButton2 && clickTypeXButton == 2)
            {
                if (clickTypeXButton == 2)
                {
                    ChangeClickType();
                }
                if (xButton == 2)
                {
                    StartClick();
                }
            }
        }

        private void updateLang(string lang)
        {
            switch (lang)
            {
                case "zh_cn":
                    Lang.zh_cn();
                    break;
                case "en_us":
                    Lang.en_us(); 
                    break;
            }

            // ����
            // AutoClick Page
            autoclickTitleLabel.Text = Lang.autoClickPage;
            AutoClickPage.Text = Lang.autoClickPage;
            clickKindLabel.Text = Lang.clickType;
            delayTextBox.Hint = Lang.delayTextBoxHint;
            hotkeyComboBox.Hint = Lang.hotkeyComboBoxHint;
            hotkeyComboBox.Items[1] = Lang.mouseSideButton_1;
            hotkeyComboBox.Items[2] = Lang.mouseSideButton_2;
            changeClickTypeHotkeyComboBox.Hint = Lang.changeClickTypeHotkeyComboBoxHint;
            changeClickTypeHotkeyComboBox.Items[1] = Lang.mouseSideButton_1;
            changeClickTypeHotkeyComboBox.Items[2] = Lang.mouseSideButton_2;            
            doubleClickSwitch.Text = Lang.useDoubleClick;
            LMB_RadioButton.Text = Lang.LMB;
            RMB_RadioButton.Text = Lang.RMB;
            unitComboBox.Items[1] = Lang.delay;

            // Macro Page
            macroPage.Text = Lang.macro;

            // Settings Page
            settingsPage.Text = Lang.settingsPage;
            settingsTitleLabel.Text = Lang.settingsPage;
            aboutLabel.Text = Lang.about;
            authorLabel.Text = Lang.author;
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langComboBox.SelectedIndex)
            {
                case 0:
                    updateLang("zh_cn");
                    break;
                case 1:
                    updateLang("en_us");
                    break;
            }
        }

        private void StartClick()
        {
            if (AutoClicker_V2.Click.isClicking)
            {
                StopClick();
                return;
            }

            snackBar = new MaterialSnackBar();
            snackBar.Hide();

            if ((!int.TryParse(delayTextBox.Text, out value)) || value < 0 || value > 10000)
            {
                snackBar.Text = "��������Ч������/Please input a vaild number";
                snackBar.Show(this);
                return;
            }

            if (LMB_RadioButton.Checked)
            {
                clickKindString = "LMB";
            }
            else if (RMB_RadioButton.Checked)
            {
                clickKindString = "RMB";
            }
            else if (doubleClickSwitch.Checked)
            {
                clickKindString = "Double";
            }

            useDelay = unitComboBox.SelectedIndex == 1 ? true : false;

            this.Invoke(new Action(() =>
            {
                AutoClicker_V2.Click.StartClick(clickKindString, useDelay, value);
            }));

            // hide window
            Hide();
        }

        private void StopClick()
        {
            AutoClicker_V2.Click.StopClick();
            Show();
        }

        private void hotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (hotkeyComboBox.SelectedIndex)
            {
                case 0:
                    // ��ʹ�ò��
                    xButton = 0;

                    break;
                case 1:
                    // ʹ�ò�� 1
                    xButton = 1;

                    break;
                case 2:
                    // ʹ�ò�� 2
                    xButton = 2;

                    break;
                case 3:
                    AutoClicker_V2_with_net48.MaskForm maskForm = new MaskForm(this.Location, this.Size);
                    maskForm.Owner = this;
                    maskForm.Show();
                    ChooseHotkeyDialog chooseHotkeyDialog = new ChooseHotkeyDialog();
                    chooseHotkeyDialog.Owner = maskForm;
                    chooseHotkeyDialog.ShowDialog(maskForm);

                    if (chooseHotkeyDialog.DialogResult == DialogResult.OK)
                    {
                        // ע�����ȼ�
                        clickHotkey = chooseHotkeyDialog.Key;
                        hotkeyComboBox.Items[0] = clickHotkey;
                    }

                    maskForm.Dispose();
                    hotkeyComboBox.SelectedIndex = 0;

                    break;

            }
        }

        private void chooseChangeClickTypeHotkeyButton_Click(object sender, EventArgs e)
        {
            ChooseHotkeyDialog chooseHotkeyDialog = new ChooseHotkeyDialog();

            if (chooseHotkeyDialog.ShowDialog() == DialogResult.OK)
            {
                clickTypeHotkey = chooseHotkeyDialog.Key;
                changeClickTypeHotkeyComboBox.Items[0] = chooseHotkeyDialog.KeyName;
            }
        }

        private void changeClickTypeHotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (changeClickTypeHotkeyComboBox.SelectedIndex)
            {
                case 0:
                    clickTypeXButton = 0;

                    break;
                case 1:
                    clickTypeXButton = 1;

                    break;
                case 2:
                    clickTypeXButton = 2;

                    break;
                case 3:
                    AutoClicker_V2_with_net48.MaskForm maskForm = new MaskForm(this.Location, this.Size);
                    maskForm.Owner = this;
                    maskForm.Show();
                    ChooseHotkeyDialog chooseHotkeyDialog = new ChooseHotkeyDialog();
                    chooseHotkeyDialog.Owner = maskForm;
                    chooseHotkeyDialog.ShowDialog(maskForm);

                    if (chooseHotkeyDialog.DialogResult == DialogResult.OK)
                    {
                        // ע�����ȼ�
                        clickHotkey = chooseHotkeyDialog.Key;
                        hotkeyComboBox.Items[0] = clickHotkey;
                    }

                    maskForm.Dispose();
                    changeClickTypeHotkeyComboBox.SelectedIndex = 0;

                    break;
            }
        }

        private void ChangeClickType()
        {
            // LMB to RMB
            if (LMB_RadioButton.Checked)
            {
                LMB_RadioButton.Checked = false;
                RMB_RadioButton.Checked = true;
                clickKindString = "RMB";
            }
            // RMB to LMB
            else if (RMB_RadioButton.Checked)
            {
                RMB_RadioButton.Checked = false;
                LMB_RadioButton.Checked = true;
                clickKindString = "LMB";
            }

            // hot change
            if (AutoClicker_V2.Click.isClicking)
            {
                StopClick();
                StartClick();
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // �� Github ҳ�������
            string command = "start https://github.com/luomotongxue/AutoClicker_V2";

            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(command + "&exit");

                process.WaitForExit();
                process.Close();
            }
        }

        private void LMB_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LMB_RadioButton.Checked)
            {
                doubleClickSwitch.Checked = false;
            }
        }

        private void RMB_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RMB_RadioButton.Checked)
            {
                doubleClickSwitch.Checked = false;
            }
        }

        private void doubleClickSwitch_CheckedChanged_1(object sender, EventArgs e)
        {
            if (doubleClickSwitch.Checked)
            {
                LMB_RadioButton.Checked = false;
                RMB_RadioButton.Checked = false;
            }
            else
            {
                LMB_RadioButton.Checked = true;
            }
        }
    }
}