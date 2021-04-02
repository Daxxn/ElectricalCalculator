using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class LEDResistorViewModel : ViewModel
   {
      #region - Fields & Properties
      private SeriesLEDCalculator _seriesLED;
      private ParallelLEDCalculator _parallelLEDs;
      #endregion

      #region - Constructors
      public LEDResistorViewModel() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public SeriesLEDCalculator SeriesLED
      {
         get { return _seriesLED; }
         set
         {
            _seriesLED = value;
            OnPropertyChanged();
         }
      }

      public ParallelLEDCalculator ParallelLEDs
      {
         get { return _parallelLEDs; }
         set
         {
            _parallelLEDs = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
