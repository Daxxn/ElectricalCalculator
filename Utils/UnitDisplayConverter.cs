using CustomDataTypeLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ElectricalCalculator.Utils
{
   public class UnitDisplayConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if (value is Prefix p)
         {
            switch (p)
            {
               case Prefix.Peta:
                  return "P";
               case Prefix.Tera:
                  return "T";
               case Prefix.Giga:
                  return "G";
               case Prefix.Mega:
                  return "M";
               case Prefix.Kilo:
                  return "K";
               case Prefix.Hecto:
                  return "H";
               case Prefix.Deka:
                  return "D";
               case Prefix.Base:
                  return "";
               case Prefix.Deci:
                  return "d";
               case Prefix.Centi:
                  return "c";
               case Prefix.Milli:
                  return "m";
               case Prefix.Micro:
                  return "μ";
               case Prefix.Nano:
                  return "n";
               case Prefix.Angs:
                  return "a";
               case Prefix.Pico:
                  return "P";
               default:
                  return "";
            }
         }
         return "";
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if (value is string p)
         {
            switch (p)
            {
               case "P":
                  return Prefix.Peta;
               case "T":
                  return Prefix.Tera;
               case "G":
                  return Prefix.Giga;
               case "M":
                  return Prefix.Mega;
               case "K":
                  return Prefix.Kilo;
               case "H":
                  return Prefix.Hecto;
               case "D":
                  return Prefix.Deka;
               case "":
                  return Prefix.Base;
               case "d":
                  return Prefix.Deci;
               case "c":
                  return Prefix.Centi;
               case "m":
                  return Prefix.Milli;
               case "μ":
                  return Prefix.Micro;
               case "n":
                  return Prefix.Nano;
               case "a":
                  return Prefix.Angs;
               case "p":
                  return Prefix.Pico;
               default:
                  return "";
            }
         }
         return "";
      }
   }
}
