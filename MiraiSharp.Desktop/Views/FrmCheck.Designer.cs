
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
            this.ClhName.Width = 160;
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
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.LsvList);
            this.Controls.Add(this.BtnCheck);
            this.Name = "FrmCheck";
            this.Text = "FrmCheck";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.ListView LsvList;
        private System.Windows.Forms.ColumnHeader ClhName;
        private System.Windows.Forms.ColumnHeader ClhStatus;
        private System.Windows.Forms.ColumnHeader ClhAddition;
    }
}