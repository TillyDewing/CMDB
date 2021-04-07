
namespace CMDB
{
    partial class CMBD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.recordViewBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openTicketList = new System.Windows.Forms.ListBox();
            this.oSBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ramBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hardDriveBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.processorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.localtionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assetTagBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.auditDate = new System.Windows.Forms.DateTimePicker();
            this.replacementDate = new System.Windows.Forms.DateTimePicker();
            this.installationDate = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.replaceSearchBut = new System.Windows.Forms.Button();
            this.auditBut = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.ticketGroupBox = new System.Windows.Forms.GroupBox();
            this.tickClose = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tickNotes = new System.Windows.Forms.RichTextBox();
            this.tickDisc = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tickPriority = new System.Windows.Forms.ComboBox();
            this.tickStartDate = new System.Windows.Forms.Label();
            this.tickDateCreated = new System.Windows.Forms.DateTimePicker();
            this.tickClientPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tickClientEmailBox = new System.Windows.Forms.TextBox();
            this.tickClientNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.newTicket = new System.Windows.Forms.Button();
            this.tickSave = new System.Windows.Forms.Button();
            this.recordViewBox.SuspendLayout();
            this.ticketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1072, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "asset tag #";
            this.searchBox.Size = new System.Drawing.Size(213, 23);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1291, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // recordViewBox
            // 
            this.recordViewBox.Controls.Add(this.label11);
            this.recordViewBox.Controls.Add(this.openTicketList);
            this.recordViewBox.Controls.Add(this.oSBox);
            this.recordViewBox.Controls.Add(this.label10);
            this.recordViewBox.Controls.Add(this.ramBox);
            this.recordViewBox.Controls.Add(this.label9);
            this.recordViewBox.Controls.Add(this.hardDriveBox);
            this.recordViewBox.Controls.Add(this.label8);
            this.recordViewBox.Controls.Add(this.label7);
            this.recordViewBox.Controls.Add(this.processorBox);
            this.recordViewBox.Controls.Add(this.label6);
            this.recordViewBox.Controls.Add(this.localtionBox);
            this.recordViewBox.Controls.Add(this.label5);
            this.recordViewBox.Controls.Add(this.assetTagBox);
            this.recordViewBox.Controls.Add(this.label4);
            this.recordViewBox.Controls.Add(this.label3);
            this.recordViewBox.Controls.Add(this.label2);
            this.recordViewBox.Controls.Add(this.label1);
            this.recordViewBox.Controls.Add(this.auditDate);
            this.recordViewBox.Controls.Add(this.replacementDate);
            this.recordViewBox.Controls.Add(this.installationDate);
            this.recordViewBox.Location = new System.Drawing.Point(11, 41);
            this.recordViewBox.Name = "recordViewBox";
            this.recordViewBox.Size = new System.Drawing.Size(1042, 169);
            this.recordViewBox.TabIndex = 3;
            this.recordViewBox.TabStop = false;
            this.recordViewBox.Text = "Asset View";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(860, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Open Incidents:";
            // 
            // openTicketList
            // 
            this.openTicketList.FormattingEnabled = true;
            this.openTicketList.ItemHeight = 15;
            this.openTicketList.Location = new System.Drawing.Point(782, 34);
            this.openTicketList.Name = "openTicketList";
            this.openTicketList.Size = new System.Drawing.Size(243, 124);
            this.openTicketList.TabIndex = 19;
            // 
            // oSBox
            // 
            this.oSBox.Location = new System.Drawing.Point(648, 113);
            this.oSBox.Name = "oSBox";
            this.oSBox.Size = new System.Drawing.Size(118, 23);
            this.oSBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "O.S. :";
            // 
            // ramBox
            // 
            this.ramBox.Location = new System.Drawing.Point(473, 113);
            this.ramBox.Name = "ramBox";
            this.ramBox.Size = new System.Drawing.Size(124, 23);
            this.ramBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ram:";
            // 
            // hardDriveBox
            // 
            this.hardDriveBox.Location = new System.Drawing.Point(289, 113);
            this.hardDriveBox.Name = "hardDriveBox";
            this.hardDriveBox.Size = new System.Drawing.Size(124, 23);
            this.hardDriveBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hard Drive:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Specifications";
            // 
            // processorBox
            // 
            this.processorBox.Location = new System.Drawing.Point(82, 113);
            this.processorBox.Name = "processorBox";
            this.processorBox.Size = new System.Drawing.Size(124, 23);
            this.processorBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Processor:";
            // 
            // localtionBox
            // 
            this.localtionBox.Location = new System.Drawing.Point(82, 50);
            this.localtionBox.Name = "localtionBox";
            this.localtionBox.Size = new System.Drawing.Size(124, 23);
            this.localtionBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Location";
            // 
            // assetTagBox
            // 
            this.assetTagBox.Location = new System.Drawing.Point(82, 23);
            this.assetTagBox.Name = "assetTagBox";
            this.assetTagBox.Size = new System.Drawing.Size(124, 23);
            this.assetTagBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asset Tag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Audit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Replacement Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Installation Date:";
            // 
            // auditDate
            // 
            this.auditDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.auditDate.Location = new System.Drawing.Point(554, 23);
            this.auditDate.Name = "auditDate";
            this.auditDate.Size = new System.Drawing.Size(123, 23);
            this.auditDate.TabIndex = 2;
            // 
            // replacementDate
            // 
            this.replacementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.replacementDate.Location = new System.Drawing.Point(346, 52);
            this.replacementDate.Name = "replacementDate";
            this.replacementDate.Size = new System.Drawing.Size(123, 23);
            this.replacementDate.TabIndex = 1;
            // 
            // installationDate
            // 
            this.installationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.installationDate.Location = new System.Drawing.Point(346, 23);
            this.installationDate.Name = "installationDate";
            this.installationDate.Size = new System.Drawing.Size(123, 23);
            this.installationDate.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.Location = new System.Drawing.Point(13, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(34, 24);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "💾";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // replaceSearchBut
            // 
            this.replaceSearchBut.Location = new System.Drawing.Point(1072, 41);
            this.replaceSearchBut.Name = "replaceSearchBut";
            this.replaceSearchBut.Size = new System.Drawing.Size(128, 23);
            this.replaceSearchBut.TabIndex = 5;
            this.replaceSearchBut.Text = "Replacements";
            this.replaceSearchBut.UseVisualStyleBackColor = true;
            // 
            // auditBut
            // 
            this.auditBut.Location = new System.Drawing.Point(1206, 41);
            this.auditBut.Name = "auditBut";
            this.auditBut.Size = new System.Drawing.Size(117, 23);
            this.auditBut.TabIndex = 6;
            this.auditBut.Text = "Audit";
            this.auditBut.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Location = new System.Drawing.Point(53, 11);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 24);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "🗑";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.newButton.Location = new System.Drawing.Point(93, 11);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(34, 24);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "➕";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1072, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 124);
            this.listBox1.TabIndex = 20;
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 15;
            this.searchResults.Location = new System.Drawing.Point(1072, 75);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(251, 619);
            this.searchResults.TabIndex = 9;
            // 
            // ticketGroupBox
            // 
            this.ticketGroupBox.Controls.Add(this.tickClose);
            this.ticketGroupBox.Controls.Add(this.label17);
            this.ticketGroupBox.Controls.Add(this.label16);
            this.ticketGroupBox.Controls.Add(this.tickNotes);
            this.ticketGroupBox.Controls.Add(this.tickDisc);
            this.ticketGroupBox.Controls.Add(this.label15);
            this.ticketGroupBox.Controls.Add(this.tickPriority);
            this.ticketGroupBox.Controls.Add(this.tickStartDate);
            this.ticketGroupBox.Controls.Add(this.tickDateCreated);
            this.ticketGroupBox.Controls.Add(this.tickClientPhone);
            this.ticketGroupBox.Controls.Add(this.label14);
            this.ticketGroupBox.Controls.Add(this.tickClientEmailBox);
            this.ticketGroupBox.Controls.Add(this.tickClientNameBox);
            this.ticketGroupBox.Controls.Add(this.label12);
            this.ticketGroupBox.Controls.Add(this.label13);
            this.ticketGroupBox.Location = new System.Drawing.Point(16, 246);
            this.ticketGroupBox.Name = "ticketGroupBox";
            this.ticketGroupBox.Size = new System.Drawing.Size(1041, 452);
            this.ticketGroupBox.TabIndex = 10;
            this.ticketGroupBox.TabStop = false;
            this.ticketGroupBox.Text = "ticketnum";
            // 
            // tickClose
            // 
            this.tickClose.Location = new System.Drawing.Point(933, 412);
            this.tickClose.Name = "tickClose";
            this.tickClose.Size = new System.Drawing.Size(87, 23);
            this.tickClose.TabIndex = 36;
            this.tickClose.Text = "Close Ticket";
            this.tickClose.UseVisualStyleBackColor = true;
            this.tickClose.Click += new System.EventHandler(this.tickClose_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(569, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tech Notes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Discription:";
            // 
            // tickNotes
            // 
            this.tickNotes.Location = new System.Drawing.Point(569, 119);
            this.tickNotes.Name = "tickNotes";
            this.tickNotes.Size = new System.Drawing.Size(450, 287);
            this.tickNotes.TabIndex = 33;
            this.tickNotes.Text = "";
            // 
            // tickDisc
            // 
            this.tickDisc.Location = new System.Drawing.Point(13, 119);
            this.tickDisc.Name = "tickDisc";
            this.tickDisc.Size = new System.Drawing.Size(530, 287);
            this.tickDisc.TabIndex = 32;
            this.tickDisc.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(912, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "Priority:";
            // 
            // tickPriority
            // 
            this.tickPriority.FormattingEnabled = true;
            this.tickPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tickPriority.Location = new System.Drawing.Point(966, 48);
            this.tickPriority.Name = "tickPriority";
            this.tickPriority.Size = new System.Drawing.Size(54, 23);
            this.tickPriority.TabIndex = 30;
            // 
            // tickStartDate
            // 
            this.tickStartDate.AutoSize = true;
            this.tickStartDate.Location = new System.Drawing.Point(833, 22);
            this.tickStartDate.Name = "tickStartDate";
            this.tickStartDate.Size = new System.Drawing.Size(78, 15);
            this.tickStartDate.TabIndex = 29;
            this.tickStartDate.Text = "Created Date:";
            // 
            // tickDateCreated
            // 
            this.tickDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tickDateCreated.Location = new System.Drawing.Point(917, 17);
            this.tickDateCreated.Name = "tickDateCreated";
            this.tickDateCreated.Size = new System.Drawing.Size(103, 23);
            this.tickDateCreated.TabIndex = 27;
            // 
            // tickClientPhone
            // 
            this.tickClientPhone.Location = new System.Drawing.Point(377, 22);
            this.tickClientPhone.Name = "tickClientPhone";
            this.tickClientPhone.Size = new System.Drawing.Size(181, 23);
            this.tickClientPhone.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Client Phone:";
            // 
            // tickClientEmailBox
            // 
            this.tickClientEmailBox.Location = new System.Drawing.Point(97, 54);
            this.tickClientEmailBox.Name = "tickClientEmailBox";
            this.tickClientEmailBox.Size = new System.Drawing.Size(298, 23);
            this.tickClientEmailBox.TabIndex = 24;
            // 
            // tickClientNameBox
            // 
            this.tickClientNameBox.Location = new System.Drawing.Point(97, 22);
            this.tickClientNameBox.Name = "tickClientNameBox";
            this.tickClientNameBox.Size = new System.Drawing.Size(181, 23);
            this.tickClientNameBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Client Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Client Name:";
            // 
            // newTicket
            // 
            this.newTicket.ForeColor = System.Drawing.Color.LimeGreen;
            this.newTicket.Location = new System.Drawing.Point(56, 216);
            this.newTicket.Name = "newTicket";
            this.newTicket.Size = new System.Drawing.Size(34, 24);
            this.newTicket.TabIndex = 12;
            this.newTicket.Text = "➕";
            this.newTicket.UseVisualStyleBackColor = true;
            this.newTicket.Click += new System.EventHandler(this.newTicket_Click);
            // 
            // tickSave
            // 
            this.tickSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tickSave.Location = new System.Drawing.Point(16, 216);
            this.tickSave.Name = "tickSave";
            this.tickSave.Size = new System.Drawing.Size(34, 24);
            this.tickSave.TabIndex = 11;
            this.tickSave.Text = "💾";
            this.tickSave.UseVisualStyleBackColor = true;
            this.tickSave.Click += new System.EventHandler(this.tickSave_Click);
            // 
            // CMBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.newTicket);
            this.Controls.Add(this.ticketGroupBox);
            this.Controls.Add(this.tickSave);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.auditBut);
            this.Controls.Add(this.replaceSearchBut);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.recordViewBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Name = "CMBD";
            this.Text = "CMBD";
            this.recordViewBox.ResumeLayout(false);
            this.recordViewBox.PerformLayout();
            this.ticketGroupBox.ResumeLayout(false);
            this.ticketGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox recordViewBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button replaceSearchBut;
        private System.Windows.Forms.Button auditBut;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker replacementDate;
        private System.Windows.Forms.DateTimePicker installationDate;
        private System.Windows.Forms.TextBox localtionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox assetTagBox;
        private System.Windows.Forms.DateTimePicker auditDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox processor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oSBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox openTicketList;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.GroupBox ticketGroupBox;
        private System.Windows.Forms.Button newTicket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tickClientEmailBox;
        private System.Windows.Forms.TextBox tickClientNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tickStartDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox T;
        private System.Windows.Forms.RichTextBox Tick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oS;
        private System.Windows.Forms.TextBox ramBox;
        private System.Windows.Forms.TextBox hardDriveBox;
        private System.Windows.Forms.TextBox processorBox;
        private System.Windows.Forms.ComboBox tickPriority;
        private System.Windows.Forms.DateTimePicker tickDateCreated;
        private System.Windows.Forms.TextBox tickClientPhone;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button tickClose;
        private System.Windows.Forms.RichTextBox tickNotes;
        private System.Windows.Forms.RichTextBox tickDisc;
        private System.Windows.Forms.Button tickSave;
    }
}

