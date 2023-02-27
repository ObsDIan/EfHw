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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFHW
{
    public partial class SearchFrom : Form
    {
        public SearchFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel context = new ContactsModel();
            dataGridView1.DataSource = context.ContactsTable.Where((x) =>
            x.ID == textBox1.Text ||
            x.Count == textBox1.Text ||
            x.Type == textBox1.Text ||
            x.Price == textBox1.Text ||
            x.Name == textBox1.Text).ToList();
        }
    }
}
