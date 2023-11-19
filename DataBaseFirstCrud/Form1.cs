using DataBaseFirstCrud.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataBaseFirstCrud
{
    public partial class Form1 : Form
    {
        int index, index1;
        int id = 10248;
        NorthwindContext db;

        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();

            foreach (var item in db.Employees)
            {
                lstEmployee.Items.Add(item.FirstName + " " + item.LastName);
            }

            foreach (var item in db.Shippers)
            {
                lstShippers.Items.Add(item.CompanyName);
            }

        }

        #region GetOrderList
        private void btnGetOrderList_Click(object sender, EventArgs e)
        {

            int employeeId = 0;
            int shipperId = 0;
            if (lstEmployee.SelectedItem != null)
            {
                string employeeName = lstEmployee.SelectedItem.ToString();
                Employee selectedEmployee = db.Employees.FirstOrDefault(e => (e.FirstName + " " + e.LastName) == employeeName);

                if (selectedEmployee != null)
                {

                    employeeId = selectedEmployee.EmployeeId;

                }
            }
            if (lstShippers.SelectedItem != null)
            {
                string shipperName = lstShippers.SelectedItem.ToString();
                Shipper selectedShipper = db.Shippers.FirstOrDefault(s => s.CompanyName == shipperName);

                if (selectedShipper != null)
                {
                    shipperId = selectedShipper.ShipperId;
                }
            }
            else
            {
                dgwData.DataSource = db.Orders.ToList();
            }

            var seciliSiparisler = db.Orders.Where(order => (employeeId == 0 || order.EmployeeId == employeeId) && (shipperId == 0 || order.ShipVia == shipperId)).ToList();

            dgwData.DataSource = seciliSiparisler;
        }

        #endregion

        #region EkraniDoldur()
        private void EkraniDoldur()
        {

            try
            {
                string connectionString = "Data Source=B\\SQLSERVER;Initial Catalog=Northwind;Integrated Security=True";

                string query = "SELECT o.orderID, o.orderDate, o.shipCity FROM Orders o";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    DataTable db = new DataTable();

                    dataAdapter.Fill(db);

                    dgwData.DataSource = db;
                }
                dgwData.Columns["OrderId"].Visible = false;
                dgwData.Columns["Custom"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region MauseDown
        private void lstEmployees_MauseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            index = lstEmployee.IndexFromPoint(pt);

            if (index <= -1)
            {
                lstEmployee.SelectedItems.Clear();
            }
        }

        private void lstShippers_MauseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            index1 = lstShippers.IndexFromPoint(pt);

            if (index1 <= -1)
            {
                lstShippers.SelectedItems.Clear();
            }
        }
        #endregion

        #region Add Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        #endregion

        #region Update Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(selectedId);
            form2.ShowDialog();
        }
        #endregion

        #region id
        private void dgwData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = (int)dgwData[0, index].Value;
        }
        #endregion

        #region Delete Click

        int selectedId;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwData.SelectedRows.Count > 0)
            {
                Order orderDelete = db.Orders.FirstOrDefault(o => o.OrderId == selectedId);

                if (orderDelete != null)
                {

                    db.Orders.Remove(orderDelete);
                    db.SaveChanges();
                    MessageBox.Show("Sipariþ baþarýyla silindi.");

                }
                else
                {
                    MessageBox.Show("Sipariþ bulunamadý.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariþ seçin.");
            }
        }
        #endregion

        private void dgwData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            selectedId = (int)dgwData[0, index].Value;
        }
    }
}
