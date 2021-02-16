using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiraiSharp.Desktop.Views
{
    public partial class FrmCheck : Form
    {
        public ListViewItem CreateEmptyLVI()
        {
            return new ListViewItem();

        }
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            var m = Library.Mirai.Components.Check("2.2.2").Result;
            LsvList.Items.Clear();
            foreach (var n in m)
            {
                var lvi = CreateEmptyLVI();
                lvi.Text = n.Key;
                lvi.SubItems.AddRange(new string[] { n.Value.ToString(), "" });
                LsvList.Items.Add(lvi);
            }
            var lvii = CreateEmptyLVI();
            lvii.Text = "Java";
            lvii.SubItems.AddRange(new string[] {
                Library.Java.Check.IsVersionOver("1.8")? "Ok" : "Lost",
                Library.Java.Check.GetJavaBuild()});
            LsvList.Items.Add(lvii);
            LsvList.Update();
        }
    }
}
