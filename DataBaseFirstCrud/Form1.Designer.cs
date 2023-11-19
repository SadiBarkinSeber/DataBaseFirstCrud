namespace DataBaseFirstCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwData = new DataGridView();
            btnGetOrderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lstEmployee = new ListBox();
            lstShippers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgwData).BeginInit();
            SuspendLayout();
            // 
            // dgwData
            // 
            dgwData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwData.BackgroundColor = Color.WhiteSmoke;
            dgwData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwData.Location = new Point(257, 111);
            dgwData.Name = "dgwData";
            dgwData.RowTemplate.Height = 25;
            dgwData.Size = new Size(1017, 625);
            dgwData.TabIndex = 0;
            dgwData.CellClick += dgwData_CellDoubleClick;
            dgwData.CellMouseClick += dgwData_CellMouseClick;
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.BackColor = Color.WhiteSmoke;
            btnGetOrderList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetOrderList.Location = new Point(12, 29);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(221, 60);
            btnGetOrderList.TabIndex = 1;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = false;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(359, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(221, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(706, 29);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(221, 60);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleRole = AccessibleRole.None;
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(1053, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(221, 60);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstEmployee
            // 
            lstEmployee.BackColor = Color.WhiteSmoke;
            lstEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lstEmployee.FormattingEnabled = true;
            lstEmployee.ItemHeight = 17;
            lstEmployee.Location = new Point(12, 111);
            lstEmployee.Name = "lstEmployee";
            lstEmployee.Size = new Size(215, 293);
            lstEmployee.TabIndex = 5;
            lstEmployee.MouseDown += lstEmployees_MauseDown;
            // 
            // lstShippers
            // 
            lstShippers.BackColor = Color.WhiteSmoke;
            lstShippers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lstShippers.FormattingEnabled = true;
            lstShippers.ItemHeight = 17;
            lstShippers.Location = new Point(12, 433);
            lstShippers.Name = "lstShippers";
            lstShippers.Size = new Size(215, 293);
            lstShippers.TabIndex = 6;
            lstShippers.MouseDown += lstShippers_MauseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1299, 765);
            Controls.Add(lstShippers);
            Controls.Add(lstEmployee);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Controls.Add(dgwData);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DB First CRUD";
            ((System.ComponentModel.ISupportInitialize)dgwData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwData;
        private Button btnGetOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox lstEmployee;
        private ListBox lstShippers;
    }
}
