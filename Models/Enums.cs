using ElectricalCalculator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   [TypeConverter(typeof(EnumDescriptionConverter))]
   public enum I2CBusMode
   {
      [Description("Standard Speed")]
      Standard = 0,
      [Description("Fast Speed")]
      Fast = 1,
      [Description("Fast Speed Plus")]
      FastPlus = 2
   }

   [TypeConverter(typeof(EnumDescriptionConverter))]
   public enum PCBThickness
   {
      [Description("Top/Bottom Layers")]
      TopBottom,
      [Description("Middle Layers")]
      Middle,
   }

   public enum Direction
   {
      Up,
      Down,
      Left,
      Right,
   }

   public enum ResistorColors
   {
      Black,
      Brown,
      Red,
      Orange,
      Yellow,
      Green,
      Blue,
      Violet,
      Grey,
      White,
      Gold = -1,
      Silver = -2
   }

   [TypeConverter(typeof(EnumDescriptionConverter))]
   public enum ResistorBandType
   {
      [Description("4 Band")]
      FourBand,
      [Description("5 Band")]
      FiveBand,
      [Description("6 Band")]
      SixBand,
   }

   [TypeConverter(typeof(EnumDescriptionConverter))]
   public enum SMPSType
   {
      [Description("Step Up")]
      StepUp,
      [Description("Step Down")]
      StepDown,
      [Description("Voltage Inverter")]
      VoltInvert
   }

   [TypeConverter(typeof(EnumDescriptionConverter))]
   public enum DiodeType
   {
      [Description("Logic")]
      Logic,
      [Description("Normal")]
      Normal,
      [Description("Schottky")]
      Schottky,
      [Description("Rectifier")]
      Rectifier,
      [Description("Fast Recovery")]
      FastRecovery,
      [Description("Switching")]
      Switching
   }
}
