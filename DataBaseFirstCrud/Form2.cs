using DataBaseFirstCrud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseFirstCrud
{
    public partial class Form2 : Form
    {
        NorthwindContext db;
        private int id;

        public Form2()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }

        public Form2(int id)
        {
            InitializeComponent();
            db = new NorthwindContext();
            btnProcess.Text = "Update";
            this.id = id;
            DatalariDoldur();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Employee> employees = db.Employees.ToList();
            List<Shipper> shippers = db.Shippers.ToList();
            foreach (Employee emp in employees)
            {
                cbEmployees.Items.Add(emp.FirstName);
            }
            foreach (Shipper shp in shippers)
            {
                cbShippers.Items.Add(shp.CompanyName);
            }
        }

        private void DatalariDoldur()
        {
            Order order = db.Orders.FirstOrDefault(x => x.OrderId == id);
            Employee employee = db.Employees.FirstOrDefault(x => x.EmployeeId == order.EmployeeId);
            Shipper shipper = db.Shippers.FirstOrDefault(x => x.ShipperId == order.ShipVia);

            cbEmployees.Text = employee.FirstName;
            dtpOrderDate.Value = (DateTime)order.OrderDate;
            txtShipCity.Text = order.ShipCity;
            cbShippers.Text = shipper.CompanyName;
        }


        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (btnProcess.Text == "Add")
            {
                Order order = new Order();
                Employee employee = db.Employees.FirstOrDefault(x => x.FirstName == cbEmployees.Text);
                Shipper shipper = db.Shippers.FirstOrDefault(x => x.CompanyName == cbShippers.Text);

                order.EmployeeId = employee.EmployeeId;
                order.ShipVia = shipper.ShipperId;

                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtShipCity.Text;

                db.Orders.Add(order);
                MessageBox.Show("Eklendi");

                db.SaveChanges();
                this.Close();
            }

            if (btnProcess.Text == "Update")
            {
                Order orderToUpdate = db.Orders.FirstOrDefault(x => x.OrderId == id);
                if (orderToUpdate != null)
                {
                    Employee employee = db.Employees.FirstOrDefault(x => x.FirstName == cbEmployees.Text);
                    Shipper shipper = db.Shippers.FirstOrDefault(x => x.CompanyName == cbShippers.Text);

                    orderToUpdate.EmployeeId = employee.EmployeeId;
                    orderToUpdate.ShipVia = shipper.ShipperId;
                    orderToUpdate.OrderDate = dtpOrderDate.Value;
                    orderToUpdate.ShipCity = txtShipCity.Text;

                    MessageBox.Show("Güncellendi");

                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncellenecek sipariş bulunamadı.");
                }
            }
        }

    }
}
