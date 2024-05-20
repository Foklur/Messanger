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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Messanger_Database;
using MessangerChatWindow;
namespace MessangerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click()
        {

        }

        private void nickNameTextBox_TextChanged()
        {
        
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nickname = nickNameTextBox.Text;
                string login = loginTextBox.Text;
                string passwordText = passwordTextBox.Text;

                // Перевірка чи пароль містить лише цифри
                if (!passwordText.All(char.IsDigit))
                {
                    MessageBox.Show("Password must contain only digits");
                    return;
                }

                // Перевірка чи пароль має більше або рівно 8 символів
                if (passwordText.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long");
                    return;
                }

                // Перетворення паролю у ціле число
                if (!int.TryParse(passwordText, out int password))
                {
                    MessageBox.Show("Password must be a number");
                    return;
                }

                var newUser = new User
                {
                    Nickname = nickname,
                    Login = login,
                    Password = password,
                    Admin = false
                };

                // Додавання нового користувача до бази даних
                using (var context = new Users_Model())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                // Очищення текстових полів після реєстрації
                nickNameTextBox.Text = "";
                loginTextBox.Text = "";
                passwordTextBox.Text = "";

                MessageBox.Show("User registered successfully!!!");
                //перехід на нове вікно і закриття поточного
                var chatWindow = new MessangerChatWindow.MainWindow();
                chatWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

        }
    }
}

