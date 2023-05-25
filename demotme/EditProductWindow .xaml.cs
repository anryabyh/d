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
    /// Логика взаимодействия для EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {
        private Products editedProduct;
        public EditProductWindow(Products product)
        {
            InitializeComponent();
            editedProduct = product;
            DataContext = editedProduct;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Сохранить изменения в объекте editedProduct
            // Объект уже привязан к элементам управления через DataContext
            // Никакой дополнительной логики не требуется

            // Установить результат окна как true, чтобы главное окно знало, что изменения были сохранены
            DialogResult = true;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Закрыть окно без сохранения изменений
            DialogResult = false;
            Close();
        }
    }
}
