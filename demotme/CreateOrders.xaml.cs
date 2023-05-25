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
    /// Логика взаимодействия для CreateOrders.xaml
    /// </summary>
    public partial class CreateOrders : Window
    {
        private List<Products> itemsProducrs;
        u23310Entities entities = new u23310Entities();
        public CreateOrders(List<Products> itemsProducrs)
        {
            InitializeComponent();
            this.itemsProducrs = itemsProducrs;
            UpdateInItemsOrders();

            NamePoints_CB.ItemsSource = entities.Points.ToList();
            NamePoints_CB.DisplayMemberPath = "name_point";
        }

        public void UpdateInItemsOrders()
        {
            LB_StructOrders.ItemsSource = itemsProducrs;
        }

        private void CreateOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            Points selectedPoint = (Points)NamePoints_CB.SelectedItem;

            Orders newOrder = new Orders
            {
                date_order = DateTime.Now,
                date_delivery = DateTime.Now,
                id_point = selectedPoint.id,
                id_users = 2
            };
            entities.Orders.Add(newOrder);
            entities.SaveChanges();

            int orders = newOrder.id;

            foreach(Products product in itemsProducrs)
            {
                Struct_order struct_Order = new Struct_order {
                    id_products = product.id,
                    id_order = orders,
                    colvo = 1
                };
                entities.Struct_order.Add(struct_Order);
            }
            entities.SaveChanges ();
            this.Close();
        }
    }
}
