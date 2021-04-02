using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class MainViewModel : ViewModel
   {
      #region - Fields & Properties
      public static I2CBusResistorViewModel I2CBusResVM { get; private set; } = new();
      public static LEDResistorViewModel LEDResVM { get; private set; } = new();
      public static TraceCapacitanceViewModel TraceCapacitanceVM { get; private set; } = new();
      public static VoltageDividerViewModel VoltageDivVM { get; private set; } = new();
      #endregion

      #region - Constructors
      public MainViewModel() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties

      #endregion
   }
}
