namespace MedicalComponents.Editings
{
    partial class EditingBrokenRequest
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPeople = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBroken = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerMoved = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(174, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Проблема решена";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(174, 87);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(300, 21);
            this.comboBoxModel.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Прикреплен к модели:";
            // 
            // comboBoxPeople
            // 
            this.comboBoxPeople.FormattingEnabled = true;
            this.comboBoxPeople.Location = new System.Drawing.Point(174, 32);
            this.comboBoxPeople.Name = "comboBoxPeople";
            this.comboBoxPeople.Size = new System.Drawing.Size(300, 21);
            this.comboBoxPeople.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Человек оставивший заявку";
            // 
            // comboBoxBroken
            // 
            this.comboBoxBroken.FormattingEnabled = true;
            this.comboBoxBroken.Location = new System.Drawing.Point(174, 140);
            this.comboBoxBroken.Name = "comboBoxBroken";
            this.comboBoxBroken.Size = new System.Drawing.Size(300, 21);
            this.comboBoxBroken.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Поломка";
            // 
            // dateTimePickerMoved
            // 
            this.dateTimePickerMoved.Location = new System.Drawing.Point(174, 188);
            this.dateTimePickerMoved.Name = "dateTimePickerMoved";
            this.dateTimePickerMoved.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerMoved.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Дата подачи";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 38;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditingBrokenRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerMoved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBroken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPeople);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Name = "EditingBrokenRequest";
            this.Load += new System.EventHandler(this.EditingBrokenRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPeople;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBroken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerMoved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}