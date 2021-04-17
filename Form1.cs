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
            GetSQLLogin();
            //SqlConnection.InitializeDatabase();

        }

        public void UpdateAssetView()
        {
            recordViewBox.Text = Asset.tagNum.ToString().PadLeft(6, '0');
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
                openTicketList.Items.Add(t.ToString().PadLeft(6, '0'));
            }
        }

        private void UpdateTicketView()
        {
            tickAssetBox.Text = Ticket.asset.ToString().PadLeft(6,'0');
            tickClientEmailBox.Text = Ticket.email;
            tickClientNameBox.Text = Ticket.name;
            tickClientPhone.Text = Ticket.phone;
            tickDateCreated.Value = Ticket.createdDate;
            tickDisc.Text = Ticket.desc;
            tickNotes.Text = Ticket.notes;
            tickPriority.SelectedItem = Ticket.prioriy;

            SetTicketState(Ticket.ticketNum, Ticket.state);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection.UpdateAsset(Asset.tagNum, nodeBox.Text, oSBox.Text, hardDriveBox.Text, ramBox.Text, processorBox.Text, localtionBox.Text, installationDate.Value, replacementDate.Value, auditDate.Value);

        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection.DeleteAsset(Asset.tagNum);
            Asset.Clear();
            UpdateAssetView();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Asset.Clear();
            SqlConnection.NewAsset();
            UpdateAssetView();
        }

        private void tickSave_Click(object sender, EventArgs e)
        {
            int.TryParse(tickAssetBox.Text, out int assetTag);

            SqlConnection.UpdateTicket(Ticket.ticketNum, tickPriority.SelectedIndex, 0, assetTag, tickClientNameBox.Text, tickClientPhone.Text, tickClientEmailBox.Text, tickDisc.Text, tickNotes.Text);
        }

        private void newTicket_Click(object sender, EventArgs e)
        {
            Ticket.Clear();
            SqlConnection.NewTicket();
            UpdateTicketView();
        }

        private void tickClose_Click(object sender, EventArgs e)
        {
            SqlConnection.UpdateTicket(Ticket.ticketNum, tickPriority.SelectedIndex, 1, Asset.tagNum, tickClientNameBox.Text, tickClientPhone.Text, tickClientEmailBox.Text, tickDisc.Text, tickNotes.Text);
            UpdateTicketView();
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

            ticketGroupBox.Text = tickNum.ToString().PadLeft(6, '0') + " | " + stateText;
        }
        private void searchButton_Click(object sender, EventArgs e) //Asset Search
        {
            int.TryParse(searchBox.Text, out int assetNum);

            if (assetNum != 0)
            {

                if (SqlConnection.GetAsset(assetNum))
                {
                    UpdateAssetView();
                }
                else
                {
                    recordViewBox.Text = "Error: Not Found";
                }
            }
            else 
            {
                recordViewBox.Text = "Error: Invalid";
            }

        }

        private void tickSearchBut_Click(object sender, EventArgs e) //Search button for tickets updates ticket veiw with entered ticket if found.
        {  
            int.TryParse(tickSearchBox.Text, out int tickNum);

            if (tickNum != 0)
            {
                if (SqlConnection.GetTicket(tickNum))
                {
                    UpdateTicketView();
                }
                else
                {
                    Ticket.Clear();
                    UpdateTicketView();
                    ticketGroupBox.Text = "Error: No ticket found";
                }
            }
            else 
            {
                Ticket.Clear();
                UpdateTicketView();
                ticketGroupBox.Text = "Error: Invalid input";
            }
        }

        private void GetSQLLogin()
        {
            Login loginDialog = new Login();
            bool loggedIN = false;

            while (!loggedIN)
            {
                if (loginDialog.ShowDialog(this) == DialogResult.OK)
                {
                    //string user = Login.username;
                    //string pass = Login.password;

                    string user = "CMBD";
                    string pass = "password";

                    if (SqlConnection.AttemptSQLConnection(user, pass))
                    {
                        loginDialog.Dispose();
                        loggedIN = true;
                    }
                }
                else
                {
                    loginDialog.Dispose();
                    loggedIN = true; //Ensure loop is broken. probs unnessesary 
                }
            }
            
        } //Login screen at begining of program

        private void replaceSearchBut_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();

            foreach (string result in SqlConnection.GetReplacementList())
            {
                searchResults.Items.Add(result);
            }
        }

        private void auditBut_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();

            foreach (string result in SqlConnection.GetAuditList())
            {
                searchResults.Items.Add(result);
            }

        }
    }
}
