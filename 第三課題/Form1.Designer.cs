namespace 第三課題
{
    partial class Poker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poker));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inOutBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.handListBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.allSelectBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.debugStartBtn = new System.Windows.Forms.Button();
            this.debugEndBtn = new System.Windows.Forms.Button();
            this.cardOptionBox1 = new System.Windows.Forms.ComboBox();
            this.cardOptionBox2 = new System.Windows.Forms.ComboBox();
            this.cardOptionBox3 = new System.Windows.Forms.ComboBox();
            this.cardOptionBox4 = new System.Windows.Forms.ComboBox();
            this.cardOptionBox5 = new System.Windows.Forms.ComboBox();
            this.remCountNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Card1,
            this.Card2,
            this.Card3,
            this.Card4,
            this.Card5,
            this.role});
            this.dataGridView1.Location = new System.Drawing.Point(2, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(564, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // No
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 30;
            // 
            // Card1
            // 
            this.Card1.HeaderText = "手札1";
            this.Card1.Name = "Card1";
            this.Card1.Width = 60;
            // 
            // Card2
            // 
            this.Card2.HeaderText = "手札2";
            this.Card2.Name = "Card2";
            this.Card2.Width = 60;
            // 
            // Card3
            // 
            this.Card3.HeaderText = "手札3";
            this.Card3.Name = "Card3";
            this.Card3.Width = 60;
            // 
            // Card4
            // 
            this.Card4.HeaderText = "手札4";
            this.Card4.Name = "Card4";
            this.Card4.Width = 60;
            // 
            // Card5
            // 
            this.Card5.HeaderText = "手札5";
            this.Card5.Name = "Card5";
            this.Card5.Width = 60;
            // 
            // role
            // 
            this.role.HeaderText = "役";
            this.role.Name = "role";
            this.role.Width = 190;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(236, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(348, 229);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(460, 229);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 152);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(58, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(170, 387);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(279, 387);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(391, 387);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(502, 387);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "あと";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "回";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "残回数↓";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(233, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "勝敗記録";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(319, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 10);
            this.label6.TabIndex = 21;
            this.label6.Text = "※10回以降は古いものから順に上書きされます。";
            // 
            // inOutBox
            // 
            this.inOutBox.Location = new System.Drawing.Point(157, 186);
            this.inOutBox.Name = "inOutBox";
            this.inOutBox.Size = new System.Drawing.Size(273, 29);
            this.inOutBox.TabIndex = 22;
            this.inOutBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // handListBtn
            // 
            this.handListBtn.Location = new System.Drawing.Point(572, 133);
            this.handListBtn.Name = "handListBtn";
            this.handListBtn.Size = new System.Drawing.Size(86, 42);
            this.handListBtn.TabIndex = 24;
            this.handListBtn.Text = "ハンドリスト";
            this.handListBtn.UseVisualStyleBackColor = true;
            this.handListBtn.Click += new System.EventHandler(this.handListBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Enabled = false;
            this.endBtn.Location = new System.Drawing.Point(572, 83);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(86, 39);
            this.endBtn.TabIndex = 25;
            this.endBtn.Text = "終了";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(572, 38);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(86, 39);
            this.startBtn.TabIndex = 26;
            this.startBtn.Text = "スタート";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // allSelectBtn
            // 
            this.allSelectBtn.Enabled = false;
            this.allSelectBtn.Location = new System.Drawing.Point(573, 274);
            this.allSelectBtn.Name = "allSelectBtn";
            this.allSelectBtn.Size = new System.Drawing.Size(85, 40);
            this.allSelectBtn.TabIndex = 27;
            this.allSelectBtn.Text = "全選択/解除";
            this.allSelectBtn.UseVisualStyleBackColor = true;
            this.allSelectBtn.Click += new System.EventHandler(this.allSelectBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Enabled = false;
            this.changeBtn.Location = new System.Drawing.Point(573, 229);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(85, 39);
            this.changeBtn.TabIndex = 28;
            this.changeBtn.Text = "手札を変更";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // debugStartBtn
            // 
            this.debugStartBtn.Location = new System.Drawing.Point(573, 38);
            this.debugStartBtn.Name = "debugStartBtn";
            this.debugStartBtn.Size = new System.Drawing.Size(85, 42);
            this.debugStartBtn.TabIndex = 29;
            this.debugStartBtn.Text = "デバック開始";
            this.debugStartBtn.UseVisualStyleBackColor = true;
            this.debugStartBtn.Visible = false;
            this.debugStartBtn.Click += new System.EventHandler(this.debugStartBtn_Click);
            // 
            // debugEndBtn
            // 
            this.debugEndBtn.Location = new System.Drawing.Point(573, 83);
            this.debugEndBtn.Name = "debugEndBtn";
            this.debugEndBtn.Size = new System.Drawing.Size(85, 42);
            this.debugEndBtn.TabIndex = 30;
            this.debugEndBtn.Text = "デバック終了";
            this.debugEndBtn.UseVisualStyleBackColor = true;
            this.debugEndBtn.Visible = false;
            this.debugEndBtn.Click += new System.EventHandler(this.debugEndBtn_Click);
            // 
            // cardOptionBox1
            // 
            this.cardOptionBox1.FormattingEnabled = true;
            this.cardOptionBox1.Items.AddRange(new object[] {
            "♥_1",
            "♥_2",
            "♥_3",
            "♥_4",
            "♥_5",
            "♥_6",
            "♥_7",
            "♥_8",
            "♥_9",
            "♥_10",
            "♥_11",
            "♥_12",
            "♥_13",
            "♠_1",
            "♠_2",
            "♠_3",
            "♠_4",
            "♠_5",
            "♠_6",
            "♠_7",
            "♠_8",
            "♠_9",
            "♠_10",
            "♠_11",
            "♠_12",
            "♠_13",
            "♣_1",
            "♣_2",
            "♣_3",
            "♣_4",
            "♣_5",
            "♣_6",
            "♣_7",
            "♣_8",
            "♣_9",
            "♣_10",
            "♣_11",
            "♣_12",
            "♣_13",
            "♦_1",
            "♦_2",
            "♦_3",
            "♦_4",
            "♦_5",
            "♦_6",
            "♦_7",
            "♦_8",
            "♦_9",
            "♦_10",
            "♦_11",
            "♦_12",
            "♦_13"});
            this.cardOptionBox1.Location = new System.Drawing.Point(15, 387);
            this.cardOptionBox1.Name = "cardOptionBox1";
            this.cardOptionBox1.Size = new System.Drawing.Size(105, 20);
            this.cardOptionBox1.TabIndex = 36;
            this.cardOptionBox1.Visible = false;
            // 
            // cardOptionBox2
            // 
            this.cardOptionBox2.FormattingEnabled = true;
            this.cardOptionBox2.Items.AddRange(new object[] {
            "♥_1",
            "♥_2",
            "♥_3",
            "♥_4",
            "♥_5",
            "♥_6",
            "♥_7",
            "♥_8",
            "♥_9",
            "♥_10",
            "♥_11",
            "♥_12",
            "♥_13",
            "♠_1",
            "♠_2",
            "♠_3",
            "♠_4",
            "♠_5",
            "♠_6",
            "♠_7",
            "♠_8",
            "♠_9",
            "♠_10",
            "♠_11",
            "♠_12",
            "♠_13",
            "♣_1",
            "♣_2",
            "♣_3",
            "♣_4",
            "♣_5",
            "♣_6",
            "♣_7",
            "♣_8",
            "♣_9",
            "♣_10",
            "♣_11",
            "♣_12",
            "♣_13",
            "♦_1",
            "♦_2",
            "♦_3",
            "♦_4",
            "♦_5",
            "♦_6",
            "♦_7",
            "♦_8",
            "♦_9",
            "♦_10",
            "♦_11",
            "♦_12",
            "♦_13"});
            this.cardOptionBox2.Location = new System.Drawing.Point(126, 387);
            this.cardOptionBox2.Name = "cardOptionBox2";
            this.cardOptionBox2.Size = new System.Drawing.Size(105, 20);
            this.cardOptionBox2.TabIndex = 37;
            this.cardOptionBox2.Visible = false;
            // 
            // cardOptionBox3
            // 
            this.cardOptionBox3.FormattingEnabled = true;
            this.cardOptionBox3.Items.AddRange(new object[] {
            "♥_1",
            "♥_2",
            "♥_3",
            "♥_4",
            "♥_5",
            "♥_6",
            "♥_7",
            "♥_8",
            "♥_9",
            "♥_10",
            "♥_11",
            "♥_12",
            "♥_13",
            "♠_1",
            "♠_2",
            "♠_3",
            "♠_4",
            "♠_5",
            "♠_6",
            "♠_7",
            "♠_8",
            "♠_9",
            "♠_10",
            "♠_11",
            "♠_12",
            "♠_13",
            "♣_1",
            "♣_2",
            "♣_3",
            "♣_4",
            "♣_5",
            "♣_6",
            "♣_7",
            "♣_8",
            "♣_9",
            "♣_10",
            "♣_11",
            "♣_12",
            "♣_13",
            "♦_1",
            "♦_2",
            "♦_3",
            "♦_4",
            "♦_5",
            "♦_6",
            "♦_7",
            "♦_8",
            "♦_9",
            "♦_10",
            "♦_11",
            "♦_12",
            "♦_13"});
            this.cardOptionBox3.Location = new System.Drawing.Point(237, 387);
            this.cardOptionBox3.Name = "cardOptionBox3";
            this.cardOptionBox3.Size = new System.Drawing.Size(105, 20);
            this.cardOptionBox3.TabIndex = 38;
            this.cardOptionBox3.Visible = false;
            // 
            // cardOptionBox4
            // 
            this.cardOptionBox4.FormattingEnabled = true;
            this.cardOptionBox4.Items.AddRange(new object[] {
            "♥_1",
            "♥_2",
            "♥_3",
            "♥_4",
            "♥_5",
            "♥_6",
            "♥_7",
            "♥_8",
            "♥_9",
            "♥_10",
            "♥_11",
            "♥_12",
            "♥_13",
            "♠_1",
            "♠_2",
            "♠_3",
            "♠_4",
            "♠_5",
            "♠_6",
            "♠_7",
            "♠_8",
            "♠_9",
            "♠_10",
            "♠_11",
            "♠_12",
            "♠_13",
            "♣_1",
            "♣_2",
            "♣_3",
            "♣_4",
            "♣_5",
            "♣_6",
            "♣_7",
            "♣_8",
            "♣_9",
            "♣_10",
            "♣_11",
            "♣_12",
            "♣_13",
            "♦_1",
            "♦_2",
            "♦_3",
            "♦_4",
            "♦_5",
            "♦_6",
            "♦_7",
            "♦_8",
            "♦_9",
            "♦_10",
            "♦_11",
            "♦_12",
            "♦_13"});
            this.cardOptionBox4.Location = new System.Drawing.Point(349, 387);
            this.cardOptionBox4.Name = "cardOptionBox4";
            this.cardOptionBox4.Size = new System.Drawing.Size(105, 20);
            this.cardOptionBox4.TabIndex = 39;
            this.cardOptionBox4.Visible = false;
            // 
            // cardOptionBox5
            // 
            this.cardOptionBox5.FormattingEnabled = true;
            this.cardOptionBox5.Items.AddRange(new object[] {
            "♥_1",
            "♥_2",
            "♥_3",
            "♥_4",
            "♥_5",
            "♥_6",
            "♥_7",
            "♥_8",
            "♥_9",
            "♥_10",
            "♥_11",
            "♥_12",
            "♥_13",
            "♠_1",
            "♠_2",
            "♠_3",
            "♠_4",
            "♠_5",
            "♠_6",
            "♠_7",
            "♠_8",
            "♠_9",
            "♠_10",
            "♠_11",
            "♠_12",
            "♠_13",
            "♣_1",
            "♣_2",
            "♣_3",
            "♣_4",
            "♣_5",
            "♣_6",
            "♣_7",
            "♣_8",
            "♣_9",
            "♣_10",
            "♣_11",
            "♣_12",
            "♣_13",
            "♦_1",
            "♦_2",
            "♦_3",
            "♦_4",
            "♦_5",
            "♦_6",
            "♦_7",
            "♦_8",
            "♦_9",
            "♦_10",
            "♦_11",
            "♦_12",
            "♦_13"});
            this.cardOptionBox5.Location = new System.Drawing.Point(460, 387);
            this.cardOptionBox5.Name = "cardOptionBox5";
            this.cardOptionBox5.Size = new System.Drawing.Size(105, 20);
            this.cardOptionBox5.TabIndex = 40;
            this.cardOptionBox5.Visible = false;
            // 
            // remCountNum
            // 
            this.remCountNum.AutoSize = true;
            this.remCountNum.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.remCountNum.Location = new System.Drawing.Point(607, 376);
            this.remCountNum.Name = "remCountNum";
            this.remCountNum.Size = new System.Drawing.Size(19, 20);
            this.remCountNum.TabIndex = 41;
            this.remCountNum.Text = "3";
            // 
            // Poker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(670, 411);
            this.Controls.Add(this.remCountNum);
            this.Controls.Add(this.cardOptionBox5);
            this.Controls.Add(this.cardOptionBox4);
            this.Controls.Add(this.cardOptionBox3);
            this.Controls.Add(this.cardOptionBox2);
            this.Controls.Add(this.cardOptionBox1);
            this.Controls.Add(this.debugEndBtn);
            this.Controls.Add(this.debugStartBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.allSelectBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.handListBtn);
            this.Controls.Add(this.inOutBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Poker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "POKER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox inOutBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button handListBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button allSelectBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button debugStartBtn;
        private System.Windows.Forms.Button debugEndBtn;
        private System.Windows.Forms.ComboBox cardOptionBox1;
        private System.Windows.Forms.ComboBox cardOptionBox2;
        private System.Windows.Forms.ComboBox cardOptionBox3;
        private System.Windows.Forms.ComboBox cardOptionBox4;
        private System.Windows.Forms.ComboBox cardOptionBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card5;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Label remCountNum;
    }
}

