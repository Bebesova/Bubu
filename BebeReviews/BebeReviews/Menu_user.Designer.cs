namespace BebeReviews
{
    partial class Menu_user
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
            this.components = new System.ComponentModel.Container();
            this.DGTitle = new System.Windows.Forms.DataGridView();
            this.DGRev = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.RichTextBox();
            this.numrat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.GBrev = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HelloUser = new System.Windows.Forms.Label();
            this.RtbRew = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterAuther = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filtername = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrat)).BeginInit();
            this.GBrev.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGTitle
            // 
            this.DGTitle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTitle.Location = new System.Drawing.Point(23, 173);
            this.DGTitle.Name = "DGTitle";
            this.DGTitle.Size = new System.Drawing.Size(429, 330);
            this.DGTitle.TabIndex = 0;
            this.DGTitle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTitle_CellEnter);
            // 
            // DGRev
            // 
            this.DGRev.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRev.Location = new System.Drawing.Point(469, 173);
            this.DGRev.Name = "DGRev";
            this.DGRev.Size = new System.Drawing.Size(354, 330);
            this.DGRev.TabIndex = 2;
            this.DGRev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGRev.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRev_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Произведения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(464, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Все отзывы";
            // 
            // Review
            // 
            this.Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Review.Location = new System.Drawing.Point(6, 78);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(402, 68);
            this.Review.TabIndex = 5;
            this.Review.Text = "";
            // 
            // numrat
            // 
            this.numrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.numrat.Location = new System.Drawing.Point(6, 31);
            this.numrat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numrat.Name = "numrat";
            this.numrat.Size = new System.Drawing.Size(52, 32);
            this.numrat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(64, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "- Оценка";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butSave.Location = new System.Drawing.Point(6, 152);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(402, 35);
            this.butSave.TabIndex = 8;
            this.butSave.Text = "Cохранить отзыв";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // GBrev
            // 
            this.GBrev.Controls.Add(this.numrat);
            this.GBrev.Controls.Add(this.butSave);
            this.GBrev.Controls.Add(this.Review);
            this.GBrev.Controls.Add(this.label3);
            this.GBrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.GBrev.Location = new System.Drawing.Point(23, 519);
            this.GBrev.Name = "GBrev";
            this.GBrev.Size = new System.Drawing.Size(429, 202);
            this.GBrev.TabIndex = 9;
            this.GBrev.TabStop = false;
            this.GBrev.Text = "отзыв";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HelloUser
            // 
            this.HelloUser.AutoSize = true;
            this.HelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.HelloUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelloUser.Location = new System.Drawing.Point(19, 9);
            this.HelloUser.Name = "HelloUser";
            this.HelloUser.Size = new System.Drawing.Size(160, 20);
            this.HelloUser.TabIndex = 11;
            this.HelloUser.Text = "С возвращением, ";
            // 
            // RtbRew
            // 
            this.RtbRew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.RtbRew.Location = new System.Drawing.Point(469, 550);
            this.RtbRew.Name = "RtbRew";
            this.RtbRew.Size = new System.Drawing.Size(354, 156);
            this.RtbRew.TabIndex = 12;
            this.RtbRew.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(464, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отзыв";
            // 
            // filterAuther
            // 
            this.filterAuther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.filterAuther.Location = new System.Drawing.Point(297, 108);
            this.filterAuther.Name = "filterAuther";
            this.filterAuther.Size = new System.Drawing.Size(155, 32);
            this.filterAuther.TabIndex = 14;
            this.filterAuther.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(217, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(130, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Произведения";
            // 
            // filtername
            // 
            this.filtername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.filtername.Location = new System.Drawing.Point(297, 67);
            this.filtername.Name = "filtername";
            this.filtername.Size = new System.Drawing.Size(155, 32);
            this.filtername.TabIndex = 16;
            this.filtername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comboBox1.Location = new System.Drawing.Point(659, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 34);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(564, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Оценка";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 737);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filtername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterAuther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RtbRew);
            this.Controls.Add(this.HelloUser);
            this.Controls.Add(this.GBrev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGRev);
            this.Controls.Add(this.DGTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Menu_user";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrat)).EndInit();
            this.GBrev.ResumeLayout(false);
            this.GBrev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTitle;
        private System.Windows.Forms.DataGridView DGRev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Review;
        private System.Windows.Forms.NumericUpDown numrat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.GroupBox GBrev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label HelloUser;
        private System.Windows.Forms.RichTextBox RtbRew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filterAuther;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filtername;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}