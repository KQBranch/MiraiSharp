
namespace MiraiSharp.Desktop.Views
{
    partial class FrmCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCheck = new System.Windows.Forms.Button();
            this.LsvList = new System.Windows.Forms.ListView();
            this.ClhName = new System.Windows.Forms.ColumnHeader();
            this.ClhStatus = new System.Windows.Forms.ColumnHeader();
            this.ClhAddition = new System.Windows.Forms.ColumnHeader();
            this.BtnRecovery = new System.Windows.Forms.Button();
            this.PrbDownloadPercent = new System.Windows.Forms.ProgressBar();
            this.LblFixLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(694, 382);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(94, 29);
            this.BtnCheck.TabIndex = 0;
            this.BtnCheck.Text = "检查";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // LsvList
            // 
            this.LsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClhName,
            this.ClhStatus,
            this.ClhAddition});
            this.LsvList.HideSelection = false;
            this.LsvList.Location = new System.Drawing.Point(12, 12);
            this.LsvList.Name = "LsvList";
            this.LsvList.Size = new System.Drawing.Size(776, 364);
            this.LsvList.TabIndex = 1;
            this.LsvList.UseCompatibleStateImageBehavior = false;
            this.LsvList.View = System.Windows.Forms.View.Details;
            // 
            // ClhName
            // 
            this.ClhName.Text = "名称";
            this.ClhName.Width = 200;
            // 
            // ClhStatus
            // 
            this.ClhStatus.Text = "状态";
            this.ClhStatus.Width = 80;
            // 
            // ClhAddition
            // 
            this.ClhAddition.Text = "附加信息";
            this.ClhAddition.Width = 160;
            // 
            // BtnRecovery
            // 
            this.BtnRecovery.Location = new System.Drawing.Point(587, 382);
            this.BtnRecovery.Name = "BtnRecovery";
            this.BtnRecovery.Size = new System.Drawing.Size(94, 29);
            this.BtnRecovery.TabIndex = 2;
            this.BtnRecovery.Text = "修复";
            this.BtnRecovery.UseVisualStyleBackColor = true;
            this.BtnRecovery.Click += new System.EventHandler(this.BtnRecovery_Click);
            // 
            // PrbDownloadPercent
            // 
            this.PrbDownloadPercent.Location = new System.Drawing.Point(442, 382);
            this.PrbDownloadPercent.Name = "PrbDownloadPercent";
            this.PrbDownloadPercent.Size = new System.Drawing.Size(125, 29);
            this.PrbDownloadPercent.TabIndex = 3;
            this.PrbDownloadPercent.Visible = false;
            // 
            // LblFixLabel
            // 
            this.LblFixLabel.AutoSize = true;
            this.LblFixLabel.Location = new System.Drawing.Point(235, 386);
            this.LblFixLabel.Name = "LblFixLabel";
            this.LblFixLabel.Size = new System.Drawing.Size(201, 20);
            this.LblFixLabel.TabIndex = 4;
            this.LblFixLabel.Text = "正在修复第 0 个，共计 0 个";
            this.LblFixLabel.Visible = false;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.LblFixLabel);
            this.Controls.Add(this.PrbDownloadPercent);
            this.Controls.Add(this.BtnRecovery);
            this.Controls.Add(this.LsvList);
            this.Controls.Add(this.BtnCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCheck";
            this.Text = "组件检查工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.ListView LsvList;
        private System.Windows.Forms.ColumnHeader ClhName;
        private System.Windows.Forms.ColumnHeader ClhStatus;
        private System.Windows.Forms.ColumnHeader ClhAddition;
        private System.Windows.Forms.Button BtnRecovery;
        private System.Windows.Forms.ProgressBar PrbDownloadPercent;
        private System.Windows.Forms.Label LblFixLabel;
    }
}