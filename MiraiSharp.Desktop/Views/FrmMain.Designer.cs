
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
            this.MspMenu.SuspendLayout();
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
            this.TsmFrmCheck.Text = "完整性检查";
            this.TsmFrmCheck.Size = new System.Drawing.Size(172, 26);
            this.TsmFrmCheck.Click += new System.EventHandler(this.TsmFrmCheck_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MspMenu);
            this.MainMenuStrip = this.MspMenu;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.MspMenu.ResumeLayout(false);
            this.MspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip MspMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmTools;
        private System.Windows.Forms.ToolStripMenuItem TsmFrmCheck;
    }
}

