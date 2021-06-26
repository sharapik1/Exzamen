using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string SelectedCity = "";
        public List<City> CityList { get; set; }
        private IEnumerable<Pokupateli> _PokupateliList = null;
        public IEnumerable<Pokupateli> PokupateliList
        {
            get
            {
                var res = _PokupateliList;
                res = res.Where(c => SelectedCity == "Все города" | c.City == SelectedCity);
                if (SearchFilter != "")
                    res = res.Where(c => c.Name.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                if (SortAsc) res = res.OrderBy(c => c.Summapokupok);
                else res = res.OrderByDescending(c => c.Summapokupok);


                return res;
            }
            set
            {
                _PokupateliList = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new DataProvider("Pokupateli.csv");
            PokupateliList = Globals.dataProvider.GetPokupatelis();
            CityList = Globals.dataProvider.GetCities().ToList();
            CityList.Insert(0, new City { Title = "Все города" });
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("PokupateliList"));
        }
        private void CityFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCity = (CityFilterComboBox.SelectedItem as City).Title;
            Invalidate();
        }
        private string SearchFilter = "";

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }
}
