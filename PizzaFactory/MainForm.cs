namespace PizzaFactory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartCookingButton_Click(object sender, EventArgs e)
        {
            StartCookingButton.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                CookedPizzasListView.Items.Clear();
                CookedPizzasListView.Refresh();

                int numberOfPizzas = (int)PizzaCountNumeric.Value;
                int numberOfOvens = (int)OvenCountNumeric.Value;

                for (int i = 0; i < numberOfPizzas; i++)
                {
                    Pizza pizza = Pizza.GenerateRandomPizza();
                    pizza.Cook();

                    ListViewItem pizzaItem = CookedPizzasListView.Items.Add("1");
                    pizzaItem.SubItems.Add(pizza.Base.Name);
                    pizzaItem.SubItems.Add(pizza.Topping);
                    pizzaItem.SubItems.Add(pizza.CookingTimeMs.ToString());
                    CookedPizzasListView.Refresh();
                }
            }
            finally 
            {
                StartCookingButton.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}