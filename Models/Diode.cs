using CustomDataTypeLibrary;
using MVVMLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalCalculator.Models
{
   public class Diode : Model
   {
      #region - Fields & Properties
      private string _partNumber;
      public DiodeType _type;

      private Metric _forwardVoltageD = new(Measurement.Voltage);
      private Metric _peakReverseVoltageD = new(Measurement.Voltage);
      private Metric _peakWorkingReverseVoltageD = new(Measurement.Voltage);
      private Metric _blockingVoltageD = new(Measurement.Voltage);
      private Metric _reverseLeakageCurrentD = new(Measurement.Current);
      #endregion

      #region - Constructors
      public Diode() { }
      public Diode(DiodeType type)
      {
         Type = type;
      }
      #endregion

      #region - Methods

      #endregion

      #region - Full Properties
      public string PartNumber
      {
         get => _partNumber;
         set => _partNumber = value;
      }

      public double ForwardVoltage
      {
         get => ForwardVoltageD.FullValue;
      }

      public double PeakReverseVoltage
      {
         get => PeakReverseVoltageD.FullValue;
      }

      public double PeakWorkingReverseVoltage
      {
         get => PeakWorkingReverseVoltageD.FullValue;
      }

      public double BlockingVoltage
      {
         get => BlockingVoltageD.FullValue;
      }

      public double ReverseLeakageCurrent
      {
         get => ReverseLeakageCurrentD.FullValue;
      }

      public DiodeType Type
      {
         get { return _type; }
         set
         {
            _type = value;
            OnPropertyChanged();
         }
      }

      #region Display Props
      public Metric ForwardVoltageD
      {
         get { return _forwardVoltageD; }
         set
         {
            _forwardVoltageD = value;
            OnPropertyChanged();
         }
      }

      public Metric PeakReverseVoltageD
      {
         get { return _peakReverseVoltageD; }
         set
         {
            _peakReverseVoltageD = value;
            OnPropertyChanged();
         }
      }

      public Metric PeakWorkingReverseVoltageD
      {
         get { return _peakWorkingReverseVoltageD; }
         set
         {
            _peakWorkingReverseVoltageD = value;
            OnPropertyChanged();
         }
      }

      public Metric BlockingVoltageD
      {
         get { return _blockingVoltageD; }
         set
         {
            _blockingVoltageD = value;
            OnPropertyChanged();
         }
      }

      public Metric ReverseLeakageCurrentD
      {
         get { return _reverseLeakageCurrentD; }
         set
         {
            _reverseLeakageCurrentD = value;
            OnPropertyChanged();
         }
      }
      #endregion
      #endregion
   }
}
