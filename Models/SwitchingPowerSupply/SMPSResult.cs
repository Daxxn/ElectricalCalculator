using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class SMPSResult : Model
   {
      #region - Fields & Properties
      private double _mainInductor;
      private double _timingCap;
      private double _outputCap;
      private double _fbRes2;
      private double _senseRes;

      #region Optional Components
      private double _filterInd;
      private double _filterCap;
      #endregion
      #endregion

      #region - Constructors
      public SMPSResult(
         double mainInductor,
         double timingCapacitor,
         double outputCapacitor,
         double fBResistor2,
         double filterCapacitor,
         double filterInductor,
         double senseResistor
      )
      {
         MainInductor = mainInductor;
         TimingCapacitor = timingCapacitor;
         OutputCapacitor = outputCapacitor;
         FBResistor2 = fBResistor2;
         FilterCapacitor = filterCapacitor;
         FilterInductor = filterInductor;
         SenseResistor = senseResistor;
      }
      #endregion

      #region - Methods
      public override string ToString()
      {
         double R(double input)
         {
            return Math.Round(input, 4);
         }
         return $"Ind: {R(MainInductor)} TimingCap: {R(TimingCapacitor)} , OutCap: {R(OutputCapacitor)} , FBRes2: {R(FBResistor2)}\nOptional {{\n\tFilterInd: {R(FilterInductor)} , FilterCap: {R(FilterCapacitor)}\n}}";
      }
      #endregion

      #region - Full Properties
      public double MainInductor
      {
         get { return _mainInductor; }
         set
         {
            _mainInductor = value;
            OnPropertyChanged();
         }
      }

      public double TimingCapacitor
      {
         get { return _timingCap; }
         set
         {
            _timingCap = value;
            OnPropertyChanged();
         }
      }

      public double OutputCapacitor
      {
         get { return _outputCap; }
         set
         {
            _outputCap = value;
            OnPropertyChanged();
         }
      }

      public double FBResistor2
      {
         get { return _fbRes2; }
         set
         {
            _fbRes2 = value;
            OnPropertyChanged();
         }
      }

      public double SenseResistor
      {
         get { return _senseRes; }
         set
         {
            _senseRes = value;
            OnPropertyChanged();
         }
      }

      #region Optional
      public double FilterInductor
      {
         get { return _filterInd; }
         set
         {
            _filterInd = value;
            OnPropertyChanged();
         }
      }

      public double FilterCapacitor
      {
         get { return _filterCap; }
         set
         {
            _filterCap = value;
            OnPropertyChanged();
         }
      }
      #endregion
      #endregion
   }
}
