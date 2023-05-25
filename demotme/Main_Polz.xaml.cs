using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace demotme
{
    /// <summary>
    /// Логика взаимодействия для Main_Polz.xaml
    /// </summary>
    public partial class Main_Polz : Window
    {

        private u23310Entities entities = new u23310Entities();
        List<Products> itemsProducts = new List<Products>();
        public Main_Polz()
        {
            InitializeComponent();
            ListBooks.ItemsSource = entities.Products.ToList();
        }
        
        private void AddInOrders_MI_Click(object sender, RoutedEventArgs e)
        {
            Products selectedItem = (Products)ListBooks.SelectedItem;
            itemsProducts.Add(selectedItem);
        }

        private void Create_Orders_Button_Click(object sender, RoutedEventArgs e)
        {
             CreateOrders create_Orders = new CreateOrders(itemsProducts);
            create_Orders.Show();
        }

        private void Auth_Button_Click(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
