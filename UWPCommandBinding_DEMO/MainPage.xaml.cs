using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using UWPCommandBinding_DEMO.ViewMode;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCommandBinding_DEMO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private MyButtonMode MyGreeting = new MyButtonMode("hello world", "hello programmer");
        public ICommand GreetMeCommand { get { return new BaseCommand(() => GreetMeAction()); } }
      

        private void GreetMeAction()
        {
            MyGreeting.Bt2Greeting = "FuchOff";
        }
        public MainPage()
        {
           // this.DataContext = MyGreeting;
            this.InitializeComponent();
        }

        public void setMyGreet(object sender, RoutedEventArgs e)
        {
            MyGreeting.Bt1Greeting = "gl hf";
        }
    }
}
