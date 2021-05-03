using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElectricalCalculator.ViewModels
{
   public class BoostBuckConverterViewModel : Model
   {
      #region - Fields & Properties
      public event EventHandler<SMPSType> SelectedDiagramChanged;
      private SMPSModel _PSModel = new();
      private SMPSType _selectedType = SMPSType.StepDown;
      private double _defaultVoltageTolerance = 0.1;

      public Command CalcCmd { get; init; }
      #endregion

      #region - Constructors
      public BoostBuckConverterViewModel()
      {
         CalcCmd = new(o => Calc());
      }
      #endregion

      #region - Methods
      public void Calc()
      {
         Model.Calc(DefaultVoltageTolerance, SelectedType);
      }
      #endregion

      #region - Full Properties
      public SMPSModel Model
      {
         get { return _PSModel; }
         set
         {
            _PSModel = value;
            OnPropertyChanged();
         }
      }

      public SMPSType SelectedType
      {
         get { return _selectedType; }
         set
         {
            _selectedType = value;
            SelectedDiagramChanged?.Invoke(this, value);
            OnPropertyChanged();
         }
      }

      public double DefaultVoltageTolerance
      {
         get { return _defaultVoltageTolerance; }
         set
         {
            _defaultVoltageTolerance = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
