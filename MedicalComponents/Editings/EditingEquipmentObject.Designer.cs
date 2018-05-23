namespace MedicalComponents.Editings
{
    partial class EditingEquipmentObject
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
            this.textBoxInventaryNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerWriteOff = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxWriteOffReason = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxModelType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxInventaryNumber
            // 
            this.textBoxInventaryNumber.Location = new System.Drawing.Point(148, 34);
            this.textBoxInventaryNumber.Name = "textBoxInventaryNumber";
            this.textBoxInventaryNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxInventaryNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата изготовления";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(148, 75);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerCreated.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Разновидность модели";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Серийный номер";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(148, 119);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxSerialNumber.TabIndex = 9;
            // 
            // dateTimePickerWriteOff
            // 
            this.dateTimePickerWriteOff.Location = new System.Drawing.Point(529, 78);
            this.dateTimePickerWriteOff.Name = "dateTimePickerWriteOff";
            this.dateTimePickerWriteOff.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerWriteOff.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата списания";
            // 
            // comboBoxWriteOffReason
            // 
            this.comboBoxWriteOffReason.FormattingEnabled = true;
            this.comboBoxWriteOffReason.Location = new System.Drawing.Point(148, 162);
            this.comboBoxWriteOffReason.Name = "comboBoxWriteOffReason";
            this.comboBoxWriteOffReason.Size = new System.Drawing.Size(215, 21);
            this.comboBoxWriteOffReason.TabIndex = 16;
            this.comboBoxWriteOffReason.Text = "Моральное устаревание";
            this.comboBoxWriteOffReason.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Причина списания";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxModelType
            // 
            this.comboBoxModelType.FormattingEnabled = true;
            this.comboBoxModelType.Location = new System.Drawing.Point(542, 34);
            this.comboBoxModelType.Name = "comboBoxModelType";
            this.comboBoxModelType.Size = new System.Drawing.Size(215, 21);
            this.comboBoxModelType.TabIndex = 19;
            this.comboBoxModelType.Text = "Моральное устаревание";
            // 
            // EditingEquipmentObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.comboBoxModelType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxWriteOffReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerWriteOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerCreated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInventaryNumber);
            this.Name = "EditingEquipmentObject";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditingEquipmentObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInventaryNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerWriteOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxWriteOffReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxModelType;
    }
}