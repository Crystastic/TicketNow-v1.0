using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace TicketNow_v1._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetLocationTxt();
            resetDetails();
            newsModule();
        }

//This method controls the news module, pulled from the text file created in the exe's file location.
        public void newsModule()
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            if (!File.Exists(currentDirectory + "\\TicketNowNews.txt"))
            {
                using (StreamWriter sw = File.CreateText(currentDirectory + "\\TicketNowNews.txt"))
                {
                    sw.WriteLine("Please contact IT, and ask for a");
                    sw.WriteLine("shortcut to TicketNow.");
                    sw.WriteLine(" -Chris Edwicker");
                }
            }
            else
            {
                System.IO.StreamReader newsFile = new System.IO.StreamReader(currentDirectory + "\\TicketNowNews.txt");
                string news = newsFile.ReadToEnd();
                newsFile.Close();
                lblUpdates.Text = (news);
            }
        }

//From here onwards is the section that defines which text/combo boxes are shown or hidden.

        /*
            Location Index List
        Store                   =   0
        Head Office             =   1
        DC                      =   2
        Other                   =   3
         * 
         */

        //Shows or hides additional information text box for locations.
        private void cmboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = cmboLocation.SelectedIndex;
            if ((si != 1))
            {
                txtLocation.Show();
            }
            else{
                resetLocationTxt();
            }
        }

        //Resets the location info textbox.
        public void resetLocationTxt()
        {
            txtLocation.Hide();
        }

        /*
                    Category Index List
        Account Maintenance     =   0
        Communication           =   1
        Hardware Fault          =   2
        Merret                  =   3
        Retail Java (Tills)     =   4
        Request                 =   5
        PoS/Store Systems       =   6
        Software Issue          =   7

         */
        //Shows or hides different details boxes depending on the selected index of the category combo box.
        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {//si = Selected Index of the category dropdown.       
            int si = cmboCategory.SelectedIndex;

            if ((si == 0) || (si == 3))
            {
                resetDetails();
                lblUsername.Text = "Username:";
                lblUsername.Show();
                txtDetailsL.Show();
            }
            else if ((si == 2) | (si == 7))
            {
                resetDetails();
                lblHardwareID.Text = "Hardware " + Environment.NewLine + "ID:";
                lblHardwareID.Show();
                txtDetailsS.Show();
                cmboDetails.Show();
            }
            else 
            {
                resetDetails();
            }
        }

        //Used to help the above.
        public void resetDetails()
        {
            lblHardwareID.Hide();
            lblUsername.Hide();
            txtDetailsL.Hide();
            cmboDetails.Hide();
            txtDetailsS.Hide();
        }


//From here onwards controls what actually happens when the submit button is clicked, sending the email.

        //Form validation
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Determine if the TextBox has a digit character.
            string text = txtUsername.Text;
            bool hasDigit = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (!hasDigit)
            {
                nameError.SetError(txtUsername, "Needs to contain a digit");
            }
            else
            {
                nameError.Clear();
            }
        }

        //Method fired when Submit button is clicked. Simply runs the following methods depending on which fields are visable.
        //To do: Seperate into another class file.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDetailsL.Visible)
            {
                detailsLHandler();
            }
            else if (cmboDetails.Visible)
            {
                detailsSHandler();
            }
            else
            {
                basicHandler();
            }
            
        }

        //Fires if the Long Textbox for details is visable.
        public void detailsLHandler()
        {

        }

        //Fires if the Details dropdown is visable.
        public void detailsSHandler()
        {
  
        }

        //Fires if neither of the above are visable.
        public void basicHandler()
        {

        }

//From here onwards is information about debugging.

        //Debug button.
        private void btnDebug_Click(object sender, EventArgs e)
        {
            string txtName = txtUsername.Text;
            string drpLoc = cmboLocation.SelectedItem.ToString();
            string txtLoc = txtLocation.Text;
            string drpCat = cmboCategory.SelectedItem.ToString();
            string txtDetL = txtDetailsL.Text;
            string txtDesc = txtDescription.Text;

            if ((txtDetailsL.Visible) & (txtLocation.Visible))
            {
                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + "Store ID: " + txtLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + " | " + txtLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine) +
                                    ("Username: " + txtDetL + Environment.NewLine + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                    );
            }
            else if ((txtDetailsL.Visible) & (!txtLocation.Visible))
            {
                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + drpLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine) +
                                    ("Username: " + txtDetL + Environment.NewLine + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                    );
            }
            else if ((txtDetailsS.Visible) & (txtLocation.Visible))
            {
                string drpDet = cmboDetails.SelectedItem.ToString();
                string txtDetS = txtDetailsS.Text;

                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + drpLoc + txtLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + " | " + txtLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine) +
                                    ("Machine ID: " + drpDet + " | " + txtDetS + Environment.NewLine + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                    );
            }
            else if ((txtDetailsS.Visible) & (!txtLocation.Visible))
            {
                string drpDet = cmboDetails.SelectedItem.ToString();
                string txtDetS = txtDetailsS.Text;

                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + drpLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine) +
                                    ("Machine ID: " + drpDet + " | " + txtDetS + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                    );
            }
            else if (txtLocation.Visible)
            {
                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + drpLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + txtLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                    );
            }

            else
            {
                lblDebugHeader.Text = (txtName + " | " + drpCat + " | " + drpLoc);
                lblDebugBody.Text = (("Name: " + txtName + Environment.NewLine) +
                                    ("Location: " + drpLoc + Environment.NewLine) +
                                    ("Category: " + drpCat + Environment.NewLine + Environment.NewLine) +
                                    ("Description:" + Environment.NewLine) +
                                    (txtDesc)
                                    );
            }
        }
    }
}
