using Microsoft.Practices.Unity;
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
using WpfPractiseApplication.ViewModels.Interfaces;

namespace WpfPractiseApplication
{
    /// <summary>
    /// Interaction logic for UserDataView.xaml
    /// </summary>
    public partial class UserDataView : UserControl
    { 
        [Dependency]
        public IUserViewModel UserViewModel
        {
            get
            {
                return (IUserViewModel)this.DataContext;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(string.Format($"Argument {nameof(UserViewModel)} setter value must not be null."));
                this.DataContext = value;                
            }
        }

        public UserDataView()
        {
            InitializeComponent();
        }
    }
}
