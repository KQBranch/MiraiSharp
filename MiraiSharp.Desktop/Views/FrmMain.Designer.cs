
namespace MiraiSharp.Desktop.Views
{
    partial class FrmMain
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
            this.MspMenu = new System.Windows.Forms.MenuStrip();
            this.TsmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmFrmCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.TbcTabControl = new System.Windows.Forms.TabControl();
            this.TabConsole = new System.Windows.Forms.TabPage();
            this.RtxConsole = new System.Windows.Forms.RichTextBox();
            this.ChkAutoScroll = new System.Windows.Forms.CheckBox();
            this.BtnTestConsole = new System.Windows.Forms.Button();
            this.MspMenu.SuspendLayout();
            this.TbcTabControl.SuspendLayout();
            this.TabConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // MspMenu
            // 
            this.MspMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmTools});
            this.MspMenu.Location = new System.Drawing.Point(0, 0);
            this.MspMenu.Name = "MspMenu";
            this.MspMenu.Size = new System.Drawing.Size(800, 28);
            this.MspMenu.TabIndex = 0;
            this.MspMenu.Text = "menuStrip1";
            // 
            // TsmTools
            // 
            this.TsmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmFrmCheck});
            this.TsmTools.Name = "TsmTools";
            this.TsmTools.Size = new System.Drawing.Size(55, 24);
            this.TsmTools.Text = "工具";
            // 
            // TsmFrmCheck
            // 
            this.TsmFrmCheck.Name = "TsmFrmCheck";
            this.TsmFrmCheck.Size = new System.Drawing.Size(172, 26);
            this.TsmFrmCheck.Text = "完整性检查";
            this.TsmFrmCheck.Click += new System.EventHandler(this.TsmFrmCheck_Click);
            // 
            // TbcTabControl
            // 
            this.TbcTabControl.Controls.Add(this.TabConsole);
            this.TbcTabControl.Location = new System.Drawing.Point(0, 31);
            this.TbcTabControl.Name = "TbcTabControl";
            this.TbcTabControl.SelectedIndex = 0;
            this.TbcTabControl.Size = new System.Drawing.Size(800, 407);
            this.TbcTabControl.TabIndex = 1;
            // 
            // TabConsole
            // 
            this.TabConsole.Controls.Add(this.BtnTestConsole);
            this.TabConsole.Controls.Add(this.ChkAutoScroll);
            this.TabConsole.Controls.Add(this.RtxConsole);
            this.TabConsole.Location = new System.Drawing.Point(4, 29);
            this.TabConsole.Name = "TabConsole";
            this.TabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsole.Size = new System.Drawing.Size(792, 374);
            this.TabConsole.TabIndex = 0;
            this.TabConsole.Text = "控制台";
            this.TabConsole.UseVisualStyleBackColor = true;
            // 
            // RtxConsole
            // 
            this.RtxConsole.Location = new System.Drawing.Point(3, 3);
            this.RtxConsole.Name = "RtxConsole";
            this.RtxConsole.Size = new System.Drawing.Size(680, 371);
            this.RtxConsole.TabIndex = 0;
            this.RtxConsole.Text = "";
            // 
            // ChkAutoScroll
            // 
            this.ChkAutoScroll.AutoSize = true;
            this.ChkAutoScroll.Location = new System.Drawing.Point(688, 5);
            this.ChkAutoScroll.Name = "ChkAutoScroll";
            this.ChkAutoScroll.Size = new System.Drawing.Size(95, 24);
            this.ChkAutoScroll.TabIndex = 1;
            this.ChkAutoScroll.Text = "自动滚动";
            this.ChkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // BtnTestConsole
            // 
            this.BtnTestConsole.Location = new System.Drawing.Point(688, 35);
            this.BtnTestConsole.Name = "BtnTestConsole";
            this.BtnTestConsole.Size = new System.Drawing.Size(94, 29);
            this.BtnTestConsole.TabIndex = 2;
            this.BtnTestConsole.Text = "测试";
            this.BtnTestConsole.UseVisualStyleBackColor = true;
            this.BtnTestConsole.Click += new System.EventHandler(this.BtnTestConsole_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbcTabControl);
            this.Controls.Add(this.MspMenu);
            this.MainMenuStrip = this.MspMenu;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.MspMenu.ResumeLayout(false);
            this.MspMenu.PerformLayout();
            this.TbcTabControl.ResumeLayout(false);
            this.TabConsole.ResumeLayout(false);
            this.TabConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip MspMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmTools;
        private System.Windows.Forms.ToolStripMenuItem TsmFrmCheck;
        private System.Windows.Forms.TabControl TbcTabControl;
        private System.Windows.Forms.TabPage TabConsole;
        private System.Windows.Forms.CheckBox ChkAutoScroll;
        private System.Windows.Forms.RichTextBox RtxConsole;
        private System.Windows.Forms.Button BtnTestConsole;
    }
}

