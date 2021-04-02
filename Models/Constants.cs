using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public struct Constants
   {
      #region I2C Bus
      public const double StandardVcc = 5;
      public const double LowLevelMultiplier = 0.2;
      public const double PullupMultiplier = 0.8473;
      public const double TypicalLowLevelVoltage_3ma = 0.4;

      public static readonly Dictionary<I2CBusMode, double> TypicalRiseTimes = new()
      {
         { I2CBusMode.Standard, 1000 },
         { I2CBusMode.Fast, 300 },
         { I2CBusMode.FastPlus, 120 }
      };
      public static readonly Dictionary<I2CBusMode, double> TypicalCapacitances = new()
      {
         { I2CBusMode.Standard, 400 },
         { I2CBusMode.Fast, 400 },
         { I2CBusMode.FastPlus, 550 }
      };
      public static readonly Dictionary<I2CBusMode, Func<double, double>> TypicalLowLevelVoltage_2ma = new()
      {
         { I2CBusMode.Standard, (double x) => 0 },
         { I2CBusMode.Fast, (double Vcc) => LowLevelMultiplier * Vcc },
         { I2CBusMode.FastPlus, (double Vcc) => LowLevelMultiplier * Vcc }
      };
      #endregion

      #region Trace Thickness
      public const double MetricConstant = 0.0089;
      public const double StandardConstant = 0.225;

      public static readonly Dictionary<PCBThickness, double> TypicalPCBThicknesses = new()
      {
         { PCBThickness.TopBottom, 0.035 },
         { PCBThickness.Middle, 0.017},
      };
      #endregion

      public static double TypicalLowLevelCurrent(double sourceVoltage)
      {
         if (sourceVoltage <= 2)
         {
            return 2;
         }
         else
         {
            return 3;
         }
      }
   }
}
