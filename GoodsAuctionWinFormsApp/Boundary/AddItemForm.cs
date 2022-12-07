using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Control;
using System;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
            durationComboBox.SelectedIndex = 0;
            durationComboBox.DataSource = timeList;
        }


        private void addItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();

            int startBid;
            bool correct = int.TryParse(StartBidBox.Text, out startBid);
            if (startBid <= 0 || (itemNameTextBox.Text == ""))
                correct = false;
            if (correct)
            {

                newItem.setStartingBid(startBid);
                newItem.setItemDescription(itemDescriptionTextBox.Text);
                newItem.setItemName(itemNameTextBox.Text);
                newItem.setCurrentLeader("");

                DateTime time = DateTime.Now;

                newItem.setTimeRemaining( time.AddMinutes(  Convert.ToInt32(durationComboBox.Text) ) );

                bool succesfulAdd = AddItemControl.Submit(newItem);

                //if acceted, destroys window
                if(succesfulAdd)
                {
                    this.Close();
                }
                else
                {
                    failLabel.Visible = true;
                }
                
            }
            else
            {
                StartBidBox.BackColor = Color.Red;
                itemNameTextBox.BackColor = Color.Red;
                failLabel.Visible= true;
            }
    
    



        }
    } 


}
