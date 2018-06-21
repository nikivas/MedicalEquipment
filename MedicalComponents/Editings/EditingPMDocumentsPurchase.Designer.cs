namespace MedicalComponents.Editings
{
    partial class EditingPMDocumentsPurchase
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dateTimePickerFactical = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerPlanned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModelElement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 52;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 51;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Количество";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(193, 63);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(300, 20);
            this.textBoxCount.TabIndex = 49;
            // 
            // dateTimePickerFactical
            // 
            this.dateTimePickerFactical.Location = new System.Drawing.Point(193, 174);
            this.dateTimePickerFactical.Name = "dateTimePickerFactical";
            this.dateTimePickerFactical.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerFactical.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Дата фактической поставки";
            // 
            // dateTimePickerPlanned
            // 
            this.dateTimePickerPlanned.Location = new System.Drawing.Point(193, 117);
            this.dateTimePickerPlanned.Name = "dateTimePickerPlanned";
            this.dateTimePickerPlanned.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerPlanned.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Дата планируемой поставки";
            // 
            // comboBoxModelElement
            // 
            this.comboBoxModelElement.FormattingEnabled = true;
            this.comboBoxModelElement.Location = new System.Drawing.Point(193, 20);
            this.comboBoxModelElement.Name = "comboBoxModelElement";
            this.comboBoxModelElement.Size = new System.Drawing.Size(300, 21);
            this.comboBoxModelElement.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "РМ";
            // 
            // EditingPMDocumentsPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.dateTimePickerFactical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerPlanned);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxModelElement);
            this.Controls.Add(this.label2);
            this.Name = "EditingPMDocumentsPurchase";
            this.Text = "EditingPMDocumentsPurchase";
            this.Load += new System.EventHandler(this.EditingPMDocumentsPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerFactical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlanned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModelElement;
        private System.Windows.Forms.Label label2;
    }
}