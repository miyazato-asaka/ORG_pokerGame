namespace 第三課題
{
    partial class Handlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Handlist));
            this.roleList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.samplePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.samplePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // roleList
            // 
            this.roleList.FormattingEnabled = true;
            this.roleList.ItemHeight = 12;
            this.roleList.Items.AddRange(new object[] {
            "ハイカード",
            "ワンペア",
            "ツーペア",
            "スリーカード",
            "ストレート",
            "フラッシュ",
            "フルハウス",
            "フォーカード",
            "ストレートフラッシュ",
            "ロイヤルストレートフラッシュ"});
            this.roleList.Location = new System.Drawing.Point(101, 12);
            this.roleList.Name = "roleList";
            this.roleList.Size = new System.Drawing.Size(134, 20);
            this.roleList.TabIndex = 0;
            this.roleList.SelectedIndexChanged += new System.EventHandler(this.roleList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "解説";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(122, 252);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 35);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "閉じる";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(9, 207);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(258, 12);
            this.description.TabIndex = 10;
            this.description.Text = "プルダウンから選択すると、適切な説明が表示されます";
            // 
            // samplePicture
            // 
            this.samplePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("samplePicture.BackgroundImage")));
            this.samplePicture.Location = new System.Drawing.Point(14, 61);
            this.samplePicture.Name = "samplePicture";
            this.samplePicture.Size = new System.Drawing.Size(323, 100);
            this.samplePicture.TabIndex = 11;
            this.samplePicture.TabStop = false;
            // 
            // Handlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.samplePicture);
            this.Controls.Add(this.description);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Handlist";
            this.Text = "hand list";
            this.Load += new System.EventHandler(this.Handlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samplePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox samplePicture;
    }
}