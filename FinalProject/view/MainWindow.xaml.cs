﻿using System;
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

namespace FinalProject
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

        private void menuHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.HomePage());
        }

        private void menuKeranjang_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new view.KeranjangPage());
        }
    }
}
