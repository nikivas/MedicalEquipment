namespace MedicalComponents.Editings
{
    partial class EditingElementsPlaces
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
            this.dateTimePickerMoved = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMoveReason = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCorpus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelElement = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 50;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 49;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerMoved
            // 
            this.dateTimePickerMoved.Location = new System.Drawing.Point(179, 180);
            this.dateTimePickerMoved.Name = "dateTimePickerMoved";
            this.dateTimePickerMoved.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerMoved.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Дата";
            // 
            // comboBoxMoveReason
            // 
            this.comboBoxMoveReason.FormattingEnabled = true;
            this.comboBoxMoveReason.Location = new System.Drawing.Point(179, 132);
            this.comboBoxMoveReason.Name = "comboBoxMoveReason";
            this.comboBoxMoveReason.Size = new System.Drawing.Size(300, 21);
            this.comboBoxMoveReason.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Причина перемещения";
            // 
            // comboBoxCorpus
            // 
            this.comboBoxCorpus.FormattingEnabled = true;
            this.comboBoxCorpus.Location = new System.Drawing.Point(179, 79);
            this.comboBoxCorpus.Name = "comboBoxCorpus";
            this.comboBoxCorpus.Size = new System.Drawing.Size(300, 21);
            this.comboBoxCorpus.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Отделение";
            // 
            // comboBoxModelElement
            // 
            this.comboBoxModelElement.FormattingEnabled = true;
            this.comboBoxModelElement.Location = new System.Drawing.Point(179, 24);
            this.comboBoxModelElement.Name = "comboBoxModelElement";
            this.comboBoxModelElement.Size = new System.Drawing.Size(300, 21);
            this.comboBoxModelElement.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Модель";
            // 
            // EditingElementsPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerMoved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMoveReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCorpus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModelElement);
            this.Controls.Add(this.label8);
            this.Name = "EditingElementsPlaces";
            this.Text = "EditingElementsPlaces";
            this.Load += new System.EventHandler(this.EditingElementsPlaces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerMoved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMoveReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCorpus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModelElement;
        private System.Windows.Forms.Label label8;
    }
}