using CustomDataTypeLibrary;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class SMPSVariables : Model
   {
      #region - Fields & Properties
      //private double _inputVoltTol;
      //private double _outputVoltTol;

      //private double _voltInNom;
      //private double _voltInMin;
      //private double _voltInMax;

      //private double _voltOutNom;
      //private double _voltOutMin;
      //private double _voltOutMax;

      //private double _voltRipple;
      //private double _voltSat;
      //private double _minimumSwitchFreq;

      //private double _currentOutMax;
      //private double _currentOut;

      //private double _fbResistor1;

      #region Display Props
      private Metric _inputVoltTolD = new(Measurement.Voltage);
      private Metric _outputVoltTolD = new(Measurement.Voltage);

      private Metric _voltInNomD = new(Measurement.Voltage);
      private Metric _voltInMinD = new(Measurement.Voltage);
      private Metric _voltInMaxD = new(Measurement.Voltage);

      private Metric _voltOutNomD = new(Measurement.Voltage);
      private Metric _voltOutMinD = new(Measurement.Voltage);
      private Metric _voltOutMaxD = new(Measurement.Voltage);

      private Metric _voltRippleD = new(Measurement.Voltage);
      private Metric _voltSatD = new(Measurement.Voltage);
      private Metric _minimumSwitchFreqD = new(Measurement.Frequency);

      private Metric _currentOutMaxD = new(Measurement.Current);
      private Metric _currentOutD = new(Measurement.Current);

      private Metric _fbResistor1D = new(Measurement.Resistance);
      #endregion

      private Diode _selectedDiode = new();
      #endregion

      #region - Constructors
      public SMPSVariables() { }
      #endregion

      #region - Methods
      public void CalcTolerances(double defaultTol)
      {
         (InputVoltageMinD.FullValue, InputVoltageMaxD.FullValue) = FindTolerance(InputVoltageMin, InputVoltageMax, InputVoltageNominal, defaultTol, InputVoltageTolerance);
         (OutputVoltageMinD.FullValue, OutputVoltageMaxD.FullValue) = FindTolerance(OutputVoltageMin, OutputVoltageMax, OutputVoltageNominal, defaultTol, OutputVoltageTolerance);
         (_, OutputCurrentMaxD.FullValue) = FindTolerance(0, OutputCurrentMax, OutputCurrent, defaultTol);

      }

      private (double min, double max) FindTolerance(double min, double max, double nom, double defaultTol, double tol = 0)
      {
         double tolerance = tol == 0 ? defaultTol : tol;
         return (min == 0 ? nom - tolerance : min, max == 0 ? nom + tolerance : max);
      }
      #endregion

      #region - Full Properties
      #region Old Props
       //public double InputVoltageTolerance
      //{
      //   get { return _inputVoltTol; }
      //   set
      //   {
      //      _inputVoltTol = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputVoltageTolerance
      //{
      //   get { return _outputVoltTol; }
      //   set
      //   {
      //      _outputVoltTol = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double InputVoltageNominal
      //{
      //   get { return _voltInNom; }
      //   set
      //   {
      //      _voltInNom = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double InputVoltageMin
      //{
      //   get { return _voltInMin; }
      //   set
      //   {
      //      _voltInMin = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double InputVoltageMax
      //{
      //   get { return _voltInMax; }
      //   set
      //   {
      //      _voltInMax = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputVoltageNominal
      //{
      //   get { return _voltOutNom; }
      //   set
      //   {
      //      _voltOutNom = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputVoltageMin
      //{
      //   get { return _voltOutMin; }
      //   set
      //   {
      //      _voltOutMin = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputVoltageMax
      //{
      //   get { return _voltOutMax; }
      //   set
      //   {
      //      _voltOutMax = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputCurrent
      //{
      //   get { return _currentOut; }
      //   set
      //   {
      //      _currentOut = value;
      //      OnPropertyChanged();
      //   }
      //}

       //public double OutputCurrentMax
      //{
      //   get { return _currentOutMax; }
      //   set
      //   {
      //      _currentOutMax = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double OutputVoltageRipple
      //{
      //   get { return _voltRipple; }
      //   set
      //   {
      //      _voltRipple = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double DesiredSwFrequency
      //{
      //   get { return _minimumSwitchFreq; }
      //   set
      //   {
      //      _minimumSwitchFreq = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double SwitchSaturationVoltage
      //{
      //   get { return _voltSat; }
      //   set
      //   {
      //      _voltSat = value;
      //      OnPropertyChanged();
      //   }
      //}

      //public double FBResistor1
      //{
      //   get { return _fbResistor1; }
      //   set
      //   {
      //      _fbResistor1 = value;
      //      OnPropertyChanged();
      //   }
      //}
      #endregion
      public double InputVoltageTolerance
      {
         get => InputVoltageToleranceD.FullValue;
      }
      public double OutputVoltageTolerance
      {
         get => OutputVoltageToleranceD.FullValue;
      }
      public double InputVoltageNominal
      {
         get => InputVoltageNominalD.FullValue;
      }
      public double InputVoltageMin
      {
         get => InputVoltageMinD.FullValue;
      }
      public double InputVoltageMax
      {
         get => InputVoltageMaxD.FullValue;
      }
      public double OutputVoltageNominal
      {
         get => OutputVoltageNominalD.FullValue;
      }
      public double OutputVoltageMin
      {
         get => OutputVoltageMinD.FullValue;
      }
      public double OutputVoltageMax
      {
         get => OutputVoltageMaxD.FullValue;
      }
      public double OutputCurrent
      {
         get => OutputCurrentD.FullValue;
      }
      public double OutputCurrentMax
      {
         get => OutputCurrentMaxD.FullValue;
      }
      public double OutputVoltageRipple
      {
         get => OutputVoltageRippleD.FullValue;
      }
      public double DesiredSwFrequency
      {
         get => DesiredSwFrequencyD.FullValue;
      }
      public double SwitchSaturationVoltage
      {
         get => SwitchSaturationVoltageD.FullValue;
      }
      public double FBResistor1
      {
         get => FBResistor1D.FullValue;
      }

      public Diode SelectedDiode
      {
         get { return _selectedDiode; }
         set
         {
            _selectedDiode = value;
            OnPropertyChanged();
         }
      }

      #region Display Props
      public Metric InputVoltageToleranceD
      {
         get { return _inputVoltTolD; }
         set
         {
            _inputVoltTolD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputVoltageToleranceD
      {
         get { return _outputVoltTolD; }
         set
         {
            _outputVoltTolD = value;
            OnPropertyChanged();
         }
      }

      public Metric InputVoltageNominalD
      {
         get { return _voltInNomD; }
         set
         {
            _voltInNomD = value;
            OnPropertyChanged();
         }
      }

      public Metric InputVoltageMinD
      {
         get { return _voltInMinD; }
         set
         {
            _voltInMinD = value;
            OnPropertyChanged();
         }
      }

      public Metric InputVoltageMaxD
      {
         get { return _voltInMaxD; }
         set
         {
            _voltInMaxD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputVoltageNominalD
      {
         get { return _voltOutNomD; }
         set
         {
            _voltOutNomD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputVoltageMinD
      {
         get { return _voltOutMinD; }
         set
         {
            _voltOutMinD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputVoltageMaxD
      {
         get { return _voltOutMaxD; }
         set
         {
            _voltOutMaxD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputCurrentD
      {
         get { return _currentOutD; }
         set
         {
            _currentOutD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputCurrentMaxD
      {
         get { return _currentOutMaxD; }
         set
         {
            _currentOutMaxD = value;
            OnPropertyChanged();
         }
      }

      public Metric OutputVoltageRippleD
      {
         get { return _voltRippleD; }
         set
         {
            _voltRippleD = value;
            OnPropertyChanged();
         }
      }

      public Metric DesiredSwFrequencyD
      {
         get { return _minimumSwitchFreqD; }
         set
         {
            _minimumSwitchFreqD = value;
            OnPropertyChanged();
         }
      }

      public Metric SwitchSaturationVoltageD
      {
         get { return _voltSatD; }
         set
         {
            _voltSatD = value;
            OnPropertyChanged();
         }
      }

      public Metric FBResistor1D
      {
         get { return _fbResistor1D; }
         set
         {
            _fbResistor1D= value;
            OnPropertyChanged();
         }
      }
      #endregion
      #endregion
   }
}
