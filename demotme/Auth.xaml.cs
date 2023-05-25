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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        u23310Entities entities = new u23310Entities();
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_But_Click(object sender, RoutedEventArgs e)
        {
            var userObj = entities.Users.FirstOrDefault(x=>x.login==Login_TB.Text &&x.password==Pass_PB.Password);
            if (userObj == null)
            {
                MessageBox.Show("Введите логин или пароль","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    switch (userObj.id_role) {
                    case 1:
                            MessageBox.Show("Добро пожаловать - Администратор", "Вы авторизованы!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Main_Polz main_ = new Main_Polz();
                            main_.Show();
                            break;
                        case 2:
                            MessageBox.Show("Добро пожаловать - Пользователь", "Вы авторизованы!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Admin admin  = new Admin();
                            admin.Show();
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Введите логин и пароль заново", "Вы не авторизованы!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
