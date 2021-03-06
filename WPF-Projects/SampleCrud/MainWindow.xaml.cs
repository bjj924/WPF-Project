﻿using ListBox.Model;
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

namespace SampleCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();

            matches.Add(
                new Match()
                {
                    Team1 = "River",
                    Team2 = "Bosta",
                    Score1 = 3,
                    Score2 = 1,
                    Comptition = 90
                });

            matches.Add(
                new Match()
                {
                    Team1 = "Racing",
                    Team2 = "Independiente",
                    Score1 = 1,
                    Score2 = 0,
                    Comptition = 75
                });

            matches.Add(
                new Match()
                {
                    Team1 = "Huracan",
                    Team2 = "San Lorenzo",
                    Score1 = 1,
                    Score2 = 1,
                    Comptition = 80
                });

            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Select Match: " + (lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2);
            }
        }
    }
}
