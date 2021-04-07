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
            SqlConnection.InitializeDatabase();

        }

        public void UpdateAssetView()
        {
            assetTagBox.Text = Asset.tagNum.ToString();
            localtionBox.Text = Asset.location;
            nodeBox.Text = Asset.node;

            //installationDate.Value = Asset.installDate;
            //replacementDate.Value = Asset.upgradeDate;
            //auditDate.Value = Asset.auditDate;

            hardDriveBox.Text = Asset.hardDrive;
            ramBox.Text = Asset.ram;
            oSBox.Text = Asset.os;
            processorBox.Text = Asset.processor;

            //GET OPEN TICKETS HERE
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection.GetAsset(Int32.Parse(searchBox.Text));
            UpdateAssetView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SqlConnection.NewAsset(nodeBox.Text, oSBox.Text, hardDriveBox.Text, ramBox.Text, processorBox.Text, localtionBox.Text, installationDate.Value, replacementDate.Value, auditDate.Value);
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
