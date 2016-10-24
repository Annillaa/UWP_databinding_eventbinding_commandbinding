using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UWPCommandBinding_DEMO.ViewMode
{
    class MyButtonMode : INotifyPropertyChanged
    {
        private string bt1Greeting;
        private string bt2Greeting;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Bt1Greeting
        {
            get{ return bt1Greeting;}
            set{ bt1Greeting = value; OnPropertyChanged();  }
        }

        public string   Bt2Greeting
        {
            get { return bt2Greeting; }
            set { bt2Greeting = value; OnPropertyChanged(); }
        }

        public string GreetResult
        {
            get { return bt2Greeting+" "+bt1Greeting; }
        }
        public MyButtonMode(string bt1, string bt2)
        {
            Bt1Greeting = bt1;
            Bt2Greeting = bt2;
        }

        public void setHelloForGreeting()
        {
            Bt1Greeting = "hello";
           
        }

        public void setFuckForGreeting()
        {
            Bt2Greeting = "Fuch off";
           
        }

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    PropertyChangedEventArgs eventArguments = new PropertyChangedEventArgs(propertyName);

        //    if (handler != null)
        //    {
        //        handler(this, eventArguments);
        //    }
        //}
        //public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
