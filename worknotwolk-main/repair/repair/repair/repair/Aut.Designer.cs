namespace repair
{
    partial class Аuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBcaptcha = new System.Windows.Forms.RichTextBox();
            this.PBcaptcha = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerbl = new System.Windows.Forms.Timer(this.components);
            this.BAut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBcaptcha)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(247, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = " ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RTBcaptcha
            // 
            this.RTBcaptcha.Location = new System.Drawing.Point(115, 283);
            this.RTBcaptcha.Name = "RTBcaptcha";
            this.RTBcaptcha.Size = new System.Drawing.Size(90, 40);
            this.RTBcaptcha.TabIndex = 23;
            this.RTBcaptcha.Text = "";
            // 
            // PBcaptcha
            // 
            this.PBcaptcha.Location = new System.Drawing.Point(105, 167);
            this.PBcaptcha.Name = "PBcaptcha";
            this.PBcaptcha.Size = new System.Drawing.Size(110, 99);
            this.PBcaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBcaptcha.TabIndex = 22;
            this.PBcaptcha.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(72, 54);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(177, 32);
            this.Login.TabIndex = 16;
            this.Login.Text = "nastya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(40, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ввод станет доступен через:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(72, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(177, 32);
            this.Password.TabIndex = 17;
            this.Password.Text = "1610";
            this.Password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "ООО \"Техносервис\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RTBcaptcha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PBcaptcha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 376);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // BAut
            // 
            this.BAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BAut.Location = new System.Drawing.Point(127, 449);
            this.BAut.Name = "BAut";
            this.BAut.Size = new System.Drawing.Size(100, 34);
            this.BAut.TabIndex = 28;
            this.BAut.Text = "Войти";
            this.BAut.UseVisualStyleBackColor = true;
            this.BAut.Click += new System.EventHandler(this.BAut_Click);
            // 
            // Аuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(349, 513);
            this.Controls.Add(this.BAut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Аuth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Аuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBcaptcha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBcaptcha;
        private System.Windows.Forms.PictureBox PBcaptcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerbl;
        private System.Windows.Forms.Button BAut;
        private System.Windows.Forms.Label label6;
    }
}

