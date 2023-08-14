﻿using FDS.Core;
using FDS.MVVM.ViewModel;
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

namespace FDS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            displayname01.Text = "Welcome " + Session.name;
        }

        
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var d = new MessageBoxNew("Do you want to logout?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                Login lg = new Login();
                lg.Show();
                this.Close();
                
            }
        }
    }
}
