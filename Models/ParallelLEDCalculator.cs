using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ElectricalCalculator.Models
{
   public class ParallelLEDCalculator : Model
   {
      #region - Fields & Properties
      private double _sourceVoltage;
      private ObservableCollection<SeriesLEDCalculator> _leds;
      private double _parallelResistance;
      private double _currentDraw;
      private double _power;
      #endregion

      #region - Constructors
      public ParallelLEDCalculator() { }
      #endregion

      #region - Methods
      public void Calculate()
      {
         double reciprocalSum = 0;
         foreach (var ledCircuit in LEDs)
         {
            ledCircuit.SourceVoltage = SourceVoltage;
            ledCircuit.Calculate();
            reciprocalSum += 1 / ledCircuit.Resistor.Value;
         }
         ParallelResistance = 1 / reciprocalSum;

         CurrentDraw = SourceVoltage / ParallelResistance;
         Power = Math.Pow(CurrentDraw, 2) * ParallelResistance;
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

      public ObservableCollection<SeriesLEDCalculator> LEDs
      {
         get { return _leds; }
         set
         {
            _leds = value;
            OnPropertyChanged();
         }
      }

      public double ParallelResistance
      {
         get { return _parallelResistance; }
         set
         {
            _parallelResistance = value;
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
