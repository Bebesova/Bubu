namespace repair
{
    partial class NewProblem
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
            this.Ldevice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CBprior = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTProblem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ldevice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CBprior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RTProblem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задача для заявки №";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Ldevice
            // 
            this.Ldevice.AutoSize = true;
            this.Ldevice.Location = new System.Drawing.Point(65, 45);
            this.Ldevice.Name = "Ldevice";
            this.Ldevice.Size = new System.Drawing.Size(128, 24);
            this.Ldevice.TabIndex = 34;
            this.Ldevice.Text = "Устройство -";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "Сохранить задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBprior
            // 
            this.CBprior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBprior.FormattingEnabled = true;
            this.CBprior.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBprior.Location = new System.Drawing.Point(25, 228);
            this.CBprior.Name = "CBprior";
            this.CBprior.Size = new System.Drawing.Size(244, 28);
            this.CBprior.TabIndex = 32;
            this.CBprior.Text = "Выбирите";
            this.CBprior.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Приоритет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 2;
            // 
            // RTProblem
            // 
            this.RTProblem.Location = new System.Drawing.Point(25, 122);
            this.RTProblem.Name = "RTProblem";
            this.RTProblem.Size = new System.Drawing.Size(244, 45);
            this.RTProblem.TabIndex = 1;
            this.RTProblem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проблема";
            // 
            // NewProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 441);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewProblem";
            this.Text = "NewProblem";
            this.Load += new System.EventHandler(this.NewProblem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBprior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ldevice;
    }
}