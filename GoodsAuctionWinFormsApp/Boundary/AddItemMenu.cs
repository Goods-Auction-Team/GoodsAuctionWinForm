using GoodsAuctionWinFormsApp.Entity;
using GoodsAuctionWinFormsApp.Control;

namespace GoodsAuctionWinFormsApp.Boundary
{
    public partial class AddItemMenu : Form
    {
        ItemList currentItems; 

        public AddItemMenu()
        {
            InitializeComponent();
        }
        
        //This populates the chart
        public void refresh(ItemList list)
        {
           
            currentItems = list;

            int num = 0;
            string[] row = new string[5];

            foreach (Item i in list)
            {

                row[0] = i.getItemID().ToString();
                row[1] = i.getItemName();
                if (i.getCurrentBid() == 0)
                    i.setCurrentBid(i.getStartingBid());
                row[2] = i.getCurrentBid().ToString();
                row[3] = i.getCurrentLeader();
                row[4] = i.getTimeRemaining().ToString();


                ItemListViewer.Rows.Add(row);
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogOutControl.logout(LoginControl.getAccount());
            AddItemMenu menu = new AddItemMenu();
            this.Close();
        }

        //launches add item form and closes
        private void insertNewItemButton_Click(object sender, EventArgs e)
        {
            AddItemControl.AddItem();
            this.Close();
        }
    }
}
