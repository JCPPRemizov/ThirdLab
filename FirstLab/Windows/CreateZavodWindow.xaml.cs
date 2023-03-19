using FirstLab.DataSetTableAdapters;
using System.ComponentModel;
using System.Windows;


namespace SecondLab.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreateZavodWindow.xaml
    /// </summary>
    public partial class CreateZavodWindow : Window
    {
        public static MainWindow mainWindow;
        public CreateZavodWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            if (NameTextBox.Text != string.Empty && IncomeTextBox.Text != string.Empty && TypeOfZavodBox.SelectedItem != null)
            {
                if (int.TryParse(IncomeTextBox.Text, out int income))
                {
                    new zavodTableAdapter().InsertZavod(NameTextBox.Text, TypeOfZavodBox.SelectedIndex + 1, income);
                    MessageBox.Show("Завод добавлен!", "Успех");
                    UpdateDataGrid();
                }
                else
                {
                    MessageBox.Show("Введите число в поле \"Прибыль завода\"!", "Ошибка");
                    return;
                }
            }
        }
        private void UpdateDataGrid()
        {
            mainWindow.MainDataGrid.ItemsSource = new zavodTableAdapter().GetData();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void TypeOfZavodBox_DropDownOpened(object sender, System.EventArgs e)
        {
            TypeOfZavodBox.ItemsSource = new specializationsTableAdapter().GetData();
            TypeOfZavodBox.DisplayMemberPath = "name";
            TypeOfZavodBox.SelectedValuePath = "id";
        }
    }
}
