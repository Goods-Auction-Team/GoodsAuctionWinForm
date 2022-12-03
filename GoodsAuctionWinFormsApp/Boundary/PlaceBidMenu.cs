using GoodsAuctionWinFormsApp.Control;
using GoodsAuctionWinFormsApp.Entity;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class PlaceBidMenu : Form
    {
        private ItemList currentItems;
        private List<int> itemIDNumbers = new List<int>();
        public PlaceBidMenu()
        {
            InitializeComponent();
            itemSelector.DataSource = itemIDNumbers;
        }
 
   
        public void viewItem()
        {

        }
        public void submit()
        {

        }
        public void refresh(ItemList list)
        {
            currentItems = list;
            foreach (Item i in list)
            {
                //populates
                currentItemsListView.Items.Add(i.getItemID().ToString(), 0);
                currentItemsListView.Items.Add(i.getItemID().ToString(), 1);
                currentItemsListView.Items.Add(i.getCurrentBid().ToString(), 2);
                currentItemsListView.Items.Add(i.getCurrentLeader(), 3);
                currentItemsListView.Items.Add(i.getTimeRemaining().ToString(), 4);
                //adds the ID to the dropdown
                itemIDNumbers.Add(i.getItemID());
            }
        }

        private void placeBidButton_Click(object sender, EventArgs e)
        {
            int bid;
            bool success = int.TryParse(newBidTextBox.Text, out bid);

            //ensures is a POSITIVE Int
            if(success && bid > 0)
            {
                foreach(Item i in currentItems)
                {
                    if (itemSelector.SelectedIndex == i.getItemID())
                    {
                        i.setCurrentBid(bid);
                        i.setCurrentLeader(LoginControl.GetUser());
                    }
                }
            }
            else
            {
                newBidTextBox.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Item i in currentItems)
            {
                if(itemSelector.SelectedIndex == i.getItemID())
                {
                    selectItemLabel.Text = i.getItemName();
                    selectedDescriptionLabel.Text = i.getItemDescription();
                }
            }
        }
    }
}
