using System.Windows;
using System.Windows.Controls;

namespace MessengerChatWindow
{
    public partial class JoinGroupWindow : Window
    {
        public JoinGroupWindow()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Title = "Join Group Chat";
            this.Width = 300;
            this.Height = 200;

            var stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;

            var label = new Label();
            label.Content = "Enter Group ID:";
            stackPanel.Children.Add(label);

            var textBox = new TextBox();
            stackPanel.Children.Add(textBox);

            var button = new Button();
            button.Content = "Join";
            button.Click += (sender, e) =>
            {
                string groupId = textBox.Text;

            };
            stackPanel.Children.Add(button);

            this.Content = stackPanel;
        }
    }
}
