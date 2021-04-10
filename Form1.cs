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

            installationDate.Value = Asset.installDate;
            replacementDate.Value = Asset.upgradeDate;
            auditDate.Value = Asset.auditDate;

            hardDriveBox.Text = Asset.hardDrive;
            ramBox.Text = Asset.ram;
            oSBox.Text = Asset.os;
            processorBox.Text = Asset.processor;

            SqlConnection.GetOpenTicketNums(); //Get list of open tickets assosiated with tag.
            openTicketList.Items.Clear();
            foreach (int t in Asset.openTickets)
            {
                openTicketList.Items.Add(t);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int assetTag = 0;

            if (int.TryParse(assetTagBox.Text, out assetTag))
            {
                SqlConnection.UpdateAsset(assetTag, nodeBox.Text, oSBox.Text, hardDriveBox.Text, ramBox.Text, processorBox.Text, localtionBox.Text, installationDate.Value, replacementDate.Value, auditDate.Value);
                Asset.node = nodeBox.Text;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchBox.TextLength != 0)
            {
                SqlConnection.GetAsset(Int32.Parse(searchBox.Text));
                UpdateAssetView();
                
            }

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
            SqlConnection.UpdateTicket(Ticket.ticketNum, tickPriority.SelectedIndex, 0, Asset.tagNum, tickClientNameBox.Text, tickClientPhone.Text, tickClientEmailBox.Text, tickDisc.Text, tickNotes.Text);
        }

        private void newTicket_Click(object sender, EventArgs e)
        {
            SqlConnection.NewTicket(tickPriority.SelectedIndex, 0, Asset.tagNum, tickClientNameBox.Text, tickClientPhone.Text, tickClientEmailBox.Text, tickDisc.Text, tickNotes.Text);
        }

        private void tickClose_Click(object sender, EventArgs e)
        {

        }

        private void SetTicketState(int tickNum, int state)
        {
            string stateText = "";

            switch (state) //Get names for each state, only 2 supported (0,1)
            {
                case 0:
                    stateText = "Open";
                    break;
                case 1:
                    stateText = "Closed";
                    break;
                case 2:
                    stateText = "Pending";
                    break;
            }

            ticketGroupBox.Text = tickNum + " | " + stateText;
        }
    }
}
