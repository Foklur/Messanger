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



using MessangerChatWindow;

namespace MessengerChatWindow
{
    public partial class MainWindow : Window
    {
        private JoinGroupWindow joinGroupWindow;
        private CreateGroupWindow createGroupWindow;
        private CreateChatWindow createChatWindow;

        public MainWindow()
        {
            joinGroupWindow = new JoinGroupWindow();
            createGroupWindow = new CreateGroupWindow();
            createChatWindow = new CreateChatWindow();
        }



        private void JoinToGroupButton_Click(object sender, RoutedEventArgs e)
        {
            joinGroupWindow.ShowDialog();
        }

        private void CreateGroupButton_Click(object sender, RoutedEventArgs e)
        {
            createGroupWindow.ShowDialog();
        }

        private void CreateChatButton_Click(object sender, RoutedEventArgs e)
        {
            createChatWindow.ShowDialog();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успішно прийнято!");
        }


        private void BlockButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("User blocked successfully."); 
        }

    }
}







