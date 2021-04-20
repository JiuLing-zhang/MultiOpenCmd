using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MultiOpenCmd.Enums;

namespace MultiOpenCmd
{
    public partial class FmMain : Form
    {
        [DllImport("User32.dll ", EntryPoint = "SetParent")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll ", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private readonly Process[] _cmdList = new Process[4];
        private SplitWindowTypeEnum _splitWindowType = SplitWindowTypeEnum.Four;
        public FmMain()
        {
            InitializeComponent();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            SplitWindow();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSplit1_Click(object sender, EventArgs e)
        {
            _splitWindowType = SplitWindowTypeEnum.One;
            SplitWindow();
        }

        private void btnSplit2_Click(object sender, EventArgs e)
        {
            _splitWindowType = SplitWindowTypeEnum.Two;
            SplitWindow();
        }

        private void btnSplit4_Click(object sender, EventArgs e)
        {
            _splitWindowType = SplitWindowTypeEnum.Four;
            SplitWindow();
        }

        private void SplitWindow()
        {
            SetSplitBtnEnabled();
            BuildCmdProcess();
            BuildCmdWindow();
        }

        private void SetSplitBtnEnabled()
        {
            if (_splitWindowType == SplitWindowTypeEnum.One)
            {
                btnSplit1.Enabled = false;
                btnSplit2.Enabled = true;
                btnSplit4.Enabled = true;
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Two)
            {
                btnSplit1.Enabled = true;
                btnSplit2.Enabled = false;
                btnSplit4.Enabled = true;
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Four)
            {
                btnSplit1.Enabled = true;
                btnSplit2.Enabled = true;
                btnSplit4.Enabled = false;
                return;
            }
        }


        private void BuildCmdProcess()
        {
            if (_splitWindowType == SplitWindowTypeEnum.One)
            {
                _cmdList[0] ??= GetOneCmdProcess();
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Two)
            {
                _cmdList[0] ??= GetOneCmdProcess();
                _cmdList[1] ??= GetOneCmdProcess();
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Four)
            {
                _cmdList[0] ??= GetOneCmdProcess();
                _cmdList[1] ??= GetOneCmdProcess();
                _cmdList[2] ??= GetOneCmdProcess();
                _cmdList[3] ??= GetOneCmdProcess();
                return;
            }

        }

        private Process GetOneCmdProcess()
        {
            var p = new Process
            {
                StartInfo = { FileName = "cmd.exe" }
            };
            p.Start();
            System.Threading.Thread.Sleep(100);
            //取消标题栏
            SetWindowLong(p.MainWindowHandle, -16, 369164288);
            return p;
        }

        private void BuildCmdWindow()
        {
            PanelMain.Controls.Clear();
            if (_splitWindowType == SplitWindowTypeEnum.One)
            {
                SetMainPanelLayout(1, 1);

                var panel1 = new Panel();
                panel1.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel1, 0, 0);
                CreateCmdWindow(_cmdList[0].MainWindowHandle, panel1.Handle);
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Two)
            {
                SetMainPanelLayout(1, 2);

                var panel1 = new Panel();
                panel1.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel1, 0, 0);
                CreateCmdWindow(_cmdList[0].MainWindowHandle, panel1.Handle);

                var panel2 = new Panel();
                panel2.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel2, 1, 0);
                CreateCmdWindow(_cmdList[1].MainWindowHandle, panel2.Handle);
                return;
            }

            if (_splitWindowType == SplitWindowTypeEnum.Four)
            {
                SetMainPanelLayout(2, 2);

                var panel1 = new Panel();
                panel1.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel1, 0, 0);
                CreateCmdWindow(_cmdList[0].MainWindowHandle, panel1.Handle);

                var panel2 = new Panel();
                panel2.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel2, 1, 0);
                CreateCmdWindow(_cmdList[1].MainWindowHandle, panel2.Handle);

                var panel3 = new Panel();
                panel3.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel3, 0, 1);
                CreateCmdWindow(_cmdList[2].MainWindowHandle, panel3.Handle);

                var panel4 = new Panel();
                panel4.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(panel4, 1, 1);
                CreateCmdWindow(_cmdList[3].MainWindowHandle, panel4.Handle);
                return;
            }
        }

        private void SetMainPanelLayout(int rowCount, int colCount)
        {
            PanelMain.RowCount = rowCount;
            for (int i = 0; i < rowCount; i++)
            {
                PanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            PanelMain.ColumnCount = colCount;
            for (int i = 0; i < colCount; i++)
            {
                PanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
        }

        private void CreateCmdWindow(IntPtr cmdHandle, IntPtr parentHandle)
        {
            SetParent(cmdHandle, parentHandle);
            ShowWindow(cmdHandle, 3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FmMain_Resize(object sender, EventArgs e)
        {
            BuildCmdWindow();
        }

        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                foreach (var process in _cmdList)
                {
                    process?.CloseMainWindow();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
