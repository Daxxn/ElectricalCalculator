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
      private SMPSType _supplyType;

      private double _inputVoltTol;
      private double _outputVoltTol;

      private double _voltInNom;
      private double _voltInMin;
      private double _voltInMax;

      private double _voltOutNom;
      private double _voltOutMin;
      private double _voltOutMax;

      private double _voltRipple;
      private double _voltSat;
      private double _minimumSwitchFreq;

      private double _currentOutMax;
      private double _currentOut;

      private double _fbResistor1;

      private Diode _selectedDiode;
      #endregion

      #region - Constructors
      public SMPSVariables() { }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public SMPSType SupplyType
      {
         get { return _supplyType; }
         set
         {
            _supplyType = value;
            OnPropertyChanged();
         }
      }

      public double InputVoltageTolerance
      {
         get { return _inputVoltTol; }
         set
         {
            _inputVoltTol = value;
            OnPropertyChanged();
         }
      }

      public double OutputVoltageTolerance
      {
         get { return _outputVoltTol; }
         set
         {
            _outputVoltTol = value;
            OnPropertyChanged();
         }
      }

      public double InputVoltageNominal
      {
         get { return _voltInNom; }
         set
         {
            _voltInNom = value;
            OnPropertyChanged();
         }
      }

      public double InputVoltageMin
      {
         get { return _voltInMin; }
         set
         {
            _voltInMin = value;
            OnPropertyChanged();
         }
      }

      public double InputVoltageMax
      {
         get { return _voltInMax; }
         set
         {
            _voltInMax = value;
            OnPropertyChanged();
         }
      }

      public double OutputVoltageNominal
      {
         get { return _voltOutNom; }
         set
         {
            _voltOutNom = value;
            OnPropertyChanged();
         }
      }

      public double OutputVoltageMin
      {
         get { return _voltOutMin; }
         set
         {
            _voltOutMin = value;
            OnPropertyChanged();
         }
      }

      public double OutputVoltageMax
      {
         get { return _voltOutMax; }
         set
         {
            _voltOutMax = value;
            OnPropertyChanged();
         }
      }

      public double OutputCurrent
      {
         get { return _currentOut; }
         set
         {
            _currentOut = value;
            OnPropertyChanged();
         }
      }

      public double OutputCurrentMax
      {
         get { return _currentOutMax; }
         set
         {
            _currentOutMax = value;
            OnPropertyChanged();
         }
      }

      public double OutputVoltageRipple
      {
         get { return _voltRipple; }
         set
         {
            _voltRipple = value;
            OnPropertyChanged();
         }
      }

      public double DesiredSwFrequency
      {
         get { return _minimumSwitchFreq; }
         set
         {
            _minimumSwitchFreq = value;
            OnPropertyChanged();
         }
      }

      public double SwitchSaturationVoltage
      {
         get { return _voltSat; }
         set
         {
            _voltSat = value;
            OnPropertyChanged();
         }
      }

      public double FBResistor1
      {
         get { return _fbResistor1; }
         set
         {
            _fbResistor1 = value;
            OnPropertyChanged();
         }
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
      #endregion
   }
}
