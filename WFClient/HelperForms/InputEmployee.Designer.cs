namespace WFClient.HelperForms
{
    partial class InputEmployee
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
            tb_id = new TextBox();
            tb_Name = new TextBox();
            tb_LastName = new TextBox();
            tb_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // tb_id
            // 
            tb_id.Location = new Point(12, 27);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(200, 23);
            tb_id.TabIndex = 1;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(12, 71);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(200, 23);
            tb_Name.TabIndex = 2;
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(12, 115);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(200, 23);
            tb_LastName.TabIndex = 3;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(12, 159);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(200, 23);
            tb_Email.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 10;
            label5.Text = "День рождения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 13;
            label6.Text = "Отдел";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 273);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 15;
            label7.Text = "Должность";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 291);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            // 
            // InputEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Email);
            Controls.Add(tb_LastName);
            Controls.Add(tb_Name);
            Controls.Add(tb_id);
            Name = "InputEmployee";
            Text = "InputEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_id;
        private TextBox tb_Name;
        private TextBox tb_LastName;
        private TextBox tb_Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
    }
}