namespace MedicalComponents.Editings
{
    partial class EditingPersonalOnService
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxServiceOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModelElement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Тип сервисной операции";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxServiceOperation
            // 
            this.comboBoxServiceOperation.FormattingEnabled = true;
            this.comboBoxServiceOperation.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxServiceOperation.Location = new System.Drawing.Point(194, 143);
            this.comboBoxServiceOperation.Name = "comboBoxServiceOperation";
            this.comboBoxServiceOperation.Size = new System.Drawing.Size(244, 21);
            this.comboBoxServiceOperation.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Инвентарынй номер модели";
            // 
            // comboBoxModelElement
            // 
            this.comboBoxModelElement.FormattingEnabled = true;
            this.comboBoxModelElement.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxModelElement.Location = new System.Drawing.Point(194, 91);
            this.comboBoxModelElement.Name = "comboBoxModelElement";
            this.comboBoxModelElement.Size = new System.Drawing.Size(244, 21);
            this.comboBoxModelElement.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "ФИО";
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxFIO.Location = new System.Drawing.Point(194, 41);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(244, 21);
            this.comboBoxFIO.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Тип обслуживания";
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxServiceType.Location = new System.Drawing.Point(194, 187);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(244, 21);
            this.comboBoxServiceType.TabIndex = 34;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBoxRole.Location = new System.Drawing.Point(194, 237);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(244, 21);
            this.comboBoxRole.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Роль Сервисного обслуживания";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 21);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 38;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditingPersonalOnService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 344);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxServiceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxServiceOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxModelElement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFIO);
            this.Name = "EditingPersonalOnService";
            this.Text = "изменение данных";
            this.Load += new System.EventHandler(this.EditingPersonalOnService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxServiceOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModelElement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxServiceType;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}