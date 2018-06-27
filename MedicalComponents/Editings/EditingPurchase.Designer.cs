namespace MedicalComponents.Editings
{
    partial class EditingPurchase
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
            this.comboBoxPurchaseType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOrg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPurchaseType
            // 
            this.comboBoxPurchaseType.FormattingEnabled = true;
            this.comboBoxPurchaseType.Location = new System.Drawing.Point(170, 130);
            this.comboBoxPurchaseType.Name = "comboBoxPurchaseType";
            this.comboBoxPurchaseType.Size = new System.Drawing.Size(215, 21);
            this.comboBoxPurchaseType.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Тип закупки";
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(170, 87);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxDocNumber.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Номер договора";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(170, 43);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerCreated.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Дата подписания";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 35;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 34;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOrg
            // 
            this.comboBoxOrg.FormattingEnabled = true;
            this.comboBoxOrg.Location = new System.Drawing.Point(170, 182);
            this.comboBoxOrg.Name = "comboBoxOrg";
            this.comboBoxOrg.Size = new System.Drawing.Size(215, 21);
            this.comboBoxOrg.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Наименование организации";
            // 
            // EditingPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 286);
            this.Controls.Add(this.comboBoxOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPurchaseType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDocNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.label2);
            this.Name = "EditingPurchase";
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.EditingPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPurchaseType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDocNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxOrg;
        private System.Windows.Forms.Label label1;
    }
}