using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class ResistorColorCodesViewModel : ViewModel
   {
      #region - Fields & Properties
      private ResistorColorCodes _colorCodes;
      #endregion

      #region - Constructors
      public ResistorColorCodesViewModel() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public ResistorColorCodes ColorCodes
      {
         get { return _colorCodes; }
         set
         {
            _colorCodes = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
