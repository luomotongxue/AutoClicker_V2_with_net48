using System.Security.Permissions;

namespace AutoClicker_V2
{
    static class Lang
    {
        public static string autoClickPage = "";
        public static string clickType = "";
        public static string delayTextBoxHint = "";
        public static string hotkeyComboBoxHint = "";
        public static string settingsPage = "";
        public static string changeHotkey = "";
        public static string macro = "";
        public static string mouseSideButton_1 = "";
        public static string mouseSideButton_2 = "";
        public static string changeClickTypeHotkeyComboBoxHint = "";
        public static string about = "";
        public static string author = "";
        public static string qqGroup = "";
        public static string contentUs = "";
        public static string useDoubleClick = "";
        public static string LMB = "";
        public static string RMB = "";
        public static string delay = "";

        public static void zh_cn()
        {
            // AutoClick Page
            autoClickPage = "连点";
            clickType = "点击类型";
            changeClickTypeHotkeyComboBoxHint = "切换点击类型热键";
            useDoubleClick = "使用双键连点";
            LMB = "左键";
            RMB = "右键";
            delay = "延迟 (ms)";

            // Macro Page
            macro = "宏";

            // Settings Page
            settingsPage = "设置";
            about = "关于";
            author = "作者: luomoSoft";
            qqGroup = "QQ 群: 963035295";
            contentUs = "联系我们";

            // Global
            delayTextBoxHint = "输入CPS/连点间隔(ms)";
            hotkeyComboBoxHint = "热键";
            changeHotkey = "选择一个热键";
            mouseSideButton_1 = "鼠标侧键 1";
            mouseSideButton_2 = "鼠标侧键 2";
        }

        public static void en_us()
        {
            // AutoClick Page
            autoClickPage = "AutoClick";
            clickType = "Click Type";
            useDoubleClick = "Use Double Button Click";
            LMB = "LMB";
            RMB = "RMB";
            delay = "Delay (ms)";

            // Macro Page
            macro = "Macro";

            // Settings Page
            settingsPage = "Settings";
            about = "About";
            author = "Author: luomoSoft";
            qqGroup = "QQ Group: 963035295";
            contentUs = "Content Us";

            // Global
            changeHotkey = "Choose a hot key";      
            mouseSideButton_1 = "Mouse side button 1";
            mouseSideButton_2 = "Mouse side button 2";
            changeClickTypeHotkeyComboBoxHint = "Change click type hot key";
            delayTextBoxHint = "Input CPS/Click Delay(ms)";
            hotkeyComboBoxHint = "Hot key";
        }
    }
}
