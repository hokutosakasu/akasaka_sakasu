namespace akasaka_sakasu
{
    partial class F_Kaikei
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_1 = new System.Windows.Forms.TextBox();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_1
            // 
            this.Txt_1.Location = new System.Drawing.Point(165, 95);
            this.Txt_1.Name = "Txt_1";
            this.Txt_1.Size = new System.Drawing.Size(148, 19);
            this.Txt_1.TabIndex = 0;
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Location = new System.Drawing.Point(203, 59);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(35, 12);
            this.Lbl_1.TabIndex = 1;
            this.Lbl_1.Text = "label1";
            // 
            // F_Kaikei
            // 
            this.ClientSize = new System.Drawing.Size(548, 438);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Txt_1);
            this.Name = "F_Kaikei";
            this.Load += new System.EventHandler(this.F_Kaikei_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_1;
        private System.Windows.Forms.Label Lbl_1;
    }
}

