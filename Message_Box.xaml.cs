using System.Windows;
using System.Windows.Input;

namespace WPFbasics
{
    /// <summary>
    /// Interaction logic for Message_box.xaml
    /// </summary>
    public partial class Message_box : Window
    {
        public Message_box()
        {
            InitializeComponent();
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
