using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractiseApplication.ViewModels.Interfaces
{
    public interface IUserViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        string Name { get; }
    }
}
