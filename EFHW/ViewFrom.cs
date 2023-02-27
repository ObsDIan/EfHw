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
    public partial class ViewFrom : Form
    {
        public ViewFrom()
        {
            InitializeComponent();
            var content = new ContactsModel();
            var list = content.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }
    }
}
