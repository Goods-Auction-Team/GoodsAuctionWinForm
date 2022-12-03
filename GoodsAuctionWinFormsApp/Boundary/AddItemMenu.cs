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
        public void refresh(ItemList list)
        {

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
