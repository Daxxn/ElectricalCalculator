using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class VoltageDividerViewModel : ViewModel
   {
      #region - Fields & Properties
      private double _sourceVoltage;
      private double _dividerVoltage;
      private double _currentDraw;
      private double _r1;
      private double _r2;
      private double _rL;

      public Command RefreshCalcCmd { get; init; }
      #endregion

      #region - Constructors
      public VoltageDividerViewModel()
      {
         RefreshCalcCmd = new((o) => Caclulate());
      }
      #endregion

      #region - Methods
      public void Caclulate()
      {
         DividerVoltage = SourceVoltage * R2 / (R1 + R2);
         CurrentDraw = SourceVoltage / (R1 + R2);
      }
      #endregion

      #region - Full Properties
      public double SourceVoltage
      {
         get { return _sourceVoltage; }
         set
         {
            _sourceVoltage = value;
            OnPropertyChanged();
         }
      }

      public double CurrentDraw
      {
         get { return _currentDraw; }
         set
         {
            _currentDraw = value;
            OnPropertyChanged();
         }
      }

      public double DividerVoltage
      {
         get { return _dividerVoltage; }
         set
         {
            _dividerVoltage = value;
            OnPropertyChanged();
         }
      }

      public double R1
      {
         get { return _r1; }
         set
         {
            _r1 = value;
            OnPropertyChanged();
         }
      }

      public double R2
      {
         get { return _r2; }
         set
         {
            _r2 = value;
            OnPropertyChanged();
         }
      }

      public double RLoad
      {
         get { return _rL; }
         set
         {
            _rL = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
