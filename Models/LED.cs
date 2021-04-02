using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class LED : Model
   {
      #region - Fields & Properties
      private double _forwardVoltage;
      private double _forwardCurrent;
      #endregion

      #region - Constructors
      public LED() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public double ForwardVoltage
      {
         get { return _forwardVoltage; }
         set
         {
            _forwardVoltage = value;
            OnPropertyChanged();
         }
      }

      public double ForwardCurrent
      {
         get { return _forwardCurrent; }
         set
         {
            _forwardCurrent = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
