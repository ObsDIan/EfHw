using EFHW.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EFHW
{
    public partial class AddFrom : Form
    {
        public AddFrom()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()
            {
                ID = textBox1.Text,
                Name = textBox2.Text,
                Count = textBox3.Text,
                Price = textBox4.Text,
                Type = textBox5.Text
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.ContactsTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearText();   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex}");
            }

            var content = new ContactsModel();
            var list = content.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }
        private void ClearText()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

    }
}
