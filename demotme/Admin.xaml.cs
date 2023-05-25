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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        u23310Entities entities = new u23310Entities();
        public Admin()
        {
            InitializeComponent();
           DG.ItemsSource=entities.Products.ToList();
            
           
        }


        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            Products selectProd = (Products) DG.SelectedItem;
            if(selectProd != null )
            {
                entities.Products.Remove(selectProd);
                entities.SaveChanges();
                DG.ItemsSource = entities.Products.ToList();
            }
        }

        private void EditBut_Click(object sender, RoutedEventArgs e)
        {
            // Получить выбранную запись из DataGrid
            Products selectedProduct = DG.SelectedItem as Products;

            if (selectedProduct != null)
            {
                // Создать и открыть окно редактирования
                EditProductWindow editWindow = new EditProductWindow(selectedProduct);
                editWindow.Show();

                // Проверить, были ли внесены изменения
                if (editWindow.DialogResult == true)
                {
                    // Сохранить измененные данные в базе данных
                    entities.SaveChanges();

                    // Обновить источник данных для DataGrid
                    DG.ItemsSource = entities.Products.ToList();
                }
            }
        }
    }
}
