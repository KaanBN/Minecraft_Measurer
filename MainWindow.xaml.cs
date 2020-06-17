﻿using System;
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
        main_calculation cal = new main_calculation();
        History_page his = new History_page();
        Pages.Credit cre = new Pages.Credit();
        public MainWindow()
        {
            InitializeComponent();
            CloseButton.Click += (s, e) => Close();
            Main.Content = new main_calculation();
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
