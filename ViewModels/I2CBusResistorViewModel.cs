using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class I2CBusResistorViewModel : ViewModel
   {
      #region - Fields & Properties
      private I2CBusMode _busMode;
      private int _precision = 2;

      private double _sourceVoltage = Constants.StandardVcc;
      private double _busCapacitance = Constants.TypicalCapacitances[I2CBusMode.Standard];
      private double _riseTime = Constants.TypicalRiseTimes[I2CBusMode.Standard];
      private double _lowLevelVoltage = 0;
      private double _lowLevelCurrent = Constants.TypicalLowLevelCurrent(5);

      private double _maxResistance = 0;
      private double _minResistance = 0;
      private double _currentDraw = 0;

      private double _calculatedTraceCapacitance = 0;

      public Command CalcPullupCmd { get; init; }
      #endregion

      #region - Constructors
      public I2CBusResistorViewModel()
      {
         TraceCapacitanceViewModel.TraceCapacitanceCalcEvent += TraceCapacitanceViewModel_TraceCapacitanceCalcEvent;

         CalcPullupCmd = new((o) => CalcPullup());
      }
      #endregion

      #region - Methods
      public void CalcPullup()
      {
         (MinResistance, MaxResistance, RiseTime) = I2CCalc.Calc(SourceVoltage, RiseTime, BusMode, BusCapacitance, LowLevelCurrent);
         MinCurrentDraw = MinResistance != 0 ? SourceVoltage / MinResistance : 0;
         MaxCurrentDraw = MaxResistance != 0 ? SourceVoltage / MaxResistance : 0;
      }

      private void TraceCapacitanceViewModel_TraceCapacitanceCalcEvent(object sender, double e)
      {
         CalculatedTraceCapacitance = e;
      }
      #endregion

      #region - Full Properties
      public I2CBusMode BusMode
      {
         get { return _busMode; }
         set
         {
            _busMode = value;
            BusCapacitance = Constants.TypicalCapacitances[value];
            RiseTime = Constants.TypicalRiseTimes[value];
            OnPropertyChanged();
         }
      }

      public double SourceVoltage
      {
         get { return _sourceVoltage; }
         set
         {
            _sourceVoltage = value;
            OnPropertyChanged();
         }
      }

      public double BusCapacitance
      {
         get { return _busCapacitance; }
         set
         {
            _busCapacitance = value;
            OnPropertyChanged();
         }
      }

      public double RiseTime
      {
         get { return _riseTime; }
         set
         {
            _riseTime = value;
            OnPropertyChanged();
         }
      }

      public double MaxResistance
      {
         get { return _maxResistance; }
         set
         {
            _maxResistance = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(MaxResistanceDisplay));
         }
      }

      public double MaxResistanceDisplay
      {
         get
         {
            return Math.Round(MaxResistance, Precision);
         }
      }

      public double MinResistance
      {
         get { return _minResistance; }
         set
         {
            _minResistance = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(MinResistanceDisplay));
         }
      }

      public double MinResistanceDisplay
      {
         get
         {
            return Math.Round(MinResistance, Precision);
         }
      }

      public double LowLevelCurrent
      {
         get { return _lowLevelCurrent; }
         set
         {
            _lowLevelCurrent = value;
            OnPropertyChanged();
         }
      }

      public double LowLevelVoltage
      {
         get { return _lowLevelVoltage; }
         set
         {
            _lowLevelVoltage = value;
            OnPropertyChanged();
         }
      }

      public double MaxCurrentDraw
      {
         get { return _currentDraw; }
         set
         {
            _currentDraw = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(MaxCurrentDrawDisplay));
         }
      }

      public double MaxCurrentDrawDisplay
      {
         get
         {
            return Math.Round(MaxCurrentDraw * Math.Pow(10, 4), Precision);
         }
      }

      public double MinCurrentDraw
      {
         get { return _currentDraw; }
         set
         {
            _currentDraw = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(MinCurrentDrawDisplay));
         }
      }

      public double MinCurrentDrawDisplay
      {
         get
         {
            return Math.Round(MinCurrentDraw * Math.Pow(10, 4), Precision);
         }
      }

      public double CalculatedTraceCapacitance
      {
         get { return _calculatedTraceCapacitance; }
         set
         {
            _calculatedTraceCapacitance = value;
            OnPropertyChanged();
         }
      }

      public int Precision
      {
         get { return _precision; }
         set
         {
            _precision = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(MaxCurrentDrawDisplay));
            OnPropertyChanged(nameof(MinCurrentDrawDisplay));
            OnPropertyChanged(nameof(MaxResistanceDisplay));
            OnPropertyChanged(nameof(MinResistanceDisplay));
         }
      }
      #endregion
   }
}
