namespace BebeReviews
{
    partial class Menu_admn
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
            this.DGtitle = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGtitle)).BeginInit();
            this.SuspendLayout();
            // 
            // DGtitle
            // 
            this.DGtitle.BackgroundColor = System.Drawing.Color.White;
            this.DGtitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGtitle.Location = new System.Drawing.Point(25, 68);
            this.DGtitle.Name = "DGtitle";
            this.DGtitle.Size = new System.Drawing.Size(455, 383);
            this.DGtitle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button1.Location = new System.Drawing.Point(496, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить произведение";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button2.Location = new System.Drawing.Point(496, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить жанр";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button3.Location = new System.Drawing.Point(496, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 94);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить категорию";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Menu_admn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGtitle);
            this.Name = "Menu_admn";
            this.Text = "Menu_admn";
            this.Load += new System.EventHandler(this.Menu_admn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGtitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGtitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}