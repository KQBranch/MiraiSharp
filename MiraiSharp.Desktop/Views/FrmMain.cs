using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

    }
}
