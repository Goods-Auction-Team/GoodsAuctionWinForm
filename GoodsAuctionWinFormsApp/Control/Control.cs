using GoodsAuctionWinFormsApp.Boundary;
namespace GoodsAuctionWinFormsApp.Control
{
    public class Controller
    {
        List<Form> formList;
        private LoginForm lf;

        public Controller()
        {
            formList = new List<Form>();
        }

        public void addForm(Form form)
        {
            formList.Add(form);
        }

        //this method will return a desired form type from the list of forms
        //ex: getForm(form.GetType());
        public Form getForm(System.Type t)
        {
            foreach (Form f in formList)
                if (f.GetType().Equals(t))
                    return f;

            return null;
        }
    }
}
