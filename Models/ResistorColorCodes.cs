using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class ResistorColorCodes : Model
   {
      #region - Fields & Properties
      public static readonly Dictionary<ResistorColors, double> ToleranceConverter = new()
      {
         { ResistorColors.Brown, 1 },
         { ResistorColors.Red, 2 },
         { ResistorColors.Green, 0.5 },
         { ResistorColors.Blue, 0.25 },
         { ResistorColors.Violet, 0.1 },
         { ResistorColors.Grey, 0.05 },
         { ResistorColors.Silver, 10 },
      };

      private ResistorColors _first;
      private ResistorColors _second;
      private ResistorColors _multiplier;
      private ResistorColors _tolerance;

      private double _resistorValue;
      #endregion

      #region - Constructors
      public ResistorColorCodes() { }
      #endregion

      #region - Methods
      public void CalcResistorBands()
      {

      }

      //public void CalcResistorBands(int value, double tolerance = 0)
      //{
      //   CalcTolerance(tolerance);

      //   string valueString = $"{value}";
      //   valueString = valueString.Trim('0');
      //   double firstDigit = ;

      //}

      private void CalcTolerance(double tolerance)
      {
         if (tolerance is not 0)
         {
            if (ToleranceConverter.ContainsValue(tolerance))
            {
               foreach (var val in ToleranceConverter)
               {
                  if (val.Value == tolerance)
                  {
                     Tolerance = val.Key;
                     break;
                  }
               }
            }
         }
      }

      public void CalcResistorBands(double value, double tolerance = 0)
      {

      }

      public void CalcResistorValue()
      {
         var firstDigit = (int)First;
         var secondDigit = (int)Second;

         double sigFigure = firstDigit * 10 + secondDigit;
         ResistorValue = sigFigure * Math.Pow(10d, (double)Multiplier);
      }
      #endregion

      #region - Full Properties
      public ResistorColors First
      {
         get { return _first; }
         set
         {
            _first = value;
            OnPropertyChanged();
         }
      }

      public ResistorColors Second
      {
         get { return _second; }
         set
         {
            _second = value;
            OnPropertyChanged();
         }
      }

      public ResistorColors Multiplier
      {
         get { return _multiplier; }
         set
         {
            _multiplier = value;
            OnPropertyChanged();
         }
      }

      public ResistorColors Tolerance
      {
         get { return _tolerance; }
         set
         {
            _tolerance = value;
            OnPropertyChanged();
         }
      }

      public double ResistorValue
      {
         get { return _resistorValue; }
         set
         {
            _resistorValue = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
