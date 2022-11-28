using GoodsAuctionWinFormsApp.Boundary;

namespace GoodsAuctionWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}