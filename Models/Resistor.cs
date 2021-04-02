using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class Resistor : Model
   {
      #region - Fields & Properties
      private string _name;
      private double _value;
      #endregion

      #region - Constructors
      public Resistor() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public string Name
      {
         get { return _name; }
         set
         {
            _name = value;
            OnPropertyChanged();
         }
      }

      public double Value
      {
         get { return _value; }
         set
         {
            _value = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
