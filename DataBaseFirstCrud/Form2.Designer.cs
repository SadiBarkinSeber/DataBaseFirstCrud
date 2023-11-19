namespace DataBaseFirstCrud
{
    partial class Form2
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
            cbEmployees = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            txtShipCity = new TextBox();
            cbShippers = new ComboBox();
            btnProcess = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbEmployees
            // 
            cbEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(123, 26);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(255, 29);
            cbEmployees.TabIndex = 0;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpOrderDate.Location = new Point(123, 85);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(255, 29);
            dtpOrderDate.TabIndex = 1;
            // 
            // txtShipCity
            // 
            txtShipCity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtShipCity.Location = new Point(123, 144);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(255, 29);
            txtShipCity.TabIndex = 2;
            // 
            // cbShippers
            // 
            cbShippers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbShippers.FormattingEnabled = true;
            cbShippers.Location = new Point(123, 203);
            cbShippers.Name = "cbShippers";
            cbShippers.Size = new Size(255, 29);
            cbShippers.TabIndex = 3;
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcess.Location = new Point(123, 268);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(193, 41);
            btnProcess.TabIndex = 4;
            btnProcess.Text = "Add";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 5;
            label1.Text = "Employee :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 6;
            label2.Text = "Order Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 147);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 6;
            label3.Text = "Ship City :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 206);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Shipper :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(441, 343);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProcess);
            Controls.Add(cbShippers);
            Controls.Add(txtShipCity);
            Controls.Add(dtpOrderDate);
            Controls.Add(cbEmployees);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEmployees;
        private DateTimePicker dtpOrderDate;
        private TextBox txtShipCity;
        private ComboBox cbShippers;
        private Button btnProcess;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}