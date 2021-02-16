using MiraiSharp.Library.Mirai;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        private async void BtnCheck_Click(object sender, EventArgs e)
        {
            await Check("2.2.2");
        }

        private async Task<Dictionary<string, ComponentStatusEnum>> Check(string version)
        {
            Dictionary<string, ComponentStatusEnum> m = null;

            m = await Components.Check(version);

            LsvList.Items.Clear();
            foreach (var n in m)
            {
                var lvi = CreateEmptyLVI();
                lvi.Text = n.Key;
                lvi.SubItems.AddRange(new string[] { n.Value.ToString(), version });
                LsvList.Items.Add(lvi);
            }
            var lvii = CreateEmptyLVI();
            lvii.Text = "Java";
            lvii.SubItems.AddRange(new string[] {
                Library.Java.Check.IsVersionOver("1.8")? "Ok" : "Lost",
                Library.Java.Check.GetJavaBuild()});
            LsvList.Items.Add(lvii);
            LsvList.Update();

            return m;
        }

        private async void BtnRecovery_Click(object sender, EventArgs e)
        {
            Library.IO.Path.Initialize();
            var stat = await Check("2.2.2");
            PrbDownloadPercent.Visible = true;
            LblFixLabel.Visible = true;

            int index = 0;

            foreach (var kv in stat)
            {
                ++index;
                LblFixLabel.Text = $"正在修复第 {index} 个，共计 {stat.Count} 个";
                if (kv.Value != ComponentStatusEnum.Ok)
                {
                    SetProgressBar(0);
                    Components.Downloader dl = new Components.Downloader();
                    dl.OnStepProgressChange += (o, e) =>
                s    {
                        SafeSetProgressBar((int)dl.StepProgress);
                    };
                    await dl.DownloadComponent(kv.Key, "2.2.2");
                    LsvList.Items[index - 1].SubItems[1].Text = "Ok";
                    SetProgressBar(100);
                    
                }
            }

            MessageBox.Show("修复完成！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrbDownloadPercent.Visible = false;
            LblFixLabel.Visible = false;
        }

        private void SafeSetProgressBar(int v)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                PrbDownloadPercent.Value = v;
                PrbDownloadPercent.Update();
            }));

        }

        private void SetProgressBar(int v)
        {
            PrbDownloadPercent.Value = v;
            PrbDownloadPercent.Update();
        }
    }
}
