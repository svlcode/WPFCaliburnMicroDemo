using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCaliburnMicroDemo.ViewModels
{
    public class MainViewModel : Caliburn.Micro.PropertyChangedBase, IMainViewModel
    {
        private string _testValue;

        public string TestValue
        {
            get { return _testValue; }
            set
            {
                _testValue = value;
                NotifyOfPropertyChange(nameof(TestValue));
            }
        }


        public MainViewModel()
        {
            TestValue = "Hello from Caliburn.Micro!";
        }
    }
}
