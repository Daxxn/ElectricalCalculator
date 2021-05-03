using ElectricalCalculator.Models;
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
   /// Interaction logic for BoostBuckConverterView.xaml
   /// </summary>
   public partial class BoostBuckConverterView : UserControl
   {
      private BoostBuckConverterViewModel VM { get; init; }
      public BoostBuckConverterView()
      {
         VM = new BoostBuckConverterViewModel();
         DataContext = VM;
         VM.SelectedDiagramChanged += VM_SelectedDiagramChanged;
         InitializeComponent();

         VM_SelectedDiagramChanged(null, SMPSType.StepDown);


      }

      private void VM_SelectedDiagramChanged(object sender, SMPSType e)
      {
         switch (e)
         {
            case SMPSType.StepUp:
               StepUpDiagram.Visibility = Visibility.Visible;
               StepDownDiagram.Visibility = Visibility.Hidden;
               VoltInvertDiagram.Visibility = Visibility.Hidden;
               break;
            case SMPSType.StepDown:
               StepUpDiagram.Visibility = Visibility.Hidden;
               StepDownDiagram.Visibility = Visibility.Visible;
               VoltInvertDiagram.Visibility = Visibility.Hidden;
               break;
            case SMPSType.VoltInvert:
               StepUpDiagram.Visibility = Visibility.Hidden;
               StepDownDiagram.Visibility = Visibility.Hidden;
               VoltInvertDiagram.Visibility = Visibility.Visible;
               break;
            default:
               break;
         }
      }

      private void TextBox_TextChanged(object sender, RoutedEventArgs e)
      {
         if (sender is TextBox tb)
         {
            tb.SelectAll();
         }
      }
   }
}
