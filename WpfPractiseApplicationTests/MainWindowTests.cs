using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfPractiseApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using WpfPractiseApplication.Services.Interfaces;
using WpfPractiseApplication.ViewModels.Interfaces;

namespace WpfPractiseApplication.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        private Mock<IDataService> _dataServiceMock;
        private MainWindow _mainWindow;
        private Mock<IUserViewModel> _userViewModelMock;

        [TestInitialize]
        public void Setup()
        {
            _dataServiceMock = new Mock<IDataService>();
            _userViewModelMock = new Mock<IUserViewModel>();
            _mainWindow = new MainWindow(_dataServiceMock.Object, _userViewModelMock.Object);
        }        
    }
}