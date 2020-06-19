using System.Windows;
using System.Windows.Input;

namespace WPFbasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        main_calculation cal = new main_calculation();
        History_page his = new History_page();
        Pages.Credit cre = new Pages.Credit();
        public MainWindow()
        {
            InitializeComponent();
            CloseButton.Click += (s, e) => Close();
            Main.Content = cal;
        }

        private void draging_bar(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = cal;
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = his;
        }
        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = cre;
        }

    }
}
