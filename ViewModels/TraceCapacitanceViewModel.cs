using ElectricalCalculator.Models;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.ViewModels
{
   public class TraceCapacitanceViewModel : ViewModel
   {
      #region - Fields & Properties
      public static event EventHandler<double> TraceCapacitanceCalcEvent;
      private CircuitBoard _pcb = new();

      public Command RunCalculationCmd { get; init; }
      #endregion

      #region - Constructors
      public TraceCapacitanceViewModel()
      {
         RunCalculationCmd = new((o) => RunCaclulation());
      }
      #endregion

      #region - Methods
      public void RunCaclulation()
      {
         if (PCB is null) return;

         PCB.CalcCapacitance();
         TraceCapacitanceCalcEvent?.Invoke(this, PCB.TotalCapacitance);
      }
      #endregion

      #region - Full Properties
      public CircuitBoard PCB
      {
         get { return _pcb; }
         set
         {
            _pcb = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
