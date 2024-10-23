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
using OsokinUP.Models;

namespace OsokinUP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            OpenPages(new Main());
        }
        public void OpenPages(Page page)
        {
            frame.Navigate(page);
        }
    }
}
