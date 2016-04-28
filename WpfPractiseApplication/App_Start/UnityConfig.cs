using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPractiseApplication.Services.Interfaces;
using WpfPractiseApplication.Services;
using WpfPractiseApplication.ViewModels;
using WpfPractiseApplication.ViewModels.Interfaces;

namespace WpfPractiseApplication.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IDataService, DataService>();
            container.RegisterType<IUserViewModel, UserViewModel>();

            container.Resolve<MainWindow>().Show();
        }
    }
}
