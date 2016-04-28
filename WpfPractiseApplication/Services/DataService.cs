using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPractiseApplication.Services.Interfaces;

namespace WpfPractiseApplication.Services
{
    public class DataService : IDataService
    {
        public string GetSpecialString()
        {
            return "This is special data.";
        }
    }
}
