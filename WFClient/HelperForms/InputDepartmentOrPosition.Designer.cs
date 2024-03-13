namespace WFClient.HelperForms
{
    partial class InputDepartmentOrPosition
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
            tb_Name = new TextBox();
            label1 = new Label();
            btn_Ok = new Button();
            SuspendLayout();
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(205, 12);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(100, 23);
            tb_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 1;
            label1.Text = "Название отдела или должности";
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(124, 63);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 2;
            btn_Ok.Text = "Создать";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // InputDepartmentOrPosition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 98);
            Controls.Add(btn_Ok);
            Controls.Add(label1);
            Controls.Add(tb_Name);
            Name = "InputDepartmentOrPosition";
            Text = "InputDepartmentOrPosition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Name;
        private Label label1;
        private Button btn_Ok;
    }
}