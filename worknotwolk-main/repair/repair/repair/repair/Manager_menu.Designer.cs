namespace repair
{
    partial class Manager_menu
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
            this.employeesDG = new System.Windows.Forms.DataGridView();
            this.CBfilterStatus = new System.Windows.Forms.ComboBox();
            this.BEdit = new System.Windows.Forms.Button();
            this.BNewExecutor = new System.Windows.Forms.Button();
            this.BEditStatus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.DGProblem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDG
            // 
            this.employeesDG.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.employeesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDG.Location = new System.Drawing.Point(12, 80);
            this.employeesDG.Name = "employeesDG";
            this.employeesDG.Size = new System.Drawing.Size(641, 236);
            this.employeesDG.TabIndex = 1;
            this.employeesDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDG_CellContentClick);
            this.employeesDG.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDG_CellEnter);
            // 
            // CBfilterStatus
            // 
            this.CBfilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBfilterStatus.FormattingEnabled = true;
            this.CBfilterStatus.Items.AddRange(new object[] {
            "Не обработан",
            "В работе",
            "Выполнен"});
            this.CBfilterStatus.Location = new System.Drawing.Point(12, 46);
            this.CBfilterStatus.Name = "CBfilterStatus";
            this.CBfilterStatus.Size = new System.Drawing.Size(178, 28);
            this.CBfilterStatus.TabIndex = 2;
            this.CBfilterStatus.Text = "Статус выполнения";
            this.CBfilterStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BEdit
            // 
            this.BEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BEdit.Location = new System.Drawing.Point(12, 322);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(150, 54);
            this.BEdit.TabIndex = 5;
            this.BEdit.Text = "Редактировать заявку";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BNewExecutor
            // 
            this.BNewExecutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BNewExecutor.Location = new System.Drawing.Point(328, 322);
            this.BNewExecutor.Name = "BNewExecutor";
            this.BNewExecutor.Size = new System.Drawing.Size(176, 54);
            this.BNewExecutor.TabIndex = 6;
            this.BNewExecutor.Text = "Добавить задачу";
            this.BNewExecutor.UseVisualStyleBackColor = true;
            this.BNewExecutor.Click += new System.EventHandler(this.button2_Click);
            // 
            // BEditStatus
            // 
            this.BEditStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BEditStatus.Location = new System.Drawing.Point(384, 44);
            this.BEditStatus.Name = "BEditStatus";
            this.BEditStatus.Size = new System.Drawing.Size(161, 31);
            this.BEditStatus.TabIndex = 8;
            this.BEditStatus.Text = "Изменить статус";
            this.BEditStatus.UseVisualStyleBackColor = true;
            this.BEditStatus.Click += new System.EventHandler(this.BEditStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(125, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "ООО \"Техносервис\"";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Exit.Location = new System.Drawing.Point(12, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 27);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CBStatus
            // 
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBStatus.Location = new System.Drawing.Point(246, 46);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(132, 28);
            this.CBStatus.TabIndex = 29;
            this.CBStatus.Text = "Выбирите";
            // 
            // DGProblem
            // 
            this.DGProblem.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProblem.Location = new System.Drawing.Point(12, 382);
            this.DGProblem.Name = "DGProblem";
            this.DGProblem.Size = new System.Drawing.Size(641, 236);
            this.DGProblem.TabIndex = 30;
            this.DGProblem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(168, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 54);
            this.button1.TabIndex = 31;
            this.button1.Text = "Редактировать задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(510, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 32;
            this.button2.Text = "Добавить исполнителя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(551, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "файл excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Manager_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 627);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGProblem);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BEditStatus);
            this.Controls.Add(this.BNewExecutor);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.CBfilterStatus);
            this.Controls.Add(this.employeesDG);
            this.Name = "Manager_menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Manager_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDG;
        private System.Windows.Forms.ComboBox CBfilterStatus;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BNewExecutor;
        private System.Windows.Forms.Button BEditStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.DataGridView DGProblem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}