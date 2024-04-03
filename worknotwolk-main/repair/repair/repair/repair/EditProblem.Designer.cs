namespace repair
{
    partial class EditProblem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LDivace = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBComment = new System.Windows.Forms.RichTextBox();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.Dend = new System.Windows.Forms.DateTimePicker();
            this.Dstart = new System.Windows.Forms.DateTimePicker();
            this.RTBDist = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LDivace);
            this.groupBox1.Controls.Add(this.BSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RTBComment);
            this.groupBox1.Controls.Add(this.CBPriority);
            this.groupBox1.Controls.Add(this.CBStatus);
            this.groupBox1.Controls.Add(this.Dend);
            this.groupBox1.Controls.Add(this.Dstart);
            this.groupBox1.Controls.Add(this.RTBDist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 640);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование проблемы";
            // 
            // LDivace
            // 
            this.LDivace.AutoSize = true;
            this.LDivace.Location = new System.Drawing.Point(18, 37);
            this.LDivace.Name = "LDivace";
            this.LDivace.Size = new System.Drawing.Size(127, 24);
            this.LDivace.TabIndex = 40;
            this.LDivace.Text = "Устройство: ";
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(23, 575);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(207, 36);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Сохранить ";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Коментарий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Приоритет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Дата окончания работ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дата начала работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Проблема:";
            // 
            // RTBComment
            // 
            this.RTBComment.Location = new System.Drawing.Point(18, 487);
            this.RTBComment.Name = "RTBComment";
            this.RTBComment.Size = new System.Drawing.Size(218, 71);
            this.RTBComment.TabIndex = 32;
            this.RTBComment.Text = "";
            // 
            // CBPriority
            // 
            this.CBPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Items.AddRange(new object[] {
            "В порядке очереди",
            "Срочно"});
            this.CBPriority.Location = new System.Drawing.Point(19, 421);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(211, 28);
            this.CBPriority.TabIndex = 31;
            // 
            // CBStatus
            // 
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBStatus.Location = new System.Drawing.Point(19, 353);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(211, 28);
            this.CBStatus.TabIndex = 30;
            // 
            // Dend
            // 
            this.Dend.Location = new System.Drawing.Point(18, 283);
            this.Dend.Name = "Dend";
            this.Dend.Size = new System.Drawing.Size(212, 29);
            this.Dend.TabIndex = 2;
            // 
            // Dstart
            // 
            this.Dstart.Location = new System.Drawing.Point(18, 212);
            this.Dstart.Name = "Dstart";
            this.Dstart.Size = new System.Drawing.Size(212, 29);
            this.Dstart.TabIndex = 1;
            // 
            // RTBDist
            // 
            this.RTBDist.Location = new System.Drawing.Point(18, 97);
            this.RTBDist.Name = "RTBDist";
            this.RTBDist.Size = new System.Drawing.Size(218, 85);
            this.RTBDist.TabIndex = 0;
            this.RTBDist.Text = "";
            // 
            // EditProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 664);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditProblem";
            this.Text = "EditProblem";
            this.Load += new System.EventHandler(this.EditProblem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBComment;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.DateTimePicker Dend;
        private System.Windows.Forms.DateTimePicker Dstart;
        private System.Windows.Forms.RichTextBox RTBDist;
        private System.Windows.Forms.Label LDivace;
    }
}