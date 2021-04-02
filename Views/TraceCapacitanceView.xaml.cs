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
   /// Interaction logic for TraceCapacitanceView.xaml
   /// </summary>
   public partial class TraceCapacitanceView : UserControl
   {
      private readonly SolidColorBrush TextBase = new(Color.FromRgb(200,200,200));
      private readonly SolidColorBrush TextHighlight = new(Color.FromRgb(255,255,255));

      private readonly SolidColorBrush CopperBase = new(Color.FromRgb(185,81,42));
      private readonly SolidColorBrush CopperHighlight = new(Color.FromRgb(191, 128, 104));
      private readonly SolidColorBrush SubstrateBase = new(Color.FromRgb(209,168,94));
      private readonly SolidColorBrush SubstrateHighlight = new(Color.FromRgb(209,186,144));

      public TraceCapacitanceView()
      {
         DataContext = MainViewModel.TraceCapacitanceVM;
         InitializeComponent();
      }

      private void TraceTextBox_GotFocus(object sender, RoutedEventArgs e)
      {
         if (sender is TextBox box)
         {
            switch (box.Name)
            {
               case "WidthBox":
                  substrateDiagram.Fill = SubstrateBase;
                  TopDiagram.Fill = CopperHighlight;
                  TraceWidthDiagramText.Foreground = TextHighlight;
                  TraceThickDiagramText.Foreground = TextBase;
                  SubsWidthDiagramText.Foreground = TextBase;
                  break;
               case "SubstrateBox":
                  substrateDiagram.Fill = SubstrateHighlight;
                  TopDiagram.Fill = CopperBase;
                  TraceWidthDiagramText.Foreground = TextBase;
                  TraceThickDiagramText.Foreground = TextBase;
                  SubsWidthDiagramText.Foreground = TextHighlight;
                  break;
               case "TraceThickBox":
                  substrateDiagram.Fill = SubstrateBase;
                  TopDiagram.Fill = CopperBase;
                  TraceWidthDiagramText.Foreground = TextBase;
                  TraceThickDiagramText.Foreground = TextHighlight;
                  SubsWidthDiagramText.Foreground = TextBase;
                  break;
               default:
                  break;
            }
         }
         else if (sender is ComboBox combo)
         {
            if (combo.Name == "StandardThicknessCombo")
            {
               substrateDiagram.Fill = SubstrateBase;
               TopDiagram.Fill = CopperBase;
               TraceWidthDiagramText.Foreground = TextBase;
               TraceThickDiagramText.Foreground = TextHighlight;
               SubsWidthDiagramText.Foreground = TextBase;
            }
         }
      }
   }
}
