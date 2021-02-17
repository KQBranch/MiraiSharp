using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiraiSharp.Desktop.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TsmFrmCheck_Click(object sender, System.EventArgs e)
        {
            FrmCheck frmCheck = new FrmCheck("2.2.2");
            frmCheck.Show();
        }



        public void TxtBoxOutput(string text)
        {
            Invoke(new Action(delegate ()
            {
                RtxConsole.AppendText(text + Environment.NewLine);
                if (ChkAutoScroll.Checked)
                    RtxConsole.ScrollToCaret();
            }));
        }

        private Controllers.Command _c;

        private void BtnTestConsole_Click(object sender, EventArgs e)
        {
            if (_c != null && !_c.IsNull())
                _c.Kill();
            _c = new Controllers.Command();
            _c.DataRecieve = new Action<string>((v) => TxtBoxOutput(v));
            _c.StartProgram("ping.exe", "google.com");
        }
    }
}
