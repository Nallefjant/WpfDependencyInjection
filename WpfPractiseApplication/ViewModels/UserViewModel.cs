using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPractiseApplication.ViewModels.Interfaces;

namespace WpfPractiseApplication.ViewModels
{
    public class UserViewModel : IUserViewModel
    {
        private string _name;

        public UserViewModel()
        {
            Name = "test";
        }


        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException(string.Format($"Argument {nameof(Name)} setter value must not be null."));

                if (_name != value) {
                    _name = value;

                    var handler = this.PropertyChanged;
                    if (handler != null)
                    {
                        handler(this, new PropertyChangedEventArgs(nameof(Name)));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
