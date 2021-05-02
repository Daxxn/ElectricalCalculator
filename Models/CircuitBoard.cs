using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class CircuitBoard : Model
   {
      #region - Fields & Properties
      private double _relativeDialectricPermiability;

      private double _width;
      private double _substrateThickness;
      private double _thickness = Constants.TypicalPCBThicknesses[PCBThickness.TopBottom];

      private PCBThickness _standardThickness;

      private double _traceLength;

      private double _totalCapacitance;
      #endregion

      #region - Constructors
      public CircuitBoard() { }
      #endregion

      #region - Methods
      public void CalcCapacitance()
      {
         TotalCapacitance = Constants.MetricConstant * RelativeDialectricPermiability * (TraceLength * Math.Pow(10, -4) + 0.8 * Thickness * Math.Pow(10, -4)) / SubstrateThickness * Math.Pow(10, -4);
      }
      #endregion

      #region - Full Properties
      public double Width
      {
         get { return _width; }
         set
         {
            _width = value;
            OnPropertyChanged();
         }
      }

      public double SubstrateThickness
      {
         get { return _substrateThickness; }
         set
         {
            _substrateThickness = value;
            OnPropertyChanged();
         }
      }

      public double Thickness
      {
         get { return _thickness; }
         set
         {
            _thickness = value;
            OnPropertyChanged();
         }
      }

      public PCBThickness StandardThickness
      {
         get { return _standardThickness; }
         set
         {
            _standardThickness = value;
            Thickness = Constants.TypicalPCBThicknesses[value];
            OnPropertyChanged();
         }
      }

      public double TraceLength
      {
         get { return _traceLength; }
         set
         {
            _traceLength = value;
            OnPropertyChanged();
         }
      }

      /// <summary>
      /// My custom variable. Based on the Tracelength and CapacitancePerLength
      /// </summary>

      public double TotalCapacitance
      {
         get { return _totalCapacitance; }
         set
         {
            _totalCapacitance = value;
            OnPropertyChanged();
         }
      }

      public double RelativeDialectricPermiability
      {
         get { return _relativeDialectricPermiability; }
         set
         {
            _relativeDialectricPermiability = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
