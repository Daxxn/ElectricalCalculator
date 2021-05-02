using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class Diode
   {
      #region - Fields & Properties
      public string PartNumber { get; set; }
      public double ForwardVoltage { get; set; }
      public double PeakReverseVoltage { get; set; }
      public double PeakWorkingReverseVoltage { get; set; }
      public double BlockingVoltage { get; set; }
      public double ReverseLeakageCurrent { get; set; }
      public DiodeType Type { get; set; }
      #endregion

      #region - Constructors
      public Diode() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties

      #endregion
   }
}
