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
            dt_DayBirth = new DateTimePicker();
            cb_Depatments = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cb_Position = new ComboBox();
            btn_Ok = new Button();
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
            // dt_DayBirth
            // 
            dt_DayBirth.Location = new Point(12, 203);
            dt_DayBirth.Name = "dt_DayBirth";
            dt_DayBirth.Size = new Size(200, 23);
            dt_DayBirth.TabIndex = 11;
            // 
            // cb_Depatments
            // 
            cb_Depatments.FormattingEnabled = true;
            cb_Depatments.Location = new Point(12, 247);
            cb_Depatments.Name = "cb_Depatments";
            cb_Depatments.Size = new Size(121, 23);
            cb_Depatments.TabIndex = 12;
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
            // cb_Position
            // 
            cb_Position.FormattingEnabled = true;
            cb_Position.Location = new Point(12, 291);
            cb_Position.Name = "cb_Position";
            cb_Position.Size = new Size(121, 23);
            cb_Position.TabIndex = 14;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(69, 390);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 16;
            btn_Ok.Text = "Создать";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // InputEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 450);
            Controls.Add(btn_Ok);
            Controls.Add(label7);
            Controls.Add(cb_Position);
            Controls.Add(label6);
            Controls.Add(cb_Depatments);
            Controls.Add(dt_DayBirth);
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
        private DateTimePicker dt_DayBirth;
        private ComboBox cb_Depatments;
        private Label label6;
        private Label label7;
        private ComboBox cb_Position;
        private Button btn_Ok;
    }
}