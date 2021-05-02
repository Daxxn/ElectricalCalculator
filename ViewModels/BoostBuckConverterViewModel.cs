using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class BoostBuckConverterViewModel : Model
   {
      #region - Fields & Properties
      private SMPSModel _PSModel;
      #endregion

      #region - Constructors
      public BoostBuckConverterViewModel() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties

      public SMPSModel PowerSupplyModel
      {
         get { return _PSModel; }
         set
         {
            _PSModel = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
