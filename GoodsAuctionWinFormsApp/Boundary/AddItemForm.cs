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

        //When submit is clicked
        //private void addItemButton_Click(object sender, EventArgs e)
        //{

        //    int startBid;
        //    bool correct = int.TryParse(StartBidBox.Text, out startBid);

        //    //Changes startBid to an int, but fails and turns the box Red if it cannot.
        //    if (correct)
        //    {
        //        AddItemControl.insertNewItem(itemNameTextBox.Text, itemDescriptionTextBox.Text, startBid, durationComboBox.SelectedIndex);

        //        System.Windows.Forms.Application.Exit();
        //    }
        //    else
        //    {
        //        StartBidBox.BackColor = Color.Red;
        //    }


        //}


        //When button is clicked, Creates new item and sets initial values, checks for an int for starting bid but NOT for SQL
        private void addItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();

            int startBid;
            bool correct = int.TryParse(StartBidBox.Text, out startBid);
            if (correct)
            {

                newItem.setStartingBid(startBid);
                newItem.setItemDescription(itemDescriptionTextBox.Text);
                newItem.setItemName(itemNameTextBox.Text);

                DateTime time = DateTime.Now;

                newItem.setTimeRemaining( time.AddMinutes(  Convert.ToDouble(durationComboBox.SelectedIndex) ) );

                bool succesfulAdd = AddItemControl.Submit(newItem);

                //if acceted, destroys window
                if(succesfulAdd)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    failLabel.Visible = true;
                }
                
            }
            else
            {
                StartBidBox.BackColor = Color.Red;
            }
    
    



        }
    } 


}
