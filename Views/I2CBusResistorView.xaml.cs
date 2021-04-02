using ElectricalCalculator.ViewModels;
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

namespace ElectricalCalculator.Views
{
   /// <summary>
   /// Interaction logic for I2CBusResistorView.xaml
   /// </summary>
   public partial class I2CBusResistorView : UserControl
   {
      public I2CBusResistorView()
      {
         DataContext = MainViewModel.I2CBusResVM;
         InitializeComponent();
      }
   }
}
