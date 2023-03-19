
using FirstLab;
using FirstLab.DataSetTableAdapters;
using SecondLab.Windows;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SecondLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private int x = 0;
        CreateZavodWindow createZavodWindow = new CreateZavodWindow();
        CreateSpecWindow createSpecWindow = new CreateSpecWindow();
        public Component[] adapter =
        {
            new specializationsTableAdapter(),
            new zavodTableAdapter()
        };

        public MainWindow()
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = new specializationsTableAdapter().GetData();
            CreateZavodWindow.mainWindow = this;
            CreateSpecWindow.mainWindow = this;

        }
        private void backStep()
        {
            if (x > 0)
            {
                x--;
                CurTableUpdate(x);
            }
        }
        private void nextStep()
        {
            if (x < adapter.Length - 1)
            {
                x++;
                CurTableUpdate(x);
            }
        }

        private void CurTableUpdate(int curTableIndex)
        {
            switch (curTableIndex)
            {   
                    case 0:
                    {
                        MainDataGrid.ItemsSource = new specializationsTableAdapter().GetData();
                        break;
                    }
                    case 1:
                    {
                        MainDataGrid.ItemsSource = new zavodTableAdapter().GetData();
                        break;
                    }
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            nextStep();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            backStep();
        }


        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (x == 0)
                createSpecWindow.Show();
            else if (x == 1)
                createZavodWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MainDataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                object id = (MainDataGrid.SelectedItem as DataRowView).Row[0];
                if (x == 0)
                {
                   new specializationsTableAdapter().DeleteQuery(Convert.ToInt32(id));

                }
                else if (x == 1)
                {
                   new zavodTableAdapter().DeleteQuery(Convert.ToInt32(id));
                }
                CurTableUpdate(x);
            }
        }
    }
}
