using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public static class I2CCalc
   {
      #region - Fields & Properties
      #endregion

      #region - Methods
      public static (double minRes, double maxRes, double riseTime) Calc(double sourceVoltage, I2CBusMode busMode, double lowLogicCurrent = 0)
      {
         double volageLowLevel = 0.4;
         if (sourceVoltage <= 2)
         {
            volageLowLevel = Constants.TypicalLowLevelVoltage_2ma[busMode](sourceVoltage);
         }

         var riseTime = Constants.TypicalCapacitances[busMode];
         var capacitance = Constants.TypicalCapacitances[busMode];

         var maxRes = riseTime * Math.Pow(10, -9) / (0.8473 * capacitance * Math.Pow(10, -12));
         var minRes = (sourceVoltage - volageLowLevel) / ((lowLogicCurrent == 0 ? Constants.TypicalLowLevelCurrent(sourceVoltage) : lowLogicCurrent) * Math.Pow(10, -3));
         return (minRes, maxRes, riseTime);
      }
      public static (double minRes, double maxRes, double riseTime) Calc(double sourceVoltage, double riseTime, I2CBusMode busMode, double capacitance = 0, double lowLogicCurrent = 0)
      {
         double volageLowLevel = 0.4;
         if (sourceVoltage <= 2)
         {
            volageLowLevel = Constants.TypicalLowLevelVoltage_2ma[busMode](sourceVoltage);
         }

         capacitance = capacitance == 0 ? Constants.TypicalCapacitances[busMode] : capacitance;

         var maxRes = riseTime * Math.Pow(10, -9) / (0.8473 * capacitance * Math.Pow(10, -12));
         var minRes = (sourceVoltage - volageLowLevel) / ((lowLogicCurrent == 0 ? Constants.TypicalLowLevelCurrent(sourceVoltage) : lowLogicCurrent) * Math.Pow(10, -3));
         return (minRes, maxRes, riseTime);
      }

      public static double CalcMaxPullupValue(double maxRiseTime, double busCapacitance)
      {
         return maxRiseTime * Math.Pow(10, -9) / (Constants.PullupMultiplier * busCapacitance * Math.Pow(10, -12));
      }

      public static double CalcBusRiseTime(double minResistance, double busCapacitance)
      {
         return Constants.PullupMultiplier * minResistance * busCapacitance;
      }

      public static double GetTimeDifference(double startTime, double endTime)
      {
         return endTime - startTime;
      }

      // The OLDS
      //public static double CalcMinPullupValue(double sourceVoltage, double lowLevelVoltage, double lowLevelCurrent)
      //{
      //   return (sourceVoltage - lowLevelVoltage) / (lowLevelCurrent * Math.Pow(10, -3));
      //}

      //public static double CalcMaxPullupValue(double maxRiseTime, double busCapacitance)
      //{
      //   return maxRiseTime * Math.Pow(10, -9) / (Constants.PullupMultiplier * busCapacitance * Math.Pow(10, -12));
      //}

      //public static double CalcBusRiseTime(double minResistance, double busCapacitance)
      //{
      //   return Constants.PullupMultiplier * minResistance * busCapacitance;
      //}

      //public static double GetTimeDifference(double startTime, double endTime)
      //{
      //   return endTime - startTime;
      //}
      #endregion

      #region - Full Properties

      #endregion
   }
}
