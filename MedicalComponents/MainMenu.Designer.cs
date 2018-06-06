namespace MedicalComponents
{
    partial class MainMenu
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
            this.buttonTableEditing = new System.Windows.Forms.Button();
            this.buttonHelpTableEditing = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonPurchasePlan = new System.Windows.Forms.Button();
            this.buttonSPPRAdministration = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSPPRInformation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTableEditing
            // 
            this.buttonTableEditing.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTableEditing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTableEditing.Location = new System.Drawing.Point(12, 342);
            this.buttonTableEditing.Name = "buttonTableEditing";
            this.buttonTableEditing.Size = new System.Drawing.Size(223, 88);
            this.buttonTableEditing.TabIndex = 0;
            this.buttonTableEditing.Text = "Просмотр и корректировка основных таблиц";
            this.buttonTableEditing.UseVisualStyleBackColor = false;
            this.buttonTableEditing.Click += new System.EventHandler(this.buttonTableEditing_Click);
            // 
            // buttonHelpTableEditing
            // 
            this.buttonHelpTableEditing.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpTableEditing.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelpTableEditing.Location = new System.Drawing.Point(12, 248);
            this.buttonHelpTableEditing.Name = "buttonHelpTableEditing";
            this.buttonHelpTableEditing.Size = new System.Drawing.Size(223, 88);
            this.buttonHelpTableEditing.TabIndex = 1;
            this.buttonHelpTableEditing.Text = "Просмотр и корректировка таблиц-справочников";
            this.buttonHelpTableEditing.UseVisualStyleBackColor = false;
            this.buttonHelpTableEditing.Click += new System.EventHandler(this.buttonHelpTableEditing_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReports.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReports.Location = new System.Drawing.Point(12, 436);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(223, 88);
            this.buttonReports.TabIndex = 2;
            this.buttonReports.Text = "Запросы и отчеты";
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonPurchasePlan
            // 
            this.buttonPurchasePlan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPurchasePlan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPurchasePlan.Location = new System.Drawing.Point(414, 436);
            this.buttonPurchasePlan.Name = "buttonPurchasePlan";
            this.buttonPurchasePlan.Size = new System.Drawing.Size(223, 88);
            this.buttonPurchasePlan.TabIndex = 3;
            this.buttonPurchasePlan.Text = "Планы закупок медицинского оборудования, ЗИП и расходных матералов";
            this.buttonPurchasePlan.UseVisualStyleBackColor = false;
            this.buttonPurchasePlan.Click += new System.EventHandler(this.buttonPurchasePlan_Click);
            // 
            // buttonSPPRAdministration
            // 
            this.buttonSPPRAdministration.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSPPRAdministration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSPPRAdministration.Location = new System.Drawing.Point(414, 248);
            this.buttonSPPRAdministration.Name = "buttonSPPRAdministration";
            this.buttonSPPRAdministration.Size = new System.Drawing.Size(223, 88);
            this.buttonSPPRAdministration.TabIndex = 4;
            this.buttonSPPRAdministration.Text = "Графическое представление результатов прогнозирования";
            this.buttonSPPRAdministration.UseVisualStyleBackColor = false;
            this.buttonSPPRAdministration.Click += new System.EventHandler(this.buttonSPPRAdministration_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(414, 13);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(223, 36);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "О Программе";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // buttonSPPRInformation
            // 
            this.buttonSPPRInformation.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSPPRInformation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSPPRInformation.Location = new System.Drawing.Point(414, 342);
            this.buttonSPPRInformation.Name = "buttonSPPRInformation";
            this.buttonSPPRInformation.Size = new System.Drawing.Size(223, 88);
            this.buttonSPPRInformation.TabIndex = 6;
            this.buttonSPPRInformation.Text = "Оценка оснащенности отделений медоборудованием по отношению к стандартам";
            this.buttonSPPRInformation.UseVisualStyleBackColor = false;
            this.buttonSPPRInformation.Click += new System.EventHandler(this.buttonSPPRInformation_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Инструкции по заполнению системы";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 157);
            this.label1.TabIndex = 8;
            this.label1.Text = "Система интеллектуального управления парком медицинского оборудования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "© Copyright Pfander E.V.";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSPPRInformation);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonSPPRAdministration);
            this.Controls.Add(this.buttonPurchasePlan);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonHelpTableEditing);
            this.Controls.Add(this.buttonTableEditing);
            this.Name = "MainMenu";
            this.Text = "Главное Меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTableEditing;
        private System.Windows.Forms.Button buttonHelpTableEditing;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonPurchasePlan;
        private System.Windows.Forms.Button buttonSPPRAdministration;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSPPRInformation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

