using GoodsAuctionWinFormsApp.Control;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class PlaceBidMenu : Form
    {
        private ItemList currentItems = StartupController.iList;

        //list to populate the drop down selection
        private List<int> itemIDNumbers = new List<int>();


        public PlaceBidMenu()
        {
            InitializeComponent();
        }

        //populates chart
        public void refresh(ItemList list)
        {
            currentItems = list;

            int num = 0;
            string[] row = new string[5];
            itemSelector.Items.Clear();

            foreach (Item i in list)
            {

                row[0] = i.getItemID().ToString();
                row[1] = i.getItemName();

                //if no current bid, sets it to the starting bid
                if (i.getCurrentBid() == 0)
                    i.setCurrentBid(i.getStartingBid());
                row[2] = i.getCurrentBid().ToString();
                row[3] = i.getCurrentLeader(); 
                row[4] = i.getTimeRemaining().ToString();

                ItemListViewer.Rows.Add(row);

                itemSelector.Items.Add(i.getItemID());
            }

        }

        //button click
        private void placeBidButton_Click(object sender, EventArgs e)
        {
            int bid;

            //ensures an int
            bool success = int.TryParse(newBidTextBox.Text, out bid);
            
            //ensures is a POSITIVE Int
           
           
                foreach (Item i in currentItems)
                {
                    //proceeds only if the dropdown ID corresponds
                    if (itemSelector.Text == i.getItemID().ToString())
                    {

                        bool greaterBid = PlaceBidControl.CheckBid(bid, i.getCurrentBid());
                        bool dateNotPassed = PlaceBidControl.CheckTime(i.getTimeRemaining());

                    //only passes if int is appropriate, it is not the lesser bid, and time has not expired
                        if (success && greaterBid && dateNotPassed)
                        {
                            i.setCurrentBid(bid);
                            i.setCurrentLeader(LoginControl.getAccount().GetUsername());
                            newBidTextBox.BackColor = Color.White;
                            ItemListViewer.Rows.Clear();

                            PlaceBidControl.UpateDatabase(currentItems, i);
                            refresh(StartupController.iList);
                        }

                        else
                        {
                            if(!dateNotPassed)
                            {
                            newBidTextBox.Text = "EXPIRED";
                            }
                            newBidTextBox.BackColor = Color.Red;
                        }
                    }
               
                
             }
            

            
        }


        //dropdown selector populates the item name and description fields
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item i in currentItems)
            {
                if (itemSelector.Text == i.getItemID().ToString())
                {
                    selectItemLabel.Text = i.getItemName();
                    selectedDescriptionLabel.Text = i.getItemDescription();
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

            LogOutControl.logout(LoginControl.getAccount());
            this.Close();

        }


        //below does nothing, but WinForm will throw an error if deleted
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
