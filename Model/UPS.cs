using LCPReportingSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LCPReportingSystem.Model
{
    public partial class DashBoard : ViewModelBase
    {
        #region UPS1
        string _upsbatterystatus = string.Empty;
        string _upsbatterystatustimestamp = string.Empty;

        string _upsidentmanufacturer = string.Empty;
        string _upsidentmodel= string.Empty;
        string _upsidentupssoftwareversion = string.Empty;
        string _upsserialnumber= string.Empty;
        string _upslocation= string.Empty;
        string _upsestimatedminutesremaining = string.Empty;
        string _upsbatterycurrent = string.Empty;
        string _upsbatterytemperature = string.Empty;
        string _upsinputlinebads = string.Empty;
        string _upsinputfrequency = string.Empty;
        string _upsinputvoltage = string.Empty;
        string _upsinputcurrent = string.Empty;
        string _upsinputtruePower = string.Empty;
        string _upsoutputsource= string.Empty;
        string _upsoutputfrequency= string.Empty;
        string _upsoutputcurrent = string.Empty;
        string _upsoutputpower = string.Empty;
        string _upsbypassfrequency = string.Empty;
        string _upsbypassnumlines = string.Empty;
        string _upsbypassvoltage = string.Empty;
        string _upsbypasscurrent = string.Empty;
        string _upsbypasspower = string.Empty;
        #endregion
        #region UPS2
        string _upsbatterystatus2 = string.Empty;
        string _upsbatterystatustimestamp2 = string.Empty;

        string _upsidentmanufacturer2 = string.Empty;
        string _upsidentmodel2 = string.Empty;
        string _upsidentupssoftwareversion2 = string.Empty;
        string _upsserialnumber2 = string.Empty;
        string _upslocation2 = string.Empty;
        string _upsestimatedminutesremaining2 = string.Empty;
        string _upsbatterycurrent2 = string.Empty;
        string _upsbatterytemperature2 = string.Empty;
        string _upsinputlinebads2 = string.Empty;
        string _upsinputfrequency2 = string.Empty;
        string _upsinputvoltage2 = string.Empty;
        string _upsinputcurrent2 = string.Empty;
        string _upsinputtruePower2 = string.Empty;
        string _upsoutputsource2 = string.Empty;
        string _upsoutputfrequency2 = string.Empty;
        string _upsoutputcurrent2 = string.Empty;
        string _upsoutputpower2 = string.Empty;
        string _upsbypassfrequency2 = string.Empty;
        string _upsbypassnumlines2 = string.Empty;
        string _upsbypassvoltage2 = string.Empty;
        string _upsbypasscurrent2 = string.Empty;
        string _upsbypasspower2 = string.Empty;
        #endregion

        string _upsidentmanufacturerindicator = string.Empty;
        string _upsidentmodelindicator = string.Empty;
        string _upsidentupssoftwareversionindicator = string.Empty;
        string _upsserialnumberindicator = string.Empty;
        string _upslocationindicator = string.Empty;

        string _upsestimatedminutesremainingindicator = string.Empty;
        string _upsbatterycurrentindicator = string.Empty;
        string _upsbatterytemperatureindicator = string.Empty;
        string _upsinputlinebadsindicator = string.Empty;
        string _upsinputfrequencyindicator = string.Empty;
        string _upsinputvoltageindicator = string.Empty;
        string _upsinputcurrentindicator = string.Empty;
        string _upsinputtruePowerindicator = string.Empty;
        string _upsoutputsourceindicator = string.Empty;
        string _upsoutputfrequencyindicator = string.Empty;
        string _upsoutputcurrentindicator = string.Empty;
        string _upsoutputpowerindicator = string.Empty;
        string _upsbypassfrequencyindicator = string.Empty;
        string _upsbypassnumlinesindicator = string.Empty;
        string _upsbypassvoltageindicator = string.Empty;
        string _upsbypasscurrentindicator = string.Empty;
        string _upsbypasspowerindicator = string.Empty;

        #region Indicator
        string _upsidentmanufacturerindicator2 = string.Empty;
        string _upsidentmodelindicator2 = string.Empty;
        string _upsidentupssoftwareversionindicator2 = string.Empty;
        string _upsserialnumberindicator2 = string.Empty;
        string _upslocationindicator2 = string.Empty;

        string _upsestimatedminutesremainingindicator2 = string.Empty;
        string _upsbatterycurrentindicator2 = string.Empty;
        string _upsbatterytemperatureindicator2 = string.Empty;
        string _upsinputlinebadsindicator2 = string.Empty;
        string _upsinputfrequencyindicator2 = string.Empty;
        string _upsinputvoltageindicator2 = string.Empty;
        string _upsinputcurrentindicator2 = string.Empty;
        string _upsinputtruePowerindicator2 = string.Empty;
        string _upsoutputsourceindicator2 = string.Empty;
        string _upsoutputfrequencyindicator2 = string.Empty;
        string _upsoutputcurrentindicator2 = string.Empty;
        string _upsoutputpowerindicator2 = string.Empty;
        string _upsbypassfrequencyindicator2 = string.Empty;
        string _upsbypassnumlinesindicator2 = string.Empty;
        string _upsbypassvoltageindicator2 = string.Empty;
        string _upsbypasscurrentindicator2 = string.Empty;
        string _upsbypasspowerindicator2 = string.Empty;
        #endregion


        string _upsidentmanufacturertimestamp = string.Empty;
        string _upsidentmodeltimestamp = string.Empty;
        string _upsidentupssoftwareversiontimestamp = string.Empty;
        string _upsserialnumbertimestamp = string.Empty;
        string _upslocationtimestamp = string.Empty;

        string _upsestimatedminutesremainingtimestamp = string.Empty;
        string _upsbatterycurrenttimestamp = string.Empty;
        string _upsbatterytemperaturetimestamp = string.Empty;
        string _upsinputlinebadstimestamp = string.Empty;
        string _upsinputfrequencytimestamp = string.Empty;
        string _upsinputvoltagetimestamp = string.Empty;
        string _upsinputcurrenttimestamp = string.Empty;
        string _upsinputtruePowertimestamp = string.Empty;
        string _upsoutputsourcetimestamp = string.Empty;
        string _upsoutputfrequencytimestamp = string.Empty;
        string _upsoutputcurrenttimestamp = string.Empty;
        string _upsoutputpowertimestamp = string.Empty;
        string _upsbypassfrequencytimestamp = string.Empty;
        string _upsbypassnumlinestimestamp = string.Empty;
        string _upsbypassvoltagetimestamp = string.Empty;
        string _upsbypasscurrenttimestamp = string.Empty;
        string _upsbypasspowertimestamp = string.Empty;

        #region timestamp2
        string _upsidentmanufacturertimestamp2 = string.Empty;
        string _upsidentmodeltimestamp2 = string.Empty;
        string _upsidentupssoftwareversiontimestamp2 = string.Empty;
        string _upsserialnumbertimestamp2 = string.Empty;
        string _upslocationtimestamp2 = string.Empty;

        string _upsestimatedminutesremainingtimestamp2 = string.Empty;
        string _upsbatterycurrenttimestamp2 = string.Empty;
        string _upsbatterytemperaturetimestamp2 = string.Empty;
        string _upsinputlinebadstimestamp2 = string.Empty;
        string _upsinputfrequencytimestamp2 = string.Empty;
        string _upsinputvoltagetimestamp2 = string.Empty;
        string _upsinputcurrenttimestamp2 = string.Empty;
        string _upsinputtruePowertimestamp2 = string.Empty;
        string _upsoutputsourcetimestamp2 = string.Empty;
        string _upsoutputfrequencytimestamp2 = string.Empty;
        string _upsoutputcurrenttimestamp2 = string.Empty;
        string _upsoutputpowertimestamp2 = string.Empty;
        string _upsbypassfrequencytimestamp2 = string.Empty;
        string _upsbypassnumlinestimestamp2 = string.Empty;
        string _upsbypassvoltagetimestamp2 = string.Empty;
        string _upsbypasscurrenttimestamp2 = string.Empty;
        string _upsbypasspowertimestamp2 = string.Empty;
        #endregion

        #region UPS1
        public string UpsBatteryStatus
        {
            get { return _upsbatterystatus; }
            set
            {
                _upsbatterystatus = value;
                OnPropertyChanged(nameof(UpsBatteryStatus));
            }
        }
        public string UpsBatteryStatus2
        {
            get { return _upsbatterystatus2; }
            set
            {
                _upsbatterystatus2 = value;
                OnPropertyChanged(nameof(UpsBatteryStatus2));
            }
        }
        public string UpsBatteryStatusTimeStamp
        {
            get { return _upsbatterystatustimestamp; }
            set
            {
                _upsbatterystatustimestamp = value;
                OnPropertyChanged(nameof(UpsBatteryStatusTimeStamp));
            }
        } 
        public string UpsBatteryStatusTimeStamp2
        {
            get { return _upsbatterystatustimestamp2; }
            set
            {
                _upsbatterystatustimestamp2 = value;
                OnPropertyChanged(nameof(UpsBatteryStatusTimeStamp2));
            }
        }
        public string UpsIdentManufacturer 
        {
            get { return _upsidentmanufacturer; }
            set
            {
                _upsidentmanufacturer = value;
                OnPropertyChanged(nameof(UpsIdentManufacturer));
            }
        }
        public string UpsIdentModel 
        {
            get { return _upsidentmodel; }
            set
            {
                _upsidentmodel = value;
                OnPropertyChanged(nameof(UpsIdentModel));
            }
        }
        public string UpsIdentUPSSoftwareVersion 
        {
            get { return _upsidentupssoftwareversion; }
            set
            {
                _upsidentupssoftwareversion = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersion));

            }
        }
        public string UpsSerialNumber 
        {
            get { return _upsserialnumber; }
            set
            {
                _upsserialnumber = value;
                OnPropertyChanged(nameof(UpsSerialNumber));
            }
        }
        public string UpsLocation 
        {
            get { return _upslocation; }
            set
            {
                _upslocation = value;
                OnPropertyChanged(nameof(UpsLocation));
            }
        }
        public string UpsEstimatedMinutesRemaining
        {
            get { return _upsestimatedminutesremaining; }
            set
            {
                _upsestimatedminutesremaining = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemaining));
            }
        }  
        public string UpsBatteryCurrent
        {
            get { return _upsbatterycurrent; }
            set
            {
                _upsbatterycurrent = value;
                OnPropertyChanged(nameof(UpsBatteryCurrent));
            }
        }
        public string UpsBatteryTemperature
        {
            get { return _upsbatterytemperature; }
            set
            {
                _upsbatterytemperature = value;
                OnPropertyChanged(nameof(UpsBatteryTemperature));
            }
        }
        public string UpsInputLineBads
        {
            get { return _upsinputlinebads; }
            set
            {
                _upsinputlinebads = value;
                OnPropertyChanged(nameof(UpsInputLineBads));
            }
        }
        public string UpsInputFrequency
        {
            get { return _upsinputfrequency; }
            set
            {
                _upsinputfrequency = value;
                OnPropertyChanged(nameof(UpsInputFrequency));
            }
        }
        public string UpsInputVoltage
        {
            get { return _upsinputvoltage; }
            set
            {
                _upsinputvoltage = value;
                OnPropertyChanged(nameof(UpsInputVoltage));
            }
        }
        public string UpsInputCurrent
        {
            get { return _upsinputcurrent; }
            set
            {
                _upsinputcurrent = value;
                OnPropertyChanged(nameof(UpsInputCurrent));
            }
        }
        public string UpsInputTruePower
        {
            get { return _upsinputtruePower; }
            set
            {
                _upsinputtruePower = value;
                OnPropertyChanged(nameof(UpsInputTruePower));
            }
        }
        public string UpsOutputSource 
        {
            get { return _upsoutputsource; }
            set
            {
                _upsoutputsource = value;
                OnPropertyChanged(nameof(UpsOutputSource));
            }
        }
        public string UpsOutputFrequency 
        {
            get { return _upsoutputfrequency; }
            set
            {
                _upsoutputfrequency = value;
                OnPropertyChanged(nameof(UpsOutputFrequency));
            }
        }
        public string UpsOutputCurrent
        {
            get { return _upsoutputcurrent; }
            set
            {
                _upsoutputcurrent = value;
                OnPropertyChanged(nameof(UpsOutputCurrent));
            }
        }
        public string UpsOutputPower
        {
            get { return _upsoutputpower; }
            set
            {
                _upsoutputpower = value;
                OnPropertyChanged(nameof(UpsOutputPower));
            }
        }
        public string UpsBypassFrequency 
        {
            get { return _upsbypassfrequency; }
            set
            {
                _upsbypassfrequency = value;
                OnPropertyChanged(nameof(UpsBypassFrequency));
            }
        }
        public string UpsBypassNumLines 
        {
            get { return _upsbypassnumlines; }
            set
            {
                _upsbypassnumlines = value;
                OnPropertyChanged(nameof(UpsBypassNumLines));
            }
        }
        public string UpsBypassVoltage 
        {
            get { return _upsbypassvoltage; }
            set
            {
                _upsbypassvoltage = value;
                OnPropertyChanged(nameof(UpsBypassVoltage));
            }
        }
        public string UpsBypassCurrent
        {
            get { return _upsbypasscurrent; }
            set
            {
                _upsbypasscurrent = value;
                OnPropertyChanged(nameof(UpsBypassCurrent));
            }
        }
        public string UpsBypassPower
        {
            get { return _upsbypasspower; }
            set
            {
                _upsbypasspower = value;
                OnPropertyChanged(nameof(UpsBypassPower));
            }
        }
        #endregion
        #region UPS2
        public string UpsIdentManufacturer2
        {
            get { return _upsidentmanufacturer2; }
            set
            {
                _upsidentmanufacturer2 = value;
                OnPropertyChanged(nameof(UpsIdentManufacturer2));
            }
        }
        public string UpsIdentModel2
        {
            get { return _upsidentmodel2; }
            set
            {
                _upsidentmodel2 = value;
                OnPropertyChanged(nameof(UpsIdentModel2));
            }
        }
        public string UpsIdentUPSSoftwareVersion2
        {
            get { return _upsidentupssoftwareversion2; }
            set
            {
                _upsidentupssoftwareversion2 = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersion2));

            }
        }
        public string UpsSerialNumber2
        {
            get { return _upsserialnumber2; }
            set
            {
                _upsserialnumber2 = value;
                OnPropertyChanged(nameof(UpsSerialNumber2));
            }
        }
        public string UpsLocation2
        {
            get { return _upslocation2; }
            set
            {
                _upslocation2 = value;
                OnPropertyChanged(nameof(UpsLocation2));
            }
        }
        public string UpsEstimatedMinutesRemaining2
        {
            get { return _upsestimatedminutesremaining2; }
            set
            {
                _upsestimatedminutesremaining2 = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemaining2));
            }
        }
        public string UpsBatteryCurrent2
        {
            get { return _upsbatterycurrent2; }
            set
            {
                _upsbatterycurrent2 = value;
                OnPropertyChanged(nameof(UpsBatteryCurrent2));
            }
        }
        public string UpsBatteryTemperature2
        {
            get { return _upsbatterytemperature2; }
            set
            {
                _upsbatterytemperature2 = value;
                OnPropertyChanged(nameof(UpsBatteryTemperature2));
            }
        }
        public string UpsInputLineBads2
        {
            get { return _upsinputlinebads2; }
            set
            {
                _upsinputlinebads2 = value;
                OnPropertyChanged(nameof(UpsInputLineBads2));
            }
        }
        public string UpsInputFrequency2
        {
            get { return _upsinputfrequency2; }
            set
            {
                _upsinputfrequency2 = value;
                OnPropertyChanged(nameof(UpsInputFrequency2));
            }
        }
        public string UpsInputVoltage2
        {
            get { return _upsinputvoltage2; }
            set
            {
                _upsinputvoltage2 = value;
                OnPropertyChanged(nameof(UpsInputVoltage2));
            }
        }
        public string UpsInputCurrent2
        {
            get { return _upsinputcurrent2; }
            set
            {
                _upsinputcurrent2 = value;
                OnPropertyChanged(nameof(UpsInputCurrent2));
            }
        }
        public string UpsInputTruePower2
        {
            get { return _upsinputtruePower2; }
            set
            {
                _upsinputtruePower2 = value;
                OnPropertyChanged(nameof(UpsInputTruePower2));
            }
        }
        public string UpsOutputSource2
        {
            get { return _upsoutputsource2; }
            set
            {
                _upsoutputsource2 = value;
                OnPropertyChanged(nameof(UpsOutputSource2));
            }
        }
        public string UpsOutputFrequency2
        {
            get { return _upsoutputfrequency2; }
            set
            {
                _upsoutputfrequency2 = value;
                OnPropertyChanged(nameof(UpsOutputFrequency2));
            }
        }
        public string UpsOutputCurrent2
        {
            get { return _upsoutputcurrent2; }
            set
            {
                _upsoutputcurrent2 = value;
                OnPropertyChanged(nameof(UpsOutputCurrent2));
            }
        }
        public string UpsOutputPower2
        {
            get { return _upsoutputpower2; }
            set
            {
                _upsoutputpower2 = value;
                OnPropertyChanged(nameof(UpsOutputPower2));
            }
        }
        public string UpsBypassFrequency2
        {
            get { return _upsbypassfrequency2; }
            set
            {
                _upsbypassfrequency2 = value;
                OnPropertyChanged(nameof(UpsBypassFrequency2));
            }
        }
        public string UpsBypassNumLines2
        {
            get { return _upsbypassnumlines2; }
            set
            {
                _upsbypassnumlines2 = value;
                OnPropertyChanged(nameof(UpsBypassNumLines2));
            }
        }
        public string UpsBypassVoltage2
        {
            get { return _upsbypassvoltage2; }
            set
            {
                _upsbypassvoltage2 = value;
                OnPropertyChanged(nameof(UpsBypassVoltage2));
            }
        }
        public string UpsBypassCurrent2
        {
            get { return _upsbypasscurrent2; }
            set
            {
                _upsbypasscurrent2 = value;
                OnPropertyChanged(nameof(UpsBypassCurrent2));
            }
        }
        public string UpsBypassPower2
        {
            get { return _upsbypasspower2; }
            set
            {
                _upsbypasspower2 = value;
                OnPropertyChanged(nameof(UpsBypassPower2));
            }
        }
        #endregion
        public string UpsIdentManufacturerIndicator
        {
            get { return _upsidentmanufacturerindicator; }
            set
            {
                _upsidentmanufacturerindicator = value;
                OnPropertyChanged(nameof(UpsIdentManufacturerIndicator));
            }
        }
        public string UpsIdentModelIndicator
        {
            get { return _upsidentmodelindicator; }
            set
            {
                _upsidentmodelindicator = value;
                OnPropertyChanged(nameof(UpsIdentModelIndicator));
            }
        }
        public string UpsIdentUPSSoftwareVersionIndicator
        {
            get { return _upsidentupssoftwareversionindicator; }
            set
            {
                _upsidentupssoftwareversionindicator = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersionIndicator));

            }
        }
        public string UpsSerialNumberIndicator
        {
            get { return _upsserialnumberindicator; }
            set
            {
                _upsserialnumberindicator = value;
                OnPropertyChanged(nameof(UpsSerialNumberIndicator));
            }
        }
        public string UpsLocationIndicator
        {
            get { return _upslocationindicator; }
            set
            {
                _upslocationindicator = value;
                OnPropertyChanged(nameof(UpsLocationIndicator));
            }
        }
        public string UpsEstimatedMinutesRemainingIndicator
        {
            get { return _upsestimatedminutesremainingindicator; }
            set
            {
                _upsestimatedminutesremainingindicator = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemainingIndicator));
            }
        }
        public string UpsBatteryCurrentIndicator
        {
            get { return _upsbatterycurrentindicator; }
            set
            {
                _upsbatterycurrentindicator = value;
                OnPropertyChanged(nameof(UpsBatteryCurrentIndicator));
            }
        }
        public string UpsBatteryTemperatureIndicator
        {
            get { return _upsbatterytemperatureindicator; }
            set
            {
                _upsbatterytemperatureindicator = value;
                OnPropertyChanged(nameof(UpsBatteryTemperatureIndicator));
            }
        }
        public string UpsInputLineBadsIndicator
        {
            get { return _upsinputlinebadsindicator; }
            set
            {
                _upsinputlinebadsindicator = value;
                OnPropertyChanged(nameof(UpsInputLineBadsIndicator));
            }
        }
        public string UpsInputFrequencyIndicator
        {
            get { return _upsinputfrequencyindicator; }
            set
            {
                _upsinputfrequencyindicator = value;
                OnPropertyChanged(nameof(UpsInputFrequencyIndicator));
            }
        }
        public string UpsInputVoltageIndicator
        {
            get { return _upsinputvoltageindicator; }
            set
            {
                _upsinputvoltageindicator = value;
                OnPropertyChanged(nameof(UpsInputVoltageIndicator));
            }
        }
        public string UpsInputCurrentIndicator
        {
            get { return _upsinputcurrentindicator; }
            set
            {
                _upsinputcurrentindicator = value;
                OnPropertyChanged(nameof(UpsInputCurrentIndicator));
            }
        }
        public string UpsInputTruePowerIndicator
        {
            get { return _upsinputtruePowerindicator; }
            set
            {
                _upsinputtruePowerindicator = value;
                OnPropertyChanged(nameof(UpsInputTruePowerIndicator));
            }
        }
        public string UpsOutputSourceIndicator
        {
            get { return _upsoutputsourceindicator; }
            set
            {
                _upsoutputsourceindicator = value;
                OnPropertyChanged(nameof(UpsOutputSourceIndicator));
            }
        }
        public string UpsOutputFrequencyIndicator
        {
            get { return _upsoutputfrequencyindicator; }
            set
            {
                _upsoutputfrequencyindicator = value;
                OnPropertyChanged(nameof(UpsOutputFrequencyIndicator));
            }
        }
        public string UpsOutputCurrentIndicator
        {
            get { return _upsoutputcurrentindicator; }
            set
            {
                _upsoutputcurrentindicator = value;
                OnPropertyChanged(nameof(UpsOutputCurrentIndicator));
            }
        }
        public string UpsOutputPowerIndicator
        {
            get { return _upsoutputpowerindicator; }
            set
            {
                _upsoutputpowerindicator = value;
                OnPropertyChanged(nameof(UpsOutputPowerIndicator));
            }
        }
        public string UpsBypassFrequencyIndicator
        {
            get { return _upsbypassfrequencyindicator; }
            set
            {
                _upsbypassfrequencyindicator = value;
                OnPropertyChanged(nameof(UpsBypassFrequencyIndicator));
            }
        }
        public string UpsBypassNumLinesIndicator
        {
            get { return _upsbypassnumlinesindicator; }
            set
            {
                _upsbypassnumlinesindicator = value;
                OnPropertyChanged(nameof(UpsBypassNumLinesIndicator));
            }
        }
        public string UpsBypassVoltageIndicator
        {
            get { return _upsbypassvoltageindicator; }
            set
            {
                _upsbypassvoltageindicator = value;
                OnPropertyChanged(nameof(UpsBypassVoltageIndicator));
            }
        }
        public string UpsBypassCurrentIndicator
        {
            get { return _upsbypasscurrentindicator; }
            set
            {
                _upsbypasscurrentindicator = value;
                OnPropertyChanged(nameof(UpsBypassCurrentIndicator));
            }
        }
        public string UpsBypassPowerIndicator
        {
            get { return _upsbypasspowerindicator; }
            set
            {
                _upsbypasspowerindicator = value;
                OnPropertyChanged(nameof(UpsBypassPowerIndicator));
            }
        }
        #region Indicator2
        public string UpsIdentManufacturerIndicator2
        {
            get { return _upsidentmanufacturerindicator2; }
            set
            {
                _upsidentmanufacturerindicator2 = value;
                OnPropertyChanged(nameof(UpsIdentManufacturerIndicator2));
            }
        }
        public string UpsIdentModelIndicator2
        {
            get { return _upsidentmodelindicator2; }
            set
            {
                _upsidentmodelindicator2 = value;
                OnPropertyChanged(nameof(UpsIdentModelIndicator2));
            }
        }
        public string UpsIdentUPSSoftwareVersionIndicator2
        {
            get { return _upsidentupssoftwareversionindicator2; }
            set
            {
                _upsidentupssoftwareversionindicator2 = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersionIndicator2));

            }
        }
        public string UpsSerialNumberIndicator2
        {
            get { return _upsserialnumberindicator2; }
            set
            {
                _upsserialnumberindicator2 = value;
                OnPropertyChanged(nameof(UpsSerialNumberIndicator2));
            }
        }
        public string UpsLocationIndicator2
        {
            get { return _upslocationindicator2; }
            set
            {
                _upslocationindicator2 = value;
                OnPropertyChanged(nameof(UpsLocationIndicator2));
            }
        }
        public string UpsEstimatedMinutesRemainingIndicator2
        {
            get { return _upsestimatedminutesremainingindicator2; }
            set
            {
                _upsestimatedminutesremainingindicator2 = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemainingIndicator2));
            }
        }
        public string UpsBatteryCurrentIndicator2
        {
            get { return _upsbatterycurrentindicator2; }
            set
            {
                _upsbatterycurrentindicator2 = value;
                OnPropertyChanged(nameof(UpsBatteryCurrentIndicator2));
            }
        }
        public string UpsBatteryTemperatureIndicator2
        {
            get { return _upsbatterytemperatureindicator2; }
            set
            {
                _upsbatterytemperatureindicator2 = value;
                OnPropertyChanged(nameof(UpsBatteryTemperatureIndicator2));
            }
        }
        public string UpsInputLineBadsIndicator2
        {
            get { return _upsinputlinebadsindicator2; }
            set
            {
                _upsinputlinebadsindicator2 = value;
                OnPropertyChanged(nameof(UpsInputLineBadsIndicator2));
            }
        }
        public string UpsInputFrequencyIndicator2
        {
            get { return _upsinputfrequencyindicator2; }
            set
            {
                _upsinputfrequencyindicator2 = value;
                OnPropertyChanged(nameof(UpsInputFrequencyIndicator2));
            }
        }
        public string UpsInputVoltageIndicator2
        {
            get { return _upsinputvoltageindicator2; }
            set
            {
                _upsinputvoltageindicator2 = value;
                OnPropertyChanged(nameof(UpsInputVoltageIndicator2));
            }
        }
        public string UpsInputCurrentIndicator2
        {
            get { return _upsinputcurrentindicator2; }
            set
            {
                _upsinputcurrentindicator2 = value;
                OnPropertyChanged(nameof(UpsInputCurrentIndicator2));
            }
        }
        public string UpsInputTruePowerIndicator2
        {
            get { return _upsinputtruePowerindicator2; }
            set
            {
                _upsinputtruePowerindicator2 = value;
                OnPropertyChanged(nameof(UpsInputTruePowerIndicator2));
            }
        }
        public string UpsOutputSourceIndicator2
        {
            get { return _upsoutputsourceindicator2; }
            set
            {
                _upsoutputsourceindicator2 = value;
                OnPropertyChanged(nameof(UpsOutputSourceIndicator2));
            }
        }
        public string UpsOutputFrequencyIndicator2
        {
            get { return _upsoutputfrequencyindicator2; }
            set
            {
                _upsoutputfrequencyindicator2 = value;
                OnPropertyChanged(nameof(UpsOutputFrequencyIndicator2));
            }
        }
        public string UpsOutputCurrentIndicator2
        {
            get { return _upsoutputcurrentindicator2; }
            set
            {
                _upsoutputcurrentindicator2 = value;
                OnPropertyChanged(nameof(UpsOutputCurrentIndicator2));
            }
        }
        public string UpsOutputPowerIndicator2
        {
            get { return _upsoutputpowerindicator2; }
            set
            {
                _upsoutputpowerindicator2 = value;
                OnPropertyChanged(nameof(UpsOutputPowerIndicator2));
            }
        }
        public string UpsBypassFrequencyIndicator2
        {
            get { return _upsbypassfrequencyindicator2; }
            set
            {
                _upsbypassfrequencyindicator2 = value;
                OnPropertyChanged(nameof(UpsBypassFrequencyIndicator2));
            }
        }
        public string UpsBypassNumLinesIndicator2
        {
            get { return _upsbypassnumlinesindicator2; }
            set
            {
                _upsbypassnumlinesindicator2 = value;
                OnPropertyChanged(nameof(UpsBypassNumLinesIndicator2));
            }
        }
        public string UpsBypassVoltageIndicator2
        {
            get { return _upsbypassvoltageindicator2; }
            set
            {
                _upsbypassvoltageindicator2 = value;
                OnPropertyChanged(nameof(UpsBypassVoltageIndicator2));
            }
        }
        public string UpsBypassCurrentIndicator2
        {
            get { return _upsbypasscurrentindicator2; }
            set
            {
                _upsbypasscurrentindicator2 = value;
                OnPropertyChanged(nameof(UpsBypassCurrentIndicator2));
            }
        }
        public string UpsBypassPowerIndicator2
        {
            get { return _upsbypasspowerindicator2; }
            set
            {
                _upsbypasspowerindicator2 = value;
                OnPropertyChanged(nameof(UpsBypassPowerIndicator2));
            }
        }
        #endregion
        public string UpsIdentManufacturerTimestamp
        {
            get { return _upsidentmanufacturertimestamp; }
            set
            {
                _upsidentmanufacturertimestamp = value;
                OnPropertyChanged(nameof(UpsIdentManufacturerTimestamp));
            }
        }
        public string UpsIdentModelTimestamp
        {
            get { return _upsidentmodeltimestamp; }
            set
            {
                _upsidentmodeltimestamp = value;
                OnPropertyChanged(nameof(UpsIdentModelTimestamp));
            }
        }
        public string UpsIdentUPSSoftwareVersionTimestamp
        {
            get { return _upsidentupssoftwareversiontimestamp; }
            set
            {
                _upsidentupssoftwareversiontimestamp = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersionTimestamp));

            }
        }
        public string UpsSerialNumberTimestamp
        {
            get { return _upsserialnumbertimestamp; }
            set
            {
                _upsserialnumbertimestamp = value;
                OnPropertyChanged(nameof(UpsSerialNumberTimestamp));
            }
        }
        public string UpsLocationTimestamp
        {
            get { return _upslocationtimestamp; }
            set
            {
                _upslocationtimestamp = value;
                OnPropertyChanged(nameof(UpsLocationTimestamp));
            }
        }
        public string UpsEstimatedMinutesRemainingTimestamp
        {
            get { return _upsestimatedminutesremainingtimestamp; }
            set
            {
                _upsestimatedminutesremainingtimestamp = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemainingTimestamp));
            }
        }
        public string UpsBatteryCurrentTimestamp
        {
            get { return _upsbatterycurrenttimestamp; }
            set
            {
                _upsbatterycurrenttimestamp = value;
                OnPropertyChanged(nameof(UpsBatteryCurrentTimestamp));
            }
        }
        public string UpsBatteryTemperatureTimestamp
        {
            get { return _upsbatterytemperaturetimestamp; }
            set
            {
                _upsbatterytemperaturetimestamp = value;
                OnPropertyChanged(nameof(UpsBatteryTemperatureTimestamp));
            }
        }
        public string UpsInputLineBadsTimestamp
        {
            get { return _upsinputlinebadstimestamp; }
            set
            {
                _upsinputlinebadstimestamp = value;
                OnPropertyChanged(nameof(UpsInputLineBadsTimestamp));
            }
        }
        public string UpsInputFrequencyTimestamp
        {
            get { return _upsinputfrequencytimestamp; }
            set
            {
                _upsinputfrequencytimestamp = value;
                OnPropertyChanged(nameof(UpsInputFrequencyTimestamp));
            }
        }
        public string UpsInputVoltageTimestamp
        {
            get { return _upsinputvoltagetimestamp; }
            set
            {
                _upsinputvoltagetimestamp = value;
                OnPropertyChanged(nameof(UpsInputVoltageTimestamp));
            }
        }
        public string UpsInputCurrentTimestamp
        {
            get { return _upsinputcurrenttimestamp; }
            set
            {
                _upsinputcurrenttimestamp = value;
                OnPropertyChanged(nameof(UpsInputCurrentTimestamp));
            }
        }
        public string UpsInputTruePowerTimestamp
        {
            get { return _upsinputtruePowertimestamp; }
            set
            {
                _upsinputtruePowertimestamp = value;
                OnPropertyChanged(nameof(UpsInputTruePowerTimestamp));
            }
        }
        public string UpsOutputSourceTimestamp
        {
            get { return _upsoutputsourcetimestamp; }
            set
            {
                _upsoutputsourcetimestamp = value;
                OnPropertyChanged(nameof(UpsOutputSourceTimestamp));
            }
        }
        public string UpsOutputFrequencyTimestamp
        {
            get { return _upsoutputfrequencytimestamp; }
            set
            {
                _upsoutputfrequencytimestamp = value;
                OnPropertyChanged(nameof(UpsOutputFrequencyTimestamp));
            }
        }
        public string UpsOutputCurrentTimestamp
        {
            get { return _upsoutputcurrenttimestamp; }
            set
            {
                _upsoutputcurrenttimestamp = value;
                OnPropertyChanged(nameof(UpsOutputCurrentTimestamp));
            }
        }
        public string UpsOutputPowerTimestamp
        {
            get { return _upsoutputpowertimestamp; }
            set
            {
                _upsoutputpowertimestamp = value;
                OnPropertyChanged(nameof(UpsOutputPowerTimestamp));
            }
        }
        public string UpsBypassFrequencyTimestamp
        {
            get { return _upsbypassfrequencytimestamp; }
            set
            {
                _upsbypassfrequencytimestamp = value;
                OnPropertyChanged(nameof(UpsBypassFrequencyTimestamp));
            }
        }
        public string UpsBypassNumLinesTimestamp
        {
            get { return _upsbypassnumlinestimestamp; }
            set
            {
                _upsbypassnumlinestimestamp = value;
                OnPropertyChanged(nameof(UpsBypassNumLinesTimestamp));
            }
        }
        public string UpsBypassVoltageTimestamp
        {
            get { return _upsbypassvoltagetimestamp; }
            set
            {
                _upsbypassvoltagetimestamp = value;
                OnPropertyChanged(nameof(UpsBypassVoltageTimestamp));
            }
        }
        public string UpsBypassCurrentTimestamp
        {
            get { return _upsbypasscurrenttimestamp; }
            set
            {
                _upsbypasscurrenttimestamp = value;
                OnPropertyChanged(nameof(UpsBypassCurrentTimestamp));
            }
        }
        public string UpsBypassPowerTimestamp
        {
            get { return _upsbypasspowertimestamp; }
            set
            {
                _upsbypasspowertimestamp = value;
                OnPropertyChanged(nameof(UpsBypassPowerTimestamp));
            }
        }
        #region timestamp2
        public string UpsIdentManufacturerTimestamp2
        {
            get { return _upsidentmanufacturertimestamp2; }
            set
            {
                _upsidentmanufacturertimestamp2 = value;
                OnPropertyChanged(nameof(UpsIdentManufacturerTimestamp2));
            }
        }
        public string UpsIdentModelTimestamp2
        {
            get { return _upsidentmodeltimestamp2; }
            set
            {
                _upsidentmodeltimestamp2 = value;
                OnPropertyChanged(nameof(UpsIdentModelTimestamp2));
            }
        }
        public string UpsIdentUPSSoftwareVersionTimestamp2
        {
            get { return _upsidentupssoftwareversiontimestamp2; }
            set
            {
                _upsidentupssoftwareversiontimestamp2 = value;
                OnPropertyChanged(nameof(UpsIdentUPSSoftwareVersionTimestamp2));

            }
        }
        public string UpsSerialNumberTimestamp2
        {
            get { return _upsserialnumbertimestamp2; }
            set
            {
                _upsserialnumbertimestamp2 = value;
                OnPropertyChanged(nameof(UpsSerialNumberTimestamp2));
            }
        }
        public string UpsLocationTimestamp2
        {
            get { return _upslocationtimestamp2; }
            set
            {
                _upslocationtimestamp2 = value;
                OnPropertyChanged(nameof(UpsLocationTimestamp2));
            }
        }
        public string UpsEstimatedMinutesRemainingTimestamp2
        {
            get { return _upsestimatedminutesremainingtimestamp2; }
            set
            {
                _upsestimatedminutesremainingtimestamp2 = value;
                OnPropertyChanged(nameof(UpsEstimatedMinutesRemainingTimestamp2));
            }
        }
        public string UpsBatteryCurrentTimestamp2
        {
            get { return _upsbatterycurrenttimestamp2; }
            set
            {
                _upsbatterycurrenttimestamp2 = value;
                OnPropertyChanged(nameof(UpsBatteryCurrentTimestamp2));
            }
        }
        public string UpsBatteryTemperatureTimestamp2
        {
            get { return _upsbatterytemperaturetimestamp2; }
            set
            {
                _upsbatterytemperaturetimestamp2 = value;
                OnPropertyChanged(nameof(UpsBatteryTemperatureTimestamp2));
            }
        }
        public string UpsInputLineBadsTimestamp2
        {
            get { return _upsinputlinebadstimestamp2; }
            set
            {
                _upsinputlinebadstimestamp2 = value;
                OnPropertyChanged(nameof(UpsInputLineBadsTimestamp2));
            }
        }
        public string UpsInputFrequencyTimestamp2
        {
            get { return _upsinputfrequencytimestamp2; }
            set
            {
                _upsinputfrequencytimestamp2 = value;
                OnPropertyChanged(nameof(UpsInputFrequencyTimestamp2));
            }
        }
        public string UpsInputVoltageTimestamp2
        {
            get { return _upsinputvoltagetimestamp2; }
            set
            {
                _upsinputvoltagetimestamp2 = value;
                OnPropertyChanged(nameof(UpsInputVoltageTimestamp2));
            }
        }
        public string UpsInputCurrentTimestamp2
        {
            get { return _upsinputcurrenttimestamp2; }
            set
            {
                _upsinputcurrenttimestamp2 = value;
                OnPropertyChanged(nameof(UpsInputCurrentTimestamp2));
            }
        }
        public string UpsInputTruePowerTimestamp2
        {
            get { return _upsinputtruePowertimestamp2; }
            set
            {
                _upsinputtruePowertimestamp2 = value;
                OnPropertyChanged(nameof(UpsInputTruePowerTimestamp2));
            }
        }
        public string UpsOutputSourceTimestamp2
        {
            get { return _upsoutputsourcetimestamp2; }
            set
            {
                _upsoutputsourcetimestamp2 = value;
                OnPropertyChanged(nameof(UpsOutputSourceTimestamp2));
            }
        }
        public string UpsOutputFrequencyTimestamp2
        {
            get { return _upsoutputfrequencytimestamp2; }
            set
            {
                _upsoutputfrequencytimestamp2 = value;
                OnPropertyChanged(nameof(UpsOutputFrequencyTimestamp2));
            }
        }
        public string UpsOutputCurrentTimestamp2
        {
            get { return _upsoutputcurrenttimestamp2; }
            set
            {
                _upsoutputcurrenttimestamp2 = value;
                OnPropertyChanged(nameof(UpsOutputCurrentTimestamp2));
            }
        }
        public string UpsOutputPowerTimestamp2
        {
            get { return _upsoutputpowertimestamp2; }
            set
            {
                _upsoutputpowertimestamp2 = value;
                OnPropertyChanged(nameof(UpsOutputPowerTimestamp2));
            }
        }
        public string UpsBypassFrequencyTimestamp2
        {
            get { return _upsbypassfrequencytimestamp2; }
            set
            {
                _upsbypassfrequencytimestamp2 = value;
                OnPropertyChanged(nameof(UpsBypassFrequencyTimestamp2));
            }
        }
        public string UpsBypassNumLinesTimestamp2
        {
            get { return _upsbypassnumlinestimestamp2; }
            set
            {
                _upsbypassnumlinestimestamp2 = value;
                OnPropertyChanged(nameof(UpsBypassNumLinesTimestamp2));
            }
        }
        public string UpsBypassVoltageTimestamp2
        {
            get { return _upsbypassvoltagetimestamp2; }
            set
            {
                _upsbypassvoltagetimestamp2 = value;
                OnPropertyChanged(nameof(UpsBypassVoltageTimestamp2));
            }
        }
        public string UpsBypassCurrentTimestamp2
        {
            get { return _upsbypasscurrenttimestamp2; }
            set
            {
                _upsbypasscurrenttimestamp2 = value;
                OnPropertyChanged(nameof(UpsBypassCurrentTimestamp2));
            }
        }
        public string UpsBypassPowerTimestamp2
        {
            get { return _upsbypasspowertimestamp2; }
            set
            {
                _upsbypasspowertimestamp2 = value;
                OnPropertyChanged(nameof(UpsBypassPowerTimestamp2));
            }
        }
        #endregion
    }
}
