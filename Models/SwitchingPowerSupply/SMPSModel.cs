using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class SMPSModel : Model
   {
      #region - Fields & Properties
      private SMPSVariables _inputVariables = new();

      private double _Ton;
      private double _Toff;
      private double _Ton_Toff;
      private double _IpkSw;
      private double _switchingFreq;

      private SMPSResult _result = new();
      #endregion

      #region - Constructors
      public SMPSModel() { }
      #endregion

      #region - Methods
      public void Calc(double defaultTolerance, SMPSType type)
      {
         InputVars.CalcTolerances(defaultTolerance);
         CalcTOnDivTOff(type);
         CalcTOnPlusTOff();
         CalcTOff();
         CalcTOn();
         CalcTimingCap();
         CalcPeakSwitchingCurrent(type);
         CalcSenseResistor();
         CalcMainInductor(type);
         CalcFilterCap(type);
         CalcFeedbackResistor(type);
      }

      private void CalcTOnDivTOff(SMPSType type)
      {
         if (type == SMPSType.VoltInvert)
         {
            TOnDivTOff =
               (Math.Abs(InputVars.OutputVoltageNominal) + InputVars.SelectedDiode.ForwardVoltage)
                        /
               (InputVars.InputVoltageNominal - InputVars.SwitchSaturationVoltage);
         }
         else if (type == SMPSType.StepUp)
         {
            TOnDivTOff =
               (InputVars.OutputVoltageNominal + (InputVars.SelectedDiode.ForwardVoltage - InputVars.InputVoltageMin))
                        /
               (InputVars.InputVoltageMin - InputVars.SwitchSaturationVoltage);
         }
         else
         {
            TOnDivTOff =
               (InputVars.OutputVoltageNominal + InputVars.SelectedDiode.ForwardVoltage)
                        /
               (InputVars.InputVoltageMin - InputVars.SwitchSaturationVoltage - InputVars.OutputVoltageNominal);
         }
      }

      private void CalcFeedbackResistor(SMPSType type)
      {
         Result.FBResistor2D.FullValue = ((InputVars.OutputVoltageNominal / (type == SMPSType.VoltInvert ? -1.25 : 1.25)) - 1) * InputVars.FBResistor1;
      }

      private void CalcTOnPlusTOff()
      {
         TOnPlusTOff = 1 / InputVars.DesiredSwFrequency;
      }

      private void CalcTOff()
      {
         TOff = TOnPlusTOff / (TOnDivTOff + 1);
      }

      private void CalcTOn()
      {
         TOn = TOnPlusTOff - TOff;
      }

      private void CalcTimingCap()
      {
         Result.TimingCapacitorD.FullValue = 4 * Math.Pow(10, -5) * TOn;
      }

      private void CalcPeakSwitchingCurrent(SMPSType type)
      {
         if (type == SMPSType.StepDown)
         {
            PeakSwitchOutputCurrent = 2 * InputVars.OutputCurrentMax;
         }
         else
         {
            PeakSwitchOutputCurrent = 2 * InputVars.OutputCurrentMax * (TOnDivTOff + 1);
         }
      }

      private void CalcSenseResistor()
      {
         Result.SenseResistorD.FullValue = 0.3 / PeakSwitchOutputCurrent;
      }

      private void CalcMainInductor(SMPSType type)
      {
         Result.MainInductorD.FullValue =
            ((InputVars.InputVoltageMin - InputVars.SwitchSaturationVoltage - (type == SMPSType.StepDown ? InputVars.OutputVoltageNominal : 0))
                     /
            PeakSwitchOutputCurrent) * TOn;
      }

      private void CalcFilterCap(SMPSType type)
      {
         if (type == SMPSType.StepDown)
         {
            Result.OutputCapacitorD.FullValue = PeakSwitchOutputCurrent * TOnPlusTOff / 8 * InputVars.OutputVoltageRipple;
         }
         Result.OutputCapacitorD.FullValue = 9 * (InputVars.OutputCurrent * TOn) / InputVars.OutputVoltageRipple;
      }
      #endregion

      #region - Full Properties
      public SMPSVariables InputVars
      {
         get { return _inputVariables; }
         set
         {
            _inputVariables = value;
            OnPropertyChanged();
         }
      }

      public double TOn
      {
         get { return _Ton; }
         set
         {
            _Ton = value;
            OnPropertyChanged();
         }
      }

      public double TOff
      {
         get { return _Toff; }
         set
         {
            _Toff = value;
            OnPropertyChanged();
         }
      }

      public double TOnDivTOff
      {
         get { return _Ton_Toff; }
         set
         {
            _Ton_Toff = value;
            OnPropertyChanged();
         }
      }

      public double TOnPlusTOff
      {
         get { return _switchingFreq; }
         set
         {
            _switchingFreq = value;
            OnPropertyChanged();
         }
      }

      public double PeakSwitchOutputCurrent
      {
         get { return _IpkSw; }
         set
         {
            _IpkSw = value;
            OnPropertyChanged();
         }
      }

      public SMPSResult Result
      {
         get { return _result; }
         set
         {
            _result = value;
            OnPropertyChanged();
         }
      }
      #endregion
   }
}
