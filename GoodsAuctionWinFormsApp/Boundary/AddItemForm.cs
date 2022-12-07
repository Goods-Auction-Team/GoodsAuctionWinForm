using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Control;

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


        //button click
        private void addItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();

            //tests that the bid is an int, that it is >0, and that the name is not empty
            int startBid;
            bool correct = int.TryParse(StartBidBox.Text, out startBid);


            if (startBid <= 0 || (itemNameTextBox.Text == ""))
                correct = false;

            //creates the new item and assigns names
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
