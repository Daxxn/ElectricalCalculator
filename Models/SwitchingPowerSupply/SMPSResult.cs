using CustomDataTypeLibrary;
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
      #region Old Props
      //private double _mainInductor;
      //private double _timingCap;
      //private double _outputCap;
      //private double _fbRes2;
      //private double _senseRes;

      //#region Optional Components
      //private double _filterInd;
      //private double _filterCap;
      //#endregion
      #endregion

      #region Display Props
      private Metric _mainInductorD = new(Measurement.Inductance);
      private Metric _timingCapD = new(Measurement.Capacitance);
      private Metric _outputCapD = new(Measurement.Capacitance);
      private Metric _fbRes2D = new(Measurement.Resistance);
      private Metric _senseResD = new(Measurement.Resistance);

      private Metric _filterIndD = new(Measurement.Inductance);
      private Metric _filterCapD = new(Measurement.Capacitance);
      #endregion
      #endregion

      #region - Constructors
      public SMPSResult() { }
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
         MainInductorD = new(mainInductor);
         TimingCapacitorD = new(timingCapacitor);
         OutputCapacitorD = new(outputCapacitor);
         FBResistor2D = new(fBResistor2);
         FilterCapacitorD = new(filterCapacitor);
         FilterInductorD = new(filterInductor);
         SenseResistorD = new(senseResistor);
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
      #region Old Props
      //public double MainInductor
      //{
      //   get { return _mainInductor; }
      //   set
      //   {
      //      _mainInductor = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double TimingCapacitor
      //{
      //   get { return _timingCap; }
      //   set
      //   {
      //      _timingCap = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double OutputCapacitor
      //{
      //   get { return _outputCap; }
      //   set
      //   {
      //      _outputCap = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double FBResistor2
      //{
      //   get { return _fbRes2; }
      //   set
      //   {
      //      _fbRes2 = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double SenseResistor
      //{
      //   get { return _senseRes; }
      //   set
      //   {
      //      _senseRes = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double FilterInductor
      //{
      //   get { return _filterInd; }
      //   set
      //   {
      //      _filterInd = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double FilterCapacitor
      //{
      //   get { return _filterCap; }
      //   set
      //   {
      //      _filterCap = value;
      //      OnPropertyChanged();
      //   }
      //}
      #endregion
      public double MainInductor
      {
         get => MainInductorD.FullValue;
      }

      public double TimingCapacitor
      {
         get => TimingCapacitorD.FullValue;
      }

      public double OutputCapacitor
      {
         get => OutputCapacitorD.FullValue;
      }

      public double FBResistor2
      {
         get => FBResistor2D.FullValue;
      }

      public double SenseResistor
      {
         get => SenseResistorD.FullValue;
      }

      public double FilterInductor
      {
         get => FilterInductorD.FullValue;
      }

      public double FilterCapacitor
      {
         get => FilterCapacitorD.FullValue;
      }

      #region Display Props
      public Metric MainInductorD
      {
         get { return _mainInductorD; }
         set
         {
            _mainInductorD = value;
            OnPropertyChanged();
         }
      }

      public Metric TimingCapacitorD
      {
         get { return _timingCapD; }
         set
         {
            _timingCapD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputCapacitorD
      {
         get { return _outputCapD; }
         set
         {
            _outputCapD = value;
            OnPropertyChanged();
         }
      }

      public Metric FBResistor2D
      {
         get { return _fbRes2D; }
         set
         {
            _fbRes2D = value;
            OnPropertyChanged();
         }
      }

      public Metric SenseResistorD
      {
         get { return _senseResD; }
         set
         {
            _senseResD = value;
            OnPropertyChanged();
         }
      }

      public Metric FilterInductorD
      {
         get { return _filterIndD; }
         set
         {
            _filterIndD = value;
            OnPropertyChanged();
         }
      }

      public Metric FilterCapacitorD
      {
         get { return _filterCapD; }
         set
         {
            _filterCapD = value;
            OnPropertyChanged();
         }
      }
      #endregion
      #endregion
   }
}
