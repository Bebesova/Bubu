namespace repair
{
    partial class NewExecutor
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
            this.DGExecutor = new System.Windows.Forms.DataGridView();
            this.BAddEx = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGExecutor
            // 
            this.DGExecutor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGExecutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGExecutor.Location = new System.Drawing.Point(12, 46);
            this.DGExecutor.Name = "DGExecutor";
            this.DGExecutor.Size = new System.Drawing.Size(321, 100);
            this.DGExecutor.TabIndex = 0;
            this.DGExecutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGExecutor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGExecutor_CellEnter);
            // 
            // BAddEx
            // 
            this.BAddEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BAddEx.Location = new System.Drawing.Point(120, 152);
            this.BAddEx.Name = "BAddEx";
            this.BAddEx.Size = new System.Drawing.Size(107, 35);
            this.BAddEx.TabIndex = 1;
            this.BAddEx.Text = "Добавить";
            this.BAddEx.UseVisualStyleBackColor = true;
            this.BAddEx.Click += new System.EventHandler(this.BAddEx_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "ООО \"Техносервис\"";
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BExit.Location = new System.Drawing.Point(226, 5);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(107, 35);
            this.BExit.TabIndex = 29;
            this.BExit.Text = "назад";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // NewExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BAddEx);
            this.Controls.Add(this.DGExecutor);
            this.Name = "NewExecutor";
            this.Text = "Исполнители";
            this.Load += new System.EventHandler(this.NewExecutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGExecutor;
        private System.Windows.Forms.Button BAddEx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BExit;
    }
}