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
}
