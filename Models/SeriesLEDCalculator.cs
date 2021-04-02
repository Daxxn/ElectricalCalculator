using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class SeriesLEDCalculator : Model
   {
      #region - Fields & Properties
      private LED _led;
      private Resistor _resistor = new()
      {
         Name = "Current Limit Resistor"
      };
      private double _sourceVoltage;
      private double _currentDraw;
      private double _power;
      #endregion

      #region - Constructors
      public SeriesLEDCalculator() { }
      #endregion

      #region - Methods
      public void Calculate()
      {
         if (LED.ForwardCurrent > 0)
         {
            Resistor.Value = (SourceVoltage - LED.ForwardVoltage) / LED.ForwardCurrent;
            CurrentDraw = LED.ForwardCurrent;
            Power = Math.Pow(CurrentDraw, 2) * Resistor.Value;
         }
      }
      #endregion

      #region - Full Properties
      public LED LED
      {
         get { return _led; }
         set
         {
            _led = value;
            OnPropertyChanged();
         }
      }

      public Resistor Resistor
      {
         get { return _resistor; }
         set
         {
            _resistor = value;
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

      public double CurrentDraw
      {
         get { return _currentDraw; }
         set
         {
            _currentDraw = value;
            OnPropertyChanged();
         }
      }

      public double Power
      {
         get { return _power; }
         set
         {
            _power = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
