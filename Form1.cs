using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDB
{
    public partial class CMBD : Form
    {
        public CMBD()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection.InitializeDatabase();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void tickSave_Click(object sender, EventArgs e)
        {

        }

        private void newTicket_Click(object sender, EventArgs e)
        {

        }

        private void tickClose_Click(object sender, EventArgs e)
        {

        }
    }
}
