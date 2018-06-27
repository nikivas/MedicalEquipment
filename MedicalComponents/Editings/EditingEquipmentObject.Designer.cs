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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePickerMO = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTO = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxSpisano = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxInventaryNumber
            // 
            this.textBoxInventaryNumber.Location = new System.Drawing.Point(185, 103);
            this.textBoxInventaryNumber.Name = "textBoxInventaryNumber";
            this.textBoxInventaryNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxInventaryNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата ввода в эксплуатацию";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Location = new System.Drawing.Point(185, 139);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerCreated.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип модели";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Серийный номер";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(573, 103);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxSerialNumber.TabIndex = 9;
            // 
            // dateTimePickerWriteOff
            // 
            this.dateTimePickerWriteOff.Enabled = false;
            this.dateTimePickerWriteOff.Location = new System.Drawing.Point(185, 224);
            this.dateTimePickerWriteOff.Name = "dateTimePickerWriteOff";
            this.dateTimePickerWriteOff.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerWriteOff.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата списания";
            // 
            // comboBoxWriteOffReason
            // 
            this.comboBoxWriteOffReason.Enabled = false;
            this.comboBoxWriteOffReason.FormattingEnabled = true;
            this.comboBoxWriteOffReason.Location = new System.Drawing.Point(185, 197);
            this.comboBoxWriteOffReason.Name = "comboBoxWriteOffReason";
            this.comboBoxWriteOffReason.Size = new System.Drawing.Size(215, 21);
            this.comboBoxWriteOffReason.TabIndex = 16;
            this.comboBoxWriteOffReason.Text = "Моральное устаревание";
            this.comboBoxWriteOffReason.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Причина списания";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxModelType
            // 
            this.comboBoxModelType.FormattingEnabled = true;
            this.comboBoxModelType.Location = new System.Drawing.Point(259, 20);
            this.comboBoxModelType.Name = "comboBoxModelType";
            this.comboBoxModelType.Size = new System.Drawing.Size(442, 21);
            this.comboBoxModelType.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(514, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Нуждается в метрологическом осмотре";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePickerMO
            // 
            this.dateTimePickerMO.Enabled = false;
            this.dateTimePickerMO.Location = new System.Drawing.Point(573, 200);
            this.dateTimePickerMO.Name = "dateTimePickerMO";
            this.dateTimePickerMO.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerMO.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата МО";
            // 
            // dateTimePickerTO
            // 
            this.dateTimePickerTO.Location = new System.Drawing.Point(573, 231);
            this.dateTimePickerTO.Name = "dateTimePickerTO";
            this.dateTimePickerTO.Size = new System.Drawing.Size(215, 20);
            this.dateTimePickerTO.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дата ТО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(259, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(442, 20);
            this.textBoxName.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Название единицы оборудования";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(573, 137);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(219, 21);
            this.comboBoxCountry.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Страна производитель";
            // 
            // checkBoxSpisano
            // 
            this.checkBoxSpisano.AutoSize = true;
            this.checkBoxSpisano.Location = new System.Drawing.Point(202, 174);
            this.checkBoxSpisano.Name = "checkBoxSpisano";
            this.checkBoxSpisano.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSpisano.TabIndex = 29;
            this.checkBoxSpisano.Text = "Списано";
            this.checkBoxSpisano.UseVisualStyleBackColor = true;
            this.checkBoxSpisano.CheckedChanged += new System.EventHandler(this.checkBoxSpisano_CheckedChanged);
            // 
            // EditingEquipmentObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.checkBoxSpisano);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerTO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerMO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerMO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxSpisano;
    }
}