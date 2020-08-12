using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFbasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserControls.History_usrc his = new UserControls.History_usrc();
        UserControls.Credit_usrc cre = new UserControls.Credit_usrc();
        UserControls.Calculation_userc cal = new UserControls.Calculation_userc();
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = cal;
            CloseButton.Click += (s, e) => Close();
            Main.DataContext = new Model();
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

        private void Frame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            UpdateFrameDataContext();
        }

        private void Frame_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateFrameDataContext();
        }
        private void UpdateFrameDataContext()
        {
            var content = this.Main.Content as FrameworkElement;
            if (content == null)
            {
                return;
            }
            content.DataContext = this.Main.DataContext;
        }

    }
}
