namespace MedicalComponents.Editings
{
    partial class EditingDragMetal
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDragMetal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 33;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 32;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Инвентарный номер модели";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(238, 88);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(244, 21);
            this.comboBoxModel.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Вид драгоценного металла";
            // 
            // comboBoxDragMetal
            // 
            this.comboBoxDragMetal.FormattingEnabled = true;
            this.comboBoxDragMetal.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxDragMetal.Location = new System.Drawing.Point(238, 45);
            this.comboBoxDragMetal.Name = "comboBoxDragMetal";
            this.comboBoxDragMetal.Size = new System.Drawing.Size(244, 21);
            this.comboBoxDragMetal.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "вес (гр)";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(238, 132);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(244, 20);
            this.textBoxSize.TabIndex = 26;
            // 
            // EditingDragMetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 263);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDragMetal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSize);
            this.Name = "EditingDragMetal";
            this.Text = "EditingDragMetal";
            this.Load += new System.EventHandler(this.EditingDragMetal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDragMetal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSize;
    }
}