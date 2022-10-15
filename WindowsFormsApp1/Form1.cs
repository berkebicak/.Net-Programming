using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customer> customers = new List<Customer>();
        List<Employee> employees = new List<Employee>();
        Customer customer = new Customer();

        private void Form1_Load(object sender, EventArgs e){}

        public void TxtBoxClear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(txtID.Text);
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Address = txtAddress.Text;

           
            employees.Add(employee);
            comboBox2.Items.Add(employee.Id);
            TxtBoxClear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IUser item in employees)
            {
                listBox1.Items.Add(item.FirstName+" "+item.LastName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(txtID.Text);
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Address = txtAddress.Text;

            customers.Add(customer);
            comboBox1.Items.Add(customer.Id);
            TxtBoxClear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IUser item in customers)
            {
                listBox1.Items.Add(item.FirstName+" "+item.LastName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customers.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            employees.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int text1 = (int)comboBox1.SelectedItem;
            listBox1.Items.Clear();
 
            for (int i = 0; i < customers.Count; i++)
            {
                if (text1 == customers[i].Id)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(customers[i].FirstName+" "+customers[i].LastName);                    
                }
                
            } 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int text1 = (int)comboBox1.SelectedItem;
            listBox1.Items.Clear();

            for (int i = 0; i < employees.Count; i++)
            {
                if (text1 == employees[i].Id)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(employees[i].FirstName+" "+employees[i].LastName);                   
                }
            }
        }
    }
}
