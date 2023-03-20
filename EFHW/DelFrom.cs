using EFHW.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFHW
{
    public partial class DelFrom : Form
    {
        public DelFrom()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ContactsModel model = new ContactsModel();
            var del = model.ContactsTable.First((x) => x.ID == textBox1.Text);
            model.ContactsTable.Remove(del);
            model.SaveChanges();
            MessageBox.Show("刪除成功");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFrom view = new ViewFrom();
            view.Show();
        }
    }
}
