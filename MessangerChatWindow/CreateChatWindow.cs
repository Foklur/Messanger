using System.Windows;
using System.Windows.Controls;

namespace MessangerChatWindow
{
    public partial class CreateChatWindow : Window
    {
        public CreateChatWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Title = "Create Private Chat";
            this.Width = 300;
            this.Height = 200;

            var stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;

            var label = new Label();
            label.Content = "Enter User ID:";
            stackPanel.Children.Add(label);

            var textBox = new TextBox();
            stackPanel.Children.Add(textBox);

            var button = new Button();
            button.Content = "Create";
            button.Click += (sender, e) =>
            {
                string userId = textBox.Text;
            };
            stackPanel.Children.Add(button);

            this.Content = stackPanel;
        }
    }
}
