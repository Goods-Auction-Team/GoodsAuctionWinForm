using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Control;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class AddItemMenu : Form
    {
        public AddItemMenu()
        {
            InitializeComponent();
        }

        private ItemList Item;
        public void select()
        {

        }

        //This populates the chart
        public void refresh(ItemList list)
        {   
            foreach (Item i in list)
            {
                currentItemsListView.Items.Add(i.getItemID().ToString(), 0);
                currentItemsListView.Items.Add(i.getItemID().ToString(), 1);
                currentItemsListView.Items.Add(i.getCurrentBid().ToString(),2);
                currentItemsListView.Items.Add(i.getCurrentLeader(),3);
                currentItemsListView.Items.Add(i.getTimeRemaining().ToString(),4);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogOutControl.logout();
            this.Close();
           
        }

        private void insertNewItemButton_Click(object sender, EventArgs e)
        {
            Form itemForm = new AddItemForm();
            itemForm.Show();

        }
    }
}
