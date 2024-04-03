namespace repair
{
    partial class EditOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBprior = new System.Windows.Forms.ComboBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.Dend = new System.Windows.Forms.DateTimePicker();
            this.DStart = new System.Windows.Forms.DateTimePicker();
            this.TbDist = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBprior);
            this.groupBox1.Controls.Add(this.CBStatus);
            this.groupBox1.Controls.Add(this.Dend);
            this.groupBox1.Controls.Add(this.DStart);
            this.groupBox1.Controls.Add(this.TbDist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заявка №";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Приоритет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Дата окончания работ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дата начала работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Описание проблема:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Устройство:";
            // 
            // CBprior
            // 
            this.CBprior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBprior.FormattingEnabled = true;
            this.CBprior.Items.AddRange(new object[] {
            "срочно",
            "нет"});
            this.CBprior.Location = new System.Drawing.Point(25, 422);
            this.CBprior.Name = "CBprior";
            this.CBprior.Size = new System.Drawing.Size(211, 28);
            this.CBprior.TabIndex = 31;
            // 
            // CBStatus
            // 
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBStatus.Location = new System.Drawing.Point(25, 354);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(211, 28);
            this.CBStatus.TabIndex = 30;
            // 
            // Dend
            // 
            this.Dend.Location = new System.Drawing.Point(24, 284);
            this.Dend.Name = "Dend";
            this.Dend.Size = new System.Drawing.Size(212, 29);
            this.Dend.TabIndex = 2;
            // 
            // DStart
            // 
            this.DStart.Location = new System.Drawing.Point(24, 213);
            this.DStart.Name = "DStart";
            this.DStart.Size = new System.Drawing.Size(212, 29);
            this.DStart.TabIndex = 1;
            // 
            // TbDist
            // 
            this.TbDist.Location = new System.Drawing.Point(24, 98);
            this.TbDist.Name = "TbDist";
            this.TbDist.Size = new System.Drawing.Size(218, 85);
            this.TbDist.TabIndex = 0;
            this.TbDist.Text = "";
            this.TbDist.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dend;
        private System.Windows.Forms.DateTimePicker DStart;
        private System.Windows.Forms.RichTextBox TbDist;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBprior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}