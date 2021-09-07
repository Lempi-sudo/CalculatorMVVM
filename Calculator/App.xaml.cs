using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Calculator.Model;
using Calculator.ViewModel;
using Calculator.View;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var ViewModel = new SumatorViewModel();
            var View = new WindowCalculator { DataContext = ViewModel };
            View.Show();
        }

    }
}
