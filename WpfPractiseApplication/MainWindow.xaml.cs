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
using WpfPractiseApplication.Services.Interfaces;
using WpfPractiseApplication.ViewModels.Interfaces;
using WpfPractiseApplication.ViewModels;

namespace WpfPractiseApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDataService _dataService;
        public IUserViewModel UserViewModel { get; private set; }

        public MainWindow(IDataService dataService, IUserViewModel userViewModel)
        {
            if (dataService == null)
                throw new ArgumentNullException(string.Format($"Argument {nameof(dataService)} must not be null."));

            if (userViewModel == null)
                throw new ArgumentNullException(string.Format($"Argument {nameof(userViewModel)} must not be null."));

            _dataService = dataService;
            UserViewModel = userViewModel;

            this.DataContext = UserViewModel;

            InitializeComponent();
        }
    }
}
