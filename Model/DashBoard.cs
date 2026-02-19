using LCPReportingSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace LCPReportingSystem.Model
{
    public partial class DashBoard : ViewModelBase
    {
        private string _userName = string.Empty;
        private string _password = string.Empty;
        private string _currentdatetime = string.Empty;
        private string _greetingmgs = string.Empty;
        private int _SubsystemId ;

        #region Main Group
        private string _mainsFreq = string.Empty;
        private string _mainsFreq2 = string.Empty;
        private string _mainsl1volts = string.Empty;
        private string _mainsl1volts2 = string.Empty;
        private string _mainsl2volts = string.Empty;
        private string _mainsl2volts2 = string.Empty;
        private string _mainsl3volts = string.Empty;
        private string _mainsl3volts2 = string.Empty;
        private string _mainsl1l2volts = string.Empty;
        private string _mainsl1l2volts2 = string.Empty;
        private string _mainsl2l3volts = string.Empty;
        private string _mainsl2l3volts2 = string.Empty;
        private string _mainsl3l1volts = string.Empty;
        private string _mainsl3l1volts2 = string.Empty;
        private string _mainsl1current = string.Empty;
        private string _mainsl1current2 = string.Empty;
        private string _mainsl2current = string.Empty;
        private string _mainsl2current2 = string.Empty;
        private string _mainsl3current = string.Empty;
        private string _mainsl3current2 = string.Empty;
        private string _mainsecurrent = string.Empty;
        private string _mainsecurrent2 = string.Empty;
        private string _mainsl1watts = string.Empty;
        private string _mainsl1watts2 = string.Empty;
        private string _mainsl2watts = string.Empty;
        private string _mainsl2watts2 = string.Empty;
        private string _mainsl3watts = string.Empty;
        private string _mainsl3watts2 = string.Empty;
        private string _mainsl1va = string.Empty;
        private string _mainsl1va2 = string.Empty;
        private string _mainsl2va = string.Empty;
        private string _mainsl2va2 = string.Empty;
        private string _mainsl3va = string.Empty;
        private string _mainsl3va2 = string.Empty;
        private string _mainstotalva = string.Empty;
        private string _mainstotalva2 = string.Empty;
        private string _mainspowerfactorl1 = string.Empty;
        private string _mainspowerfactorl1_2 = string.Empty;
        private string _mainspowerfactorl2 = string.Empty;
        private string _mainspowerfactorl2_2 = string.Empty;
        private string _mainspowerfactorl3 = string.Empty;
        private string _mainspowerfactorl3_2 = string.Empty;
        private string _mainsavgpowerfactor = string.Empty;
        private string _mainsavgpowerfactor_2 = string.Empty;
        private string _mainsphasel1 = string.Empty;
        private string _mainsphasel1_2 = string.Empty;
        private string _mainsphasel2 = string.Empty;
        private string _mainsphasel2_2 = string.Empty;
        private string _mainsphasel3 = string.Empty;
        private string _mainsphasel3_2 = string.Empty;
        private string _mainsphasetotal = string.Empty;
        private string _mainsphasetotal_2 = string.Empty;
        private string _mainsvoltllavg = string.Empty;
        private string _mainsvoltllavg_2 = string.Empty;
        private string _mainsvoltlldiff = string.Empty;
        private string _mainsvoltlldiff_2 = string.Empty;
        private string _mainsvoltllmin = string.Empty;
        private string _mainsvoltllmin_2 = string.Empty;
        private string _mainsvoltllmax = string.Empty;
        private string _mainsvoltllmax_2 = string.Empty;




        private string _mainsfreqindicator = string.Empty;
        private string _mainsl1voltsindicator = string.Empty;
        private string _mainsl2voltsindicator = string.Empty;
        private string _mainsl3voltsindicator = string.Empty;
        private string _mainsl1l2voltsindicator = string.Empty;
        private string _mainsl2l3voltsindicator = string.Empty;
        private string _mainsl3l1voltsindicator = string.Empty;
        private string _mainsl1currentindicator = string.Empty;
        private string _mainsl2currentindicator = string.Empty;
        private string _mainsl3currentindicator = string.Empty;
        private string _mainsecurrentindicator = string.Empty;
        private string _mainsl1wattsindicator = string.Empty;
        private string _mainsl2wattsindicator = string.Empty;
        private string _mainsl3wattsindicator = string.Empty;
        private string _mainsl1vaindicator = string.Empty;
        private string _mainsl2vaindicator = string.Empty;
        private string _mainsl3vaindicator = string.Empty;
        private string _mainstotalvaindicator = string.Empty;
        private string _mainspowerfactorl1indicator = string.Empty;
        private string _mainspowerfactorl2indicator = string.Empty;
        private string _mainspowerfactorl3indicator = string.Empty;
        private string _mainsavgpowerfactorindicator = string.Empty;
        private string _mainsphasel1indicator = string.Empty;
        private string _mainsphasel2indicator = string.Empty;
        private string _mainsphasel3indicator = string.Empty;
        private string _mainsphasetotalindicator = string.Empty;
        private string _mainsvoltllavgindicator = string.Empty;
        private string _mainsvoltlldiffindicator = string.Empty;
        private string _mainsvoltllminindicator = string.Empty;
        private string _mainsvoltllmaxindicator = string.Empty;

        private string _mainsfreqindicator2 = string.Empty;
        private string _mainsl1voltsindicator2 = string.Empty;
        private string _mainsl2voltsindicator2 = string.Empty;
        private string _mainsl3voltsindicator2 = string.Empty;
        private string _mainsl1l2voltsindicator2 = string.Empty;
        private string _mainsl2l3voltsindicator2 = string.Empty;
        private string _mainsl3l1voltsindicator2 = string.Empty;
        private string _mainsl1currentindicator2 = string.Empty;
        private string _mainsl2currentindicator2 = string.Empty;
        private string _mainsl3currentindicator2 = string.Empty;
        private string _mainsecurrentindicator2 = string.Empty;
        private string _mainsl1wattsindicator2 = string.Empty;
        private string _mainsl2wattsindicator2 = string.Empty;
        private string _mainsl3wattsindicator2 = string.Empty;
        private string _mainsl1vaindicator2 = string.Empty;
        private string _mainsl2vaindicator2 = string.Empty;
        private string _mainsl3vaindicator2 = string.Empty;
        private string _mainstotalvaindicator2 = string.Empty;
        private string _mainspowerfactorl1indicator2 = string.Empty;
        private string _mainspowerfactorl2indicator2 = string.Empty;
        private string _mainspowerfactorl3indicator2 = string.Empty;
        private string _mainsavgpowerfactorindicator2 = string.Empty;
        private string _mainsphasel1indicator2 = string.Empty;
        private string _mainsphasel2indicator2 = string.Empty;
        private string _mainsphasel3indicator2 = string.Empty;
        private string _mainsphasetotalindicator2 = string.Empty;
        private string _mainsvoltllavgindicator2 = string.Empty;
        private string _mainsvoltlldiffindicator2 = string.Empty;
        private string _mainsvoltllminindicator2 = string.Empty;
        private string _mainsvoltllmaxindicator2 = string.Empty;

        private string _mainsfreqtimestamp = string.Empty;
        private string _mainsl1voltstimestamp = string.Empty;
        private string _mainsl2voltstimestamp = string.Empty;
        private string _mainsl3voltstimestamp = string.Empty;
        private string _mainsl1l2voltstimestamp = string.Empty;
        private string _mainsl2l3voltstimestamp = string.Empty;
        private string _mainsl3l1voltstimestamp = string.Empty;
        private string _mainsl1currenttimestamp = string.Empty;
        private string _mainsl2currenttimestamp = string.Empty;
        private string _mainsl3currenttimestamp = string.Empty;
        private string _mainsecurrenttimestamp = string.Empty;
        private string _mainsl1wattstimestamp = string.Empty;
        private string _mainsl2wattstimestamp = string.Empty;
        private string _mainsl3wattstimestamp = string.Empty;
        private string _mainsl1vatimestamp = string.Empty;
        private string _mainsl2vatimestamp = string.Empty;
        private string _mainsl3vatimestamp = string.Empty;
        private string _mainstotalvatimestamp = string.Empty;
        private string _mainspowerfactorl1timestamp = string.Empty;
        private string _mainspowerfactorl2timestamp = string.Empty;
        private string _mainspowerfactorl3timestamp = string.Empty;
        private string _mainsavgpowerfactortimestamp = string.Empty;
        private string _mainsphasel1timestamp = string.Empty;
        private string _mainsphasel2timestamp = string.Empty;
        private string _mainsphasel3timestamp = string.Empty;
        private string _mainsphasetotaltimestamp = string.Empty;
        private string _mainsvoltllavgtimestamp = string.Empty;
        private string _mainsvoltlldifftimestamp = string.Empty;
        private string _mainsvoltllmintimestamp = string.Empty;
        private string _mainsvoltllmaxtimestamp = string.Empty;

        private string _mainsfreqtimestamp2 = string.Empty;
        private string _mainsl1voltstimestamp2 = string.Empty;
        private string _mainsl2voltstimestamp2 = string.Empty;
        private string _mainsl3voltstimestamp2 = string.Empty;
        private string _mainsl1l2voltstimestamp2 = string.Empty;
        private string _mainsl2l3voltstimestamp2 = string.Empty;
        private string _mainsl3l1voltstimestamp2 = string.Empty;
        private string _mainsl1currenttimestamp2 = string.Empty;
        private string _mainsl2currenttimestamp2 = string.Empty;
        private string _mainsl3currenttimestamp2 = string.Empty;
        private string _mainsecurrenttimestamp2 = string.Empty;
        private string _mainsl1wattstimestamp2 = string.Empty;
        private string _mainsl2wattstimestamp2 = string.Empty;
        private string _mainsl3wattstimestamp2 = string.Empty;
        private string _mainsl1vatimestamp2 = string.Empty;
        private string _mainsl2vatimestamp2 = string.Empty;
        private string _mainsl3vatimestamp2 = string.Empty;
        private string _mainstotalvatimestamp2 = string.Empty;
        private string _mainspowerfactorl1timestamp2 = string.Empty;
        private string _mainspowerfactorl2timestamp2 = string.Empty;
        private string _mainspowerfactorl3timestamp2 = string.Empty;
        private string _mainsavgpowerfactortimestamp2 = string.Empty;
        private string _mainsphasel1timestamp2 = string.Empty;
        private string _mainsphasel2timestamp2 = string.Empty;
        private string _mainsphasel3timestamp2 = string.Empty;
        private string _mainsphasetotaltimestamp2 = string.Empty;
        private string _mainsvoltllavgtimestamp2 = string.Empty;
        private string _mainsvoltlldifftimestamp2 = string.Empty;
        private string _mainsvoltllmintimestamp2 = string.Empty;
        private string _mainsvoltllmaxtimestamp2 = string.Empty;

        #endregion

        #region Generator Group

        private string _genfreq = string.Empty;
        private string _genfreq2 = string.Empty;
        private string _genl3volts = string.Empty;
        private string _genl3volts2 = string.Empty;
        private string _genl1l2volts = string.Empty;
        private string _genl1l2volts2 = string.Empty;
        private string _genl2l3volts = string.Empty;
        private string _genl2l3volts2 = string.Empty;
        private string _genl3l1volts = string.Empty;
        private string _genl3l1volts2 = string.Empty;
        private string _genl3current = string.Empty;
        private string _genl3current2 = string.Empty;
        private string _genecurrent = string.Empty;
        private string _genecurrent2 = string.Empty;
        private string _genl3watts = string.Empty;
        private string _genl3watts2 = string.Empty;
        private string _genwattstotal = string.Empty;
        private string _genwattstotal2 = string.Empty;
        private string _gentotalva = string.Empty;
        private string _gentotalva2 = string.Empty;
        private string _genavgpowerfactor = string.Empty;
        private string _genavgpowerfactor2 = string.Empty;
        private string _genl1current = string.Empty;
        private string _genl1current2 = string.Empty;
        private string _genl2current = string.Empty;
        private string _genl2current2 = string.Empty;
        private string _genl1va = string.Empty;
        private string _genl1va2 = string.Empty;
        private string _genl2va = string.Empty;
        private string _genl2va2 = string.Empty;
        private string _genl3va = string.Empty;
        private string _genl3va2 = string.Empty;
        private string _genpowerfactorl1 = string.Empty;
        private string _genpowerfactorl1_2 = string.Empty;
        private string _genpowerfactorl2 = string.Empty;
        private string _genpowerfactorl2_2 = string.Empty;
        private string _genpowerfactorl3 = string.Empty;
        private string _genpowerfactorl3_2 = string.Empty;
        private string _genphase1 = string.Empty;
        private string _genphase1_2 = string.Empty;
        private string _genphase2 = string.Empty;
        private string _genphase2_2 = string.Empty;
        private string _genphase3 = string.Empty;
        private string _genphase3_2 = string.Empty;
        private string _genphasetotal = string.Empty;
        private string _genphasetotal2 = string.Empty;
        private string _genvoltllavg = string.Empty;
        private string _genvoltllavg2 = string.Empty;
        private string _genvoltlldiff = string.Empty;
        private string _genvoltlldiff2 = string.Empty;
        private string _genvoltllmin = string.Empty;
        private string _genvoltllmin2 = string.Empty;
        private string _genvoltllmax = string.Empty;
        private string _genvoltllmax2 = string.Empty;
        private string _genrotation = string.Empty;
        private string _genrotation2 = string.Empty;
        private string _gencurrentave = string.Empty;
        private string _gencurrentave2 = string.Empty;
        private string _gencurrentdiff = string.Empty;
        private string _gencurrentdiff2 = string.Empty;


        private string _genfreqindicator = string.Empty;
        private string _genl3voltsindicator = string.Empty;
        private string _genl1l2voltsindicator = string.Empty;
        private string _genl2l3voltsindicator = string.Empty;
        private string _genl3l1voltsindicator = string.Empty;
        private string _genl3currentindicator = string.Empty;
        private string _genecurrentindicator = string.Empty;
        private string _genl3wattsindicator = string.Empty;
        private string _genwattstotalindicator = string.Empty;
        private string _gentotalvaindicator = string.Empty;
        private string _genavgpowerfactorindicator = string.Empty;
        private string _genl1currentindicator = string.Empty;
        private string _genl2currentindicator = string.Empty;
        private string _genl1vaindicator = string.Empty;
        private string _genl2vaindicator = string.Empty;
        private string _genl3vaindicator = string.Empty;
        private string _genpowerfactorl1indicator = string.Empty;
        private string _genpowerfactorl2indicator = string.Empty;
        private string _genpowerfactorl3indicator = string.Empty;
        private string _genphase1indicator = string.Empty;
        private string _genphase2indicator = string.Empty;
        private string _genphase3indicator = string.Empty;
        private string _genphasetotalindicator = string.Empty;
        private string _genvoltllavgindicator = string.Empty;
        private string _genvoltlldiffindicator = string.Empty;
        private string _genvoltllminindicator = string.Empty;
        private string _genvoltllmaxindicator = string.Empty;
        private string _genrotationindicator = string.Empty;
        private string _gencurrentaveindicator = string.Empty;
        private string _gencurrentdiffindicator = string.Empty;

        private string _genfreqindicator2 = string.Empty;
        private string _genl3voltsindicator2 = string.Empty;
        private string _genl1l2voltsindicator2 = string.Empty;
        private string _genl2l3voltsindicator2 = string.Empty;
        private string _genl3l1voltsindicator2 = string.Empty;
        private string _genl3currentindicator2 = string.Empty;
        private string _genecurrentindicator2 = string.Empty;
        private string _genl3wattsindicator2 = string.Empty;
        private string _genwattstotalindicator2 = string.Empty;
        private string _gentotalvaindicator2 = string.Empty;
        private string _genavgpowerfactorindicator2 = string.Empty;
        private string _genl1currentindicator2 = string.Empty;
        private string _genl2currentindicator2 = string.Empty;
        private string _genl1vaindicator2 = string.Empty;
        private string _genl2vaindicator2 = string.Empty;
        private string _genl3vaindicator2 = string.Empty;
        private string _genpowerfactorl1indicator2 = string.Empty;
        private string _genpowerfactorl2indicator2 = string.Empty;
        private string _genpowerfactorl3indicator2 = string.Empty;
        private string _genphase1indicator2 = string.Empty;
        private string _genphase2indicator2 = string.Empty;
        private string _genphase3indicator2 = string.Empty;
        private string _genphasetotalindicator2 = string.Empty;
        private string _genvoltllavgindicator2 = string.Empty;
        private string _genvoltlldiffindicator2 = string.Empty;
        private string _genvoltllminindicator2 = string.Empty;
        private string _genvoltllmaxindicator2 = string.Empty;
        private string _genrotationindicator2 = string.Empty;
        private string _gencurrentaveindicator2 = string.Empty;
        private string _gencurrentdiffindicator2 = string.Empty;

        private string _genfreqtimestamp = string.Empty;
        private string _genl3voltstimestamp = string.Empty;
        private string _genl1l2voltstimestamp = string.Empty;
        private string _genl2l3voltstimestamp = string.Empty;
        private string _genl3l1voltstimestamp = string.Empty;
        private string _genl3currenttimestamp = string.Empty;
        private string _genecurrenttimestamp = string.Empty;
        private string _genl3wattstimestamp = string.Empty;
        private string _genwattstotaltimestamp = string.Empty;
        private string _gentotalvatimestamp = string.Empty;
        private string _genavgpowerfactortimestamp = string.Empty;
        private string _genl1currenttimestamp = string.Empty;
        private string _genl2currenttimestamp = string.Empty;
        private string _genl1vatimestamp = string.Empty;
        private string _genl2vatimestamp = string.Empty;
        private string _genl3vatimestamp = string.Empty;
        private string _genpowerfactorl1timestamp = string.Empty;
        private string _genpowerfactorl2timestamp = string.Empty;
        private string _genpowerfactorl3timestamp = string.Empty;
        private string _genphase1timestamp = string.Empty;
        private string _genphase2timestamp = string.Empty;
        private string _genphase3timestamp = string.Empty;
        private string _genphasetotaltimestamp = string.Empty;
        private string _genvoltllavgtimestamp = string.Empty;
        private string _genvoltlldifftimestamp = string.Empty;
        private string _genvoltllmintimestamp = string.Empty;
        private string _genvoltllmaxtimestamp = string.Empty;
        private string _genrotationtimestamp = string.Empty;
        private string _gencurrentavetimestamp = string.Empty;
        private string _gencurrentdifftimestamp = string.Empty;

        private string _genfreqtimestamp2 = string.Empty;
        private string _genl3voltstimestamp2 = string.Empty;
        private string _genl1l2voltstimestamp2 = string.Empty;
        private string _genl2l3voltstimestamp2 = string.Empty;
        private string _genl3l1voltstimestamp2 = string.Empty;
        private string _genl3currenttimestamp2 = string.Empty;
        private string _genecurrenttimestamp2 = string.Empty;
        private string _genl3wattstimestamp2 = string.Empty;
        private string _genwattstotaltimestamp2 = string.Empty;
        private string _gentotalvatimestamp2 = string.Empty;
        private string _genavgpowerfactortimestamp2 = string.Empty;
        private string _genl1currenttimestamp2 = string.Empty;
        private string _genl2currenttimestamp2 = string.Empty;
        private string _genl1vatimestamp2 = string.Empty;
        private string _genl2vatimestamp2 = string.Empty;
        private string _genl3vatimestamp2 = string.Empty;
        private string _genpowerfactorl1timestamp2 = string.Empty;
        private string _genpowerfactorl2timestamp2 = string.Empty;
        private string _genpowerfactorl3timestamp2 = string.Empty;
        private string _genphase1timestamp2 = string.Empty;
        private string _genphase2timestamp2 = string.Empty;
        private string _genphase3timestamp2 = string.Empty;
        private string _genphasetotaltimestamp2 = string.Empty;
        private string _genvoltllavgtimestamp2 = string.Empty;
        private string _genvoltlldifftimestamp2 = string.Empty;
        private string _genvoltllmintimestamp2 = string.Empty;
        private string _genvoltllmaxtimestamp2 = string.Empty;
        private string _genrotationtimestamp2 = string.Empty;
        private string _gencurrentavetimestamp2 = string.Empty;
        private string _gencurrentdifftimestamp2 = string.Empty;
        #endregion

        #region Engine Group

        private string _engoilpress = string.Empty;
        private string _engoilpress2 = string.Empty;
        private string _engtemp = string.Empty;
        private string _engtemp2 = string.Empty;
        private string _engoiltemp = string.Empty;
        private string _engoiltemp2 = string.Empty;
        private string _engfuellevel = string.Empty;
        private string _engfuellevel2 = string.Empty;
        private string _engchargealtvolts = string.Empty;
        private string _engchargealtvolts2 = string.Empty;
        private string _engbatteryvolts = string.Empty;
        private string _engbatteryvolts2 = string.Empty;
        private string _engmodhours = string.Empty;
        private string _engmodhours2 = string.Empty;
        private string _engspeeddisplay = string.Empty;
        private string _engspeeddisplay2 = string.Empty;
        private string _engcoolantp1 = string.Empty;
        private string _engcoolantp1_2 = string.Empty;
        private string _engcoolantp2 = string.Empty;
        private string _engcoolantp2_2 = string.Empty;
        private string _engturbop1 = string.Empty;
        private string _engturbop1_2 = string.Empty;
        private string _engturbop2 = string.Empty;
        private string _engturbop2_2 = string.Empty;
        private string _engexhaustt1 = string.Empty;
        private string _engexhaustt1_2 = string.Empty;
        private string _engexhaustt2 = string.Empty;
        private string _engexhaustt2_2 = string.Empty;
        private string _engfuelconsumption = string.Empty;
        private string _engfuelconsumption2 = string.Empty;
        private string _engoillevel = string.Empty;
        private string _engoillevel2 = string.Empty;
        private string _engcoolentlevel = string.Empty;
        private string _engcoolentlevel2 = string.Empty;
        private string _engfanspeed = string.Empty;
        private string _engfanspeed2 = string.Empty;
        private string _engturbooiltemp = string.Empty;
        private string _engturbooiltemp2 = string.Empty;
        private string _engoperatingstage = string.Empty;
        private string _engoperatingstage2 = string.Empty;
        private string _engmodspeedfeed = string.Empty;
        private string _engmodspeedfeed2 = string.Empty;
        private string _engmodfreqadj = string.Empty;
        private string _engmodfreqadj2 = string.Empty;
        private string _engbattcurrent = string.Empty;
        private string _engbattcurrent2 = string.Empty;
        private string _engchargepotential = string.Empty;
        private string _engchargepotential2 = string.Empty;
        private string _engdemandedspeed = string.Empty;
        private string _engdemandedspeed2 = string.Empty;
        private string _engfuelrate = string.Empty;
        private string _engfuelrate2 = string.Empty;

        private string _engoilpressindicator = string.Empty;
        private string _engtempindicator = string.Empty;
        private string _engoiltempindicator = string.Empty;
        private string _engfuellevelindicator = string.Empty;
        private string _engchargealtvoltsindicator = string.Empty;
        private string _engbatteryvoltsindicator = string.Empty;
        private string _engmodhoursindicator = string.Empty;
        private string _engspeeddisplayindicator = string.Empty;
        private string _engcoolantp1indicator = string.Empty;
        private string _engcoolantp2indicator = string.Empty;
        private string _engturbop1indicator = string.Empty;
        private string _engturbop2indicator = string.Empty;
        private string _engexhaustt1indicator = string.Empty;
        private string _engexhaustt2indicator = string.Empty;
        private string _engfuelconsumptionindicator = string.Empty;
        private string _engoillevelindicator = string.Empty;
        private string _engcoolentlevelindicator = string.Empty;
        private string _engfanspeedindicator = string.Empty;
        private string _engturbooiltempindicator = string.Empty;
        private string _engoperatingstageindicator = string.Empty;
        private string _engmodspeedfeedindicator = string.Empty;
        private string _engmodfreqadjindicator = string.Empty;
        private string _engbattcurrentindicator = string.Empty;
        private string _engchargepotentialindicator = string.Empty;
        private string _engdemandedspeedindicator = string.Empty;
        private string _engfuelrateindicator = string.Empty;

        private string _engoilpressindicator2 = string.Empty;
        private string _engtempindicator2 = string.Empty;
        private string _engoiltempindicator2 = string.Empty;
        private string _engfuellevelindicator2 = string.Empty;
        private string _engchargealtvoltsindicator2 = string.Empty;
        private string _engbatteryvoltsindicator2 = string.Empty;
        private string _engmodhoursindicator2 = string.Empty;
        private string _engspeeddisplayindicator2 = string.Empty;
        private string _engcoolantp1indicator2 = string.Empty;
        private string _engcoolantp2indicator2 = string.Empty;
        private string _engturbop1indicator2 = string.Empty;
        private string _engturbop2indicator2 = string.Empty;
        private string _engexhaustt1indicator2 = string.Empty;
        private string _engexhaustt2indicator2 = string.Empty;
        private string _engfuelconsumptionindicator2 = string.Empty;
        private string _engoillevelindicator2 = string.Empty;
        private string _engcoolentlevelindicator2 = string.Empty;
        private string _engfanspeedindicator2 = string.Empty;
        private string _engturbooiltempindicator2 = string.Empty;
        private string _engoperatingstageindicator2 = string.Empty;
        private string _engmodspeedfeedindicator2 = string.Empty;
        private string _engmodfreqadjindicator2 = string.Empty;
        private string _engbattcurrentindicator2 = string.Empty;
        private string _engchargepotentialindicator2 = string.Empty;
        private string _engdemandedspeedindicator2 = string.Empty;
        private string _engfuelrateindicator2 = string.Empty;

        private string _engoilpresstimestamp = string.Empty;
        private string _engtemptimestamp = string.Empty;
        private string _engoiltemptimestamp = string.Empty;
        private string _engfuelleveltimestamp = string.Empty;
        private string _engchargealtvoltstimestamp = string.Empty;
        private string _engbatteryvoltstimestamp = string.Empty;
        private string _engmodhourstimestamp = string.Empty;
        private string _engspeeddisplaytimestamp = string.Empty;
        private string _engcoolantp1timestamp = string.Empty;
        private string _engcoolantp2timestamp = string.Empty;
        private string _engturbop1timestamp = string.Empty;
        private string _engturbop2timestamp = string.Empty;
        private string _engexhaustt1timestamp = string.Empty;
        private string _engexhaustt2timestamp = string.Empty;
        private string _engfuelconsumptiontimestamp = string.Empty;
        private string _engoilleveltimestamp = string.Empty;
        private string _engcoolentleveltimestamp = string.Empty;
        private string _engfanspeedtimestamp = string.Empty;
        private string _engturbooiltemptimestamp = string.Empty;
        private string _engoperatingstagetimestamp = string.Empty;
        private string _engmodspeedfeedtimestamp = string.Empty;
        private string _engmodfreqadjtimestamp = string.Empty;
        private string _engbattcurrenttimestamp = string.Empty;
        private string _engchargepotentialtimestamp = string.Empty;
        private string _engdemandedspeedtimestamp = string.Empty;
        private string _engfuelratetimestamp = string.Empty;

        private string _engoilpresstimestamp2 = string.Empty;
        private string _engtemptimestamp2 = string.Empty;
        private string _engoiltemptimestamp2 = string.Empty;
        private string _engfuelleveltimestamp2 = string.Empty;
        private string _engchargealtvoltstimestamp2 = string.Empty;
        private string _engbatteryvoltstimestamp2 = string.Empty;
        private string _engmodhourstimestamp2 = string.Empty;
        private string _engspeeddisplaytimestamp2 = string.Empty;
        private string _engcoolantp1timestamp2 = string.Empty;
        private string _engcoolantp2timestamp2 = string.Empty;
        private string _engturbop1timestamp2 = string.Empty;
        private string _engturbop2timestamp2 = string.Empty;
        private string _engexhaustt1timestamp2 = string.Empty;
        private string _engexhaustt2timestamp2 = string.Empty;
        private string _engfuelconsumptiontimestamp2 = string.Empty;
        private string _engoilleveltimestamp2 = string.Empty;
        private string _engcoolentleveltimestamp2 = string.Empty;
        private string _engfanspeedtimestamp2 = string.Empty;
        private string _engturbooiltemptimestamp2 = string.Empty;
        private string _engoperatingstagetimestamp2 = string.Empty;
        private string _engmodspeedfeedtimestamp2 = string.Empty;
        private string _engmodfreqadjtimestamp2 = string.Empty;
        private string _engbattcurrenttimestamp2 = string.Empty;
        private string _engchargepotentialtimestamp2 = string.Empty;
        private string _engdemandedspeedtimestamp2 = string.Empty;
        private string _engfuelratetimestamp2 = string.Empty;

        #endregion

        private string _subsystemip = string.Empty;
        private string _prametername = string.Empty;
        private string _Unitname = string.Empty;
        private string _prametervalue = string.Empty;
        private string _timestamp = string.Empty;

        private bool _isleftslidershow;
        private bool _isdashbordscreenenable;
        private bool _isconfigurationenable;
        private bool _ismanagearchiveenable;
        private bool _islinegraphenable;
        private bool _isReport;
        private bool _ismanageuserenable;
        private bool? _isnavigationenable;
        private bool? _issubsystemspanelone;
        private bool? _issubsystemspaneltwo;
        private bool? _issubsystemspanelthree;
        private bool? _issubsystemspanelfour;

        private bool? _ismanageusertabenable;
        private bool _isDgNonTrapParametersVisible;

        private double _stackPanelHeight;
 


        public double StackPanelHeight
        {
            get => _stackPanelHeight;
            set
            {
                if (_stackPanelHeight != value)
                {
                    _stackPanelHeight = value;
                    OnPropertyChanged(nameof(StackPanelHeight));
                }
            }
        }
        public bool IsDgNonTrapParametersVisible
        {
            get => _isDgNonTrapParametersVisible;
            set
            {
                _isDgNonTrapParametersVisible = value;
                OnPropertyChanged(nameof(IsDgNonTrapParametersVisible));
            }
        }

        //private ObservableCollection<TrapInfo> _dgtrapcollection = new ObservableCollection<TrapInfo>();
        //private ObservableCollection<TrapInfo> _routertrapcollection = new ObservableCollection<TrapInfo>();
        //private ObservableCollection<TrapInfo> _radiotrapcollection = new ObservableCollection<TrapInfo>();
        //private ObservableCollection<TrapInfo> _switchtrapcollection = new ObservableCollection<TrapInfo>();
        //private ObservableCollection<TrapInfo> _upstrapcollection = new ObservableCollection<TrapInfo>();
        private CollectionView _dgtrapcollection;
        private CollectionView _routertrapcollection;
        private CollectionView _radiotrapcollection;
        private CollectionView _switchtrapcollection;
        private CollectionView _upstrapcollection;

        private CollectionView _dgtrapcollection2;
        private CollectionView _routertrapcollection2;
        private CollectionView _radiotrapcollection2;
        private CollectionView _switchtrapcollection2;
        private CollectionView _upstrapcollection2;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public int  SubsystemId
        {
            get { return _SubsystemId; }
            set
            {
                _SubsystemId = value;
                OnPropertyChanged(nameof(SubsystemId));
            }
        }

        public string Currentdatetime
        {
            get { return _currentdatetime; }
            set
            {
                _currentdatetime = value;
                OnPropertyChanged(nameof(Currentdatetime));
            }
        }
        public string GreetingMessage
        {
            get { return _greetingmgs; }
            set
            {
                _greetingmgs = value;
                OnPropertyChanged(nameof(GreetingMessage));
            }
        }

        #region Main Group Property
        public string MainsFreq_Hz
        {
            get { return _mainsFreq; }
            set
            {
                _mainsFreq = value;
                OnPropertyChanged(nameof(MainsFreq_Hz));
            }
        }
        public string MainsFreq_Hz2
        {
            get { return _mainsFreq2; }
            set
            {
                _mainsFreq2 = value;
                OnPropertyChanged(nameof(MainsFreq_Hz2));
            }
        }
        public string MainsL1volts
        {
            get { return _mainsl1volts; }
            set
            {
                _mainsl1volts = value;
                OnPropertyChanged(nameof(MainsL1volts));
            }
        } 
        public string MainsL1volts2
        {
            get { return _mainsl1volts2; }
            set
            {
                _mainsl1volts2 = value;
                OnPropertyChanged(nameof(MainsL1volts2));
            }
        }
        public string MainsL2Volts
        {
            get { return _mainsl2volts; }
            set
            {
                _mainsl2volts = value;
                OnPropertyChanged(nameof(MainsL2Volts));
            }
        } 
        public string MainsL2Volts2
        {
            get { return _mainsl2volts2; }
            set
            {
                _mainsl2volts2 = value;
                OnPropertyChanged(nameof(MainsL2Volts2));
            }
        }
        public string MainsL3Volts
        {
            get { return _mainsl3volts; }
            set
            {
                _mainsl3volts = value;
                OnPropertyChanged(nameof(MainsL3Volts));
            }
        }
        public string MainsL3Volts2
        {
            get { return _mainsl3volts2; }
            set
            {
                _mainsl3volts2 = value;
                OnPropertyChanged(nameof(MainsL3Volts2));
            }
        }
        public string MainsL1L2Volts
        {
            get { return _mainsl1l2volts; }
            set
            {
                _mainsl1l2volts = value;
                OnPropertyChanged(nameof(MainsL1L2Volts));
            }
        }
        public string MainsL1L2Volts2
        {
            get { return _mainsl1l2volts2; }
            set
            {
                _mainsl1l2volts2 = value;
                OnPropertyChanged(nameof(MainsL1L2Volts2));
            }
        }
        public string MainsL2L3Volts
        {
            get { return _mainsl2l3volts; }
            set
            {
                _mainsl2l3volts = value;
                OnPropertyChanged(nameof(MainsL2L3Volts));
            }
        }  
        public string MainsL2L3Volts2
        {
            get { return _mainsl2l3volts2; }
            set
            {
                _mainsl2l3volts2 = value;
                OnPropertyChanged(nameof(MainsL2L3Volts2));
            }
        }
        public string MainsL3L1Volts
        {
            get { return _mainsl3l1volts; }
            set
            {
                _mainsl3l1volts = value;
                OnPropertyChanged(nameof(MainsL3L1Volts));
            }
        } 
        public string MainsL3L1Volts2
        {
            get { return _mainsl3l1volts2; }
            set
            {
                _mainsl3l1volts2 = value;
                OnPropertyChanged(nameof(MainsL3L1Volts2));
            }
        }
        public string MainsL1Current
        {
            get { return _mainsl1current; }
            set
            {
                _mainsl1current = value;
                OnPropertyChanged(nameof(MainsL1Current));
            }
        } 
        public string MainsL1Current2
        {
            get { return _mainsl1current2; }
            set
            {
                _mainsl1current2 = value;
                OnPropertyChanged(nameof(MainsL1Current2));
            }
        }
        public string MainsL2Current
        {
            get { return _mainsl2current; }
            set
            {
                _mainsl2current = value;
                OnPropertyChanged(nameof(MainsL2Current));
            }
        } 
        public string MainsL2Current2
        {
            get { return _mainsl2current2; }
            set
            {
                _mainsl2current2 = value;
                OnPropertyChanged(nameof(MainsL2Current2));
            }
        }
        public string MainsL3Current
        {
            get { return _mainsl3current; }
            set
            {
                _mainsl3current = value;
                OnPropertyChanged(nameof(MainsL3Current));
            }
        } 
        public string MainsL3Current2
        {
            get { return _mainsl3current2; }
            set
            {
                _mainsl3current2 = value;
                OnPropertyChanged(nameof(MainsL3Current2));
            }
        }
        public string MainseCurrent
        {
            get { return _mainsecurrent; }
            set
            {
                _mainsecurrent = value;
                OnPropertyChanged(nameof(MainseCurrent));
            }
        }  
        public string MainseCurrent2
        {
            get { return _mainsecurrent2; }
            set
            {
                _mainsecurrent2 = value;
                OnPropertyChanged(nameof(MainseCurrent2));
            }
        }
        public string MainsL1Watts
        {
            get { return _mainsl1watts; }
            set
            {
                _mainsl1watts = value;
                OnPropertyChanged(nameof(MainsL1Watts));
            }
        } 
        public string MainsL1Watts2
        {
            get { return _mainsl1watts2; }
            set
            {
                _mainsl1watts2 = value;
                OnPropertyChanged(nameof(MainsL1Watts2));
            }
        }
        public string MainsL2Watts
        {
            get { return _mainsl2watts; }
            set
            {
                _mainsl2watts = value;
                OnPropertyChanged(nameof(MainsL2Watts));
            }
        } 
        public string MainsL2Watts2
        {
            get { return _mainsl2watts2; }
            set
            {
                _mainsl2watts2 = value;
                OnPropertyChanged(nameof(MainsL2Watts2));
            }
        }
        public string MainsL3Watts
        {
            get { return _mainsl3watts; }
            set
            {
                _mainsl3watts = value;
                OnPropertyChanged(nameof(MainsL3Watts));
            }
        }
        public string MainsL3Watts2
        {
            get { return _mainsl3watts2; }
            set
            {
                _mainsl3watts2 = value;
                OnPropertyChanged(nameof(MainsL3Watts2));
            }
        }
        public string MainsL1VA
        {
            get { return _mainsl1va; }
            set
            {
                _mainsl1va = value;
                OnPropertyChanged(nameof(MainsL1VA));
            }
        }
        public string MainsL1VA2
        {
            get { return _mainsl1va2; }
            set
            {
                _mainsl1va2 = value;
                OnPropertyChanged(nameof(MainsL1VA2));
            }
        }
        public string MainsL2VA
        {
            get { return _mainsl2va; }
            set
            {
                _mainsl2va = value;
                OnPropertyChanged(nameof(MainsL2VA));
            }
        }
        public string MainsL2VA2
        {
            get { return _mainsl2va2; }
            set
            {
                _mainsl2va2 = value;
                OnPropertyChanged(nameof(MainsL2VA2));
            }
        }
        public string MainsL3VA
        {
            get { return _mainsl3va; }
            set
            {
                _mainsl3va = value;
                OnPropertyChanged(nameof(MainsL3VA));
            }
        } 
        public string MainsL3VA2
        {
            get { return _mainsl3va2; }
            set
            {
                _mainsl3va2 = value;
                OnPropertyChanged(nameof(MainsL3VA2));
            }
        }
        public string MainsTotalVA
        {
            get { return _mainstotalva; }
            set
            {
                _mainstotalva = value;
                OnPropertyChanged(nameof(MainsTotalVA));
            }
        }
        public string MainsTotalVA2
        {
            get { return _mainstotalva2; }
            set
            {
                _mainstotalva2 = value;
                OnPropertyChanged(nameof(MainsTotalVA2));
            }
        }
        public string MainsPowerFactorL1
        {
            get { return _mainspowerfactorl1; }
            set
            {
                _mainspowerfactorl1 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1));
            }
        }
        public string MainsPowerFactorL1_2
        {
            get { return _mainspowerfactorl1_2; }
            set
            {
                _mainspowerfactorl1_2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1_2));
            }
        }
        public string MainsPowerFactorL2
        {
            get { return _mainspowerfactorl2; }
            set
            {
                _mainspowerfactorl2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2));
            }
        }
        public string MainsPowerFactorL2_2
        {
            get { return _mainspowerfactorl2_2; }
            set
            {
                _mainspowerfactorl2_2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2_2));
            }
        }
        public string MainsPowerFactorL3
        {
            get { return _mainspowerfactorl3; }
            set
            {
                _mainspowerfactorl3 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3));
            }
        }
        public string MainsPowerFactorL3_2
        {
            get { return _mainspowerfactorl3_2; }
            set
            {
                _mainspowerfactorl3_2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3_2));
            }
        }
        public string MainsAVGPowerFactor
        {
            get { return _mainsavgpowerfactor; }
            set
            {
                _mainsavgpowerfactor = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactor));
            }
        }
        public string MainsAVGPowerFactor_2
        {
            get { return _mainsavgpowerfactor_2; }
            set
            {
                _mainsavgpowerfactor_2 = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactor_2));
            }
        }
        public string MainsPhaseL1
        {
            get { return _mainsphasel1; }
            set
            {
                _mainsphasel1 = value;
                OnPropertyChanged(nameof(MainsPhaseL1));
            }
        }
        public string MainsPhaseL1_2
        {
            get { return _mainsphasel1_2; }
            set
            {
                _mainsphasel1_2 = value;
                OnPropertyChanged(nameof(MainsPhaseL1_2));
            }
        } 
        public string MainsPhaseL2
        {
            get { return _mainsphasel2; }
            set
            {
                _mainsphasel2 = value;
                OnPropertyChanged(nameof(MainsPhaseL2));
            }
        }
        public string MainsPhaseL2_2
        {
            get { return _mainsphasel2_2; }
            set
            {
                _mainsphasel2_2 = value;
                OnPropertyChanged(nameof(MainsPhaseL2_2));
            }
        } 
        public string MainsPhaseL3
        {
            get { return _mainsphasel3; }
            set
            {
                _mainsphasel3 = value;
                OnPropertyChanged(nameof(MainsPhaseL3));
            }
        }
        public string MainsPhaseL3_2
        {
            get { return _mainsphasel3_2; }
            set
            {
                _mainsphasel3_2 = value;
                OnPropertyChanged(nameof(MainsPhaseL3_2));
            }
        } 
        public string MainsPhaseTotal
        {
            get { return _mainsphasetotal; }
            set
            {
                _mainsphasetotal = value;
                OnPropertyChanged(nameof(MainsPhaseTotal));
            }
        }
        public string MainsPhaseTotal_2
        {
            get { return _mainsphasetotal_2; }
            set
            {
                _mainsphasetotal_2 = value;
                OnPropertyChanged(nameof(MainsPhaseTotal_2));
            }
        }
        public string MainsVoltLLAvg
        {
            get { return _mainsvoltllavg; }
            set
            {
                _mainsvoltllavg = value;
                OnPropertyChanged(nameof(MainsVoltLLAvg));
            }
        } 
        public string MainsVoltLLAvg_2
        {
            get { return _mainsvoltllavg_2; }
            set
            {
                _mainsvoltllavg_2 = value;
                OnPropertyChanged(nameof(MainsVoltLLAvg_2));
            }
        }
        public string MainsVoltLLDiff
        {
            get { return _mainsvoltlldiff; }
            set
            {
                _mainsvoltlldiff = value;
                OnPropertyChanged(nameof(MainsVoltLLDiff));
            }
        }
        public string MainsVoltLLDiff_2
        {
            get { return _mainsvoltlldiff_2; }
            set
            {
                _mainsvoltlldiff_2 = value;
                OnPropertyChanged(nameof(MainsVoltLLDiff_2));
            }
        } 
        public string MainsVoltLLMin
        {
            get { return _mainsvoltllmin; }
            set
            {
                _mainsvoltllmin = value;
                OnPropertyChanged(nameof(MainsVoltLLMin));
            }
        } 
        public string MainsVoltLLMin_2
        {
            get { return _mainsvoltllmin_2; }
            set
            {
                _mainsvoltllmin_2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMin_2));
            }
        } 
        public string MainsVoltLLMax
        {
            get { return _mainsvoltllmax; }
            set
            {
                _mainsvoltllmax = value;
                OnPropertyChanged(nameof(MainsVoltLLMax));
            }
        } 
        public string MainsVoltLLMax_2
        {
            get { return _mainsvoltllmax_2; }
            set
            {
                _mainsvoltllmax_2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMax_2));
            }
        }
        public string MainsFreqIndicator
        {
            get { return _mainsfreqindicator; }
            set
            {
                _mainsfreqindicator = value;
                OnPropertyChanged(nameof(MainsFreqIndicator));
            }
        }
        public string MainsL1VoltsIndicator
        {
            get { return _mainsl1voltsindicator; }
            set
            {
                _mainsl1voltsindicator = value;
                OnPropertyChanged(nameof(MainsL1VoltsIndicator));
            }
        }
        public string MainsL2VoltsIndicator
        {
            get { return _mainsl2voltsindicator; }
            set
            {
                _mainsl2voltsindicator = value;
                OnPropertyChanged(nameof(MainsL2VoltsIndicator));
            }
        }
        public string MainsL3VoltsIndicator
        {
            get { return _mainsl3voltsindicator; }
            set
            {
                _mainsl3voltsindicator = value;
                OnPropertyChanged(nameof(MainsL3VoltsIndicator));
            }
        }
        public string MainsL1L2VoltsIndicator
        {
            get { return _mainsl1l2voltsindicator; }
            set
            {
                _mainsl1l2voltsindicator = value;
                OnPropertyChanged(nameof(MainsL1L2VoltsIndicator));
            }
        }
        public string MainsL2L3VoltsIndicator
        {
            get { return _mainsl2l3voltsindicator; }
            set
            {
                _mainsl2l3voltsindicator = value;
                OnPropertyChanged(nameof(MainsL2L3VoltsIndicator));
            }
        }
        public string MainsL3L1voltsIndicator
        {
            get { return _mainsl3l1voltsindicator; }
            set
            {
                _mainsl3l1voltsindicator = value;

                OnPropertyChanged(nameof(MainsL3L1voltsIndicator));
            }
        }
        public string Mainsl1CurrentIndicator
        {
            get { return _mainsl1currentindicator; }
            set
            {
                _mainsl1currentindicator = value;
                OnPropertyChanged(nameof(Mainsl1CurrentIndicator));
            }
        }
        public string MainsL2CurrentIndicator
        {
            get { return _mainsl2currentindicator; }
            set
            {
                _mainsl2currentindicator = value;
                OnPropertyChanged(nameof(MainsL2CurrentIndicator));
            }
        }

        public string MainsL3CurrentIndicator
        {
            get { return _mainsl3currentindicator; }
            set
            {
                _mainsl3currentindicator = value;
                OnPropertyChanged(nameof(MainsL3CurrentIndicator));
            }
        }
        public string MainsECurrentIndicator
        {
            get { return _mainsecurrentindicator; }
            set
            {
                _mainsecurrentindicator = value;
                OnPropertyChanged(nameof(MainsECurrentIndicator));
            }
        }

        public string MainsL1WattsIndicator
        {
            get { return _mainsl1wattsindicator; }
            set
            {
                _mainsl1wattsindicator = value;
                OnPropertyChanged(nameof(MainsL1WattsIndicator));
            }
        }
        public string MainsL2WattsIndicator
        {
            get { return _mainsl2wattsindicator; }
            set
            {
                _mainsl2wattsindicator = value;
                OnPropertyChanged(nameof(MainsL2WattsIndicator));
            }
        }
        public string MainsL3WattsIndicator
        {
            get { return _mainsl3wattsindicator; }
            set
            {
                _mainsl3wattsindicator = value;
                OnPropertyChanged(nameof(MainsL3WattsIndicator));
            }
        }
        public string MainsL1VAIndicator
        {
            get { return _mainsl1vaindicator; }
            set
            {
                _mainsl1vaindicator = value;
                OnPropertyChanged(nameof(MainsL1VAIndicator));
            }
        }
        public string MainsL2VAIndicator
        {
            get { return _mainsl2vaindicator; }
            set
            {
                _mainsl2vaindicator = value;
                OnPropertyChanged(nameof(MainsL2VAIndicator));
            }
        }
        public string MainsL3VAIndicator
        {
            get { return _mainsl3vaindicator; }
            set
            {
                _mainsl3vaindicator = value;
                OnPropertyChanged(nameof(MainsL3VAIndicator));
            }
        }
        public string MainsTotalVAIndicator
        {
            get { return _mainstotalvaindicator; }
            set
            {
                _mainstotalvaindicator = value;
                OnPropertyChanged(nameof(MainsTotalVAIndicator));
            }
        }
        public string MainsPowerFactorL1Indicator
        {
            get { return _mainspowerfactorl1indicator; }
            set
            {
                _mainspowerfactorl1indicator = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1Indicator));
            }
        }
        public string MainsPowerFactorL2Indicator
        {
            get { return _mainspowerfactorl2indicator; }
            set
            {
                _mainspowerfactorl2indicator = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2Indicator));
            }
        }
        public string MainsPowerFactorL3Indicator
        {
            get { return _mainspowerfactorl3indicator; }
            set
            {
                _mainspowerfactorl3indicator = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3Indicator));
            }
        }
        public string MainsAVGPowerFactorIndicator
        {
            get { return _mainsavgpowerfactorindicator; }
            set
            {
                _mainsavgpowerfactorindicator = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactorIndicator));
            }
        }
        public string MainsPhaseL1Indicator
        {
            get { return _mainsphasel1indicator; }
            set
            {
                _mainsphasel1indicator = value;
                OnPropertyChanged(nameof(MainsPhaseL1Indicator));
            }
        }
        public string MainsPhaseL2Indicator
        {
            get { return _mainsphasel2indicator; }
            set
            {
                _mainsphasel2indicator = value;
                OnPropertyChanged(nameof(MainsPhaseL2Indicator));
            }
        }
        public string MainsPhaseL3Indicator
        {
            get { return _mainsphasel3indicator; }
            set
            {
                _mainsphasel3indicator = value;
                OnPropertyChanged(nameof(MainsPhaseL3Indicator));
            }
        }
        public string MainsPhaseTotalIndicator
        {
            get { return _mainsphasetotalindicator; }
            set
            {
                _mainsphasetotalindicator = value;
                OnPropertyChanged(nameof(MainsPhaseTotalIndicator));
            }
        }
        public string MainsVoltLLAvgIndicator
        {
            get { return _mainsvoltllavgindicator; }
            set
            {
                _mainsvoltllavgindicator = value;
                OnPropertyChanged(nameof(MainsVoltLLAvgIndicator));
            }
        }
        public string MainsVoltLLDiffIndicator
        {
            get { return _mainsvoltlldiffindicator; }
            set
            {
                _mainsvoltlldiffindicator = value;
                OnPropertyChanged(nameof(MainsVoltLLDiffIndicator));
            }
        }
        public string MainsVoltLLMinIndicator
        {
            get { return _mainsvoltllminindicator; }
            set
            {
                _mainsvoltllminindicator = value;
                OnPropertyChanged(nameof(MainsVoltLLMinIndicator));
            }
        }
        public string MainsVoltLLMaxIndicator
        {
            get { return _mainsvoltllmaxindicator; }
            set
            {
                _mainsvoltllmaxindicator = value;
                OnPropertyChanged(nameof(MainsVoltLLMaxIndicator));
            }
        }
        #region main2indicator
        public string MainsFreqIndicator2
        {
            get { return _mainsfreqindicator2; }
            set
            {
                _mainsfreqindicator2 = value;
                OnPropertyChanged(nameof(MainsFreqIndicator2));
            }
        }
        public string MainsL1VoltsIndicator2
        {
            get { return _mainsl1voltsindicator2; }
            set
            {
                _mainsl1voltsindicator2 = value;
                OnPropertyChanged(nameof(MainsL1VoltsIndicator2));
            }
        }
        public string MainsL2VoltsIndicator2
        {
            get { return _mainsl2voltsindicator2; }
            set
            {
                _mainsl2voltsindicator2 = value;
                OnPropertyChanged(nameof(MainsL2VoltsIndicator2));
            }
        }
        public string MainsL3VoltsIndicator2
        {
            get { return _mainsl3voltsindicator2; }
            set
            {
                _mainsl3voltsindicator2 = value;
                OnPropertyChanged(nameof(MainsL3VoltsIndicator2));
            }
        }
        public string MainsL1L2VoltsIndicator2
        {
            get { return _mainsl1l2voltsindicator2; }
            set
            {
                _mainsl1l2voltsindicator2 = value;
                OnPropertyChanged(nameof(MainsL1L2VoltsIndicator2));
            }
        }
        public string MainsL2L3VoltsIndicator2
        {
            get { return _mainsl2l3voltsindicator2; }
            set
            {
                _mainsl2l3voltsindicator2 = value;
                OnPropertyChanged(nameof(MainsL2L3VoltsIndicator2));
            }
        }
        public string MainsL3L1voltsIndicator2
        {
            get { return _mainsl3l1voltsindicator2; }
            set
            {
                _mainsl3l1voltsindicator2 = value;

                OnPropertyChanged(nameof(MainsL3L1voltsIndicator2));
            }
        }
        public string Mainsl1CurrentIndicator2
        {
            get { return _mainsl1currentindicator2; }
            set
            {
                _mainsl1currentindicator2 = value;
                OnPropertyChanged(nameof(Mainsl1CurrentIndicator2));
            }
        }
        public string MainsL2CurrentIndicator2
        {
            get { return _mainsl2currentindicator2; }
            set
            {
                _mainsl2currentindicator2 = value;
                OnPropertyChanged(nameof(MainsL2CurrentIndicator2));
            }
        }

        public string MainsL3CurrentIndicator2
        {
            get { return _mainsl3currentindicator2; }
            set
            {
                _mainsl3currentindicator2 = value;
                OnPropertyChanged(nameof(MainsL3CurrentIndicator2));
            }
        }
        public string MainsECurrentIndicator2
        {
            get { return _mainsecurrentindicator2; }
            set
            {
                _mainsecurrentindicator2 = value;
                OnPropertyChanged(nameof(MainsECurrentIndicator2));
            }
        }

        public string MainsL1WattsIndicator2
        {
            get { return _mainsl1wattsindicator2; }
            set
            {
                _mainsl1wattsindicator2 = value;
                OnPropertyChanged(nameof(MainsL1WattsIndicator2));
            }
        }
        public string MainsL2WattsIndicator2
        {
            get { return _mainsl2wattsindicator2; }
            set
            {
                _mainsl2wattsindicator2 = value;
                OnPropertyChanged(nameof(MainsL2WattsIndicator2));
            }
        }
        public string MainsL3WattsIndicator2
        {
            get { return _mainsl3wattsindicator2; }
            set
            {
                _mainsl3wattsindicator2 = value;
                OnPropertyChanged(nameof(MainsL3WattsIndicator2));
            }
        }
        public string MainsL1VAIndicator2
        {
            get { return _mainsl1vaindicator2; }
            set
            {
                _mainsl1vaindicator2 = value;
                OnPropertyChanged(nameof(MainsL1VAIndicator2));
            }
        }
        public string MainsL2VAIndicator2
        {
            get { return _mainsl2vaindicator2; }
            set
            {
                _mainsl2vaindicator2 = value;
                OnPropertyChanged(nameof(MainsL2VAIndicator2));
            }
        }
        public string MainsL3VAIndicator2
        {
            get { return _mainsl3vaindicator2; }
            set
            {
                _mainsl3vaindicator2 = value;
                OnPropertyChanged(nameof(MainsL3VAIndicator2));
            }
        }
        public string MainsTotalVAIndicator2
        {
            get { return _mainstotalvaindicator2; }
            set
            {
                _mainstotalvaindicator2 = value;
                OnPropertyChanged(nameof(MainsTotalVAIndicator2));
            }
        }
        public string MainsPowerFactorL1Indicator2
        {
            get { return _mainspowerfactorl1indicator2; }
            set
            {
                _mainspowerfactorl1indicator2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1Indicator2));
            }
        }
        public string MainsPowerFactorL2Indicator2
        {
            get { return _mainspowerfactorl2indicator2; }
            set
            {
                _mainspowerfactorl2indicator2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2Indicator2));
            }
        }
        public string MainsPowerFactorL3Indicator2
        {
            get { return _mainspowerfactorl3indicator2; }
            set
            {
                _mainspowerfactorl3indicator2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3Indicator2));
            }
        }
        public string MainsAVGPowerFactorIndicator2
        {
            get { return _mainsavgpowerfactorindicator2; }
            set
            {
                _mainsavgpowerfactorindicator2 = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactorIndicator2));
            }
        }
        public string MainsPhaseL1Indicator2
        {
            get { return _mainsphasel1indicator2; }
            set
            {
                _mainsphasel1indicator2 = value;
                OnPropertyChanged(nameof(MainsPhaseL1Indicator2));
            }
        }
        public string MainsPhaseL2Indicator2
        {
            get { return _mainsphasel2indicator2; }
            set
            {
                _mainsphasel2indicator2 = value;
                OnPropertyChanged(nameof(MainsPhaseL2Indicator2));
            }
        }
        public string MainsPhaseL3Indicator2
        {
            get { return _mainsphasel3indicator2; }
            set
            {
                _mainsphasel3indicator2 = value;
                OnPropertyChanged(nameof(MainsPhaseL3Indicator2));
            }
        }
        public string MainsPhaseTotalIndicator2
        {
            get { return _mainsphasetotalindicator2; }
            set
            {
                _mainsphasetotalindicator2 = value;
                OnPropertyChanged(nameof(MainsPhaseTotalIndicator2));
            }
        }
        public string MainsVoltLLAvgIndicator2
        {
            get { return _mainsvoltllavgindicator2; }
            set
            {
                _mainsvoltllavgindicator2 = value;
                OnPropertyChanged(nameof(MainsVoltLLAvgIndicator2));
            }
        }
        public string MainsVoltLLDiffIndicator2
        {
            get { return _mainsvoltlldiffindicator2; }
            set
            {
                _mainsvoltlldiffindicator2 = value;
                OnPropertyChanged(nameof(MainsVoltLLDiffIndicator2));
            }
        }
        public string MainsVoltLLMinIndicator2
        {
            get { return _mainsvoltllminindicator2; }
            set
            {
                _mainsvoltllminindicator2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMinIndicator2));
            }
        }
        public string MainsVoltLLMaxIndicator2
        {
            get { return _mainsvoltllmaxindicator2; }
            set
            {
                _mainsvoltllmaxindicator2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMaxIndicator2));
            }
        }
        #endregion
        public string MainsFreqTimestamp
        {
            get { return _mainsfreqtimestamp; }
            set
            {
                _mainsfreqtimestamp = value;
                OnPropertyChanged(nameof(MainsFreqTimestamp));
            }
        }
        public string MainsL1VoltsTimestamp
        {
            get { return _mainsl1voltstimestamp; }
            set
            {
                _mainsl1voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL1VoltsTimestamp));
            }
        }
        public string MainsL2VoltsTimestamp
        {
            get { return _mainsl2voltstimestamp; }
            set
            {
                _mainsl2voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL2VoltsTimestamp));
            }
        }
        public string MainsL3VoltsTimestamp
        {
            get { return _mainsl3voltstimestamp; }
            set
            {
                _mainsl3voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL3VoltsTimestamp));
            }
        }
        public string MainsL1L2VoltsTimestamp
        {
            get { return _mainsl1l2voltstimestamp; }
            set
            {
                _mainsl1l2voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL1L2VoltsTimestamp));
            }
        }
        public string MainsL2L3VoltsTimestamp
        {
            get { return _mainsl2l3voltstimestamp; }
            set
            {
                _mainsl2l3voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL2L3VoltsTimestamp));
            }
        }
        public string MainsL3L1VoltsTimestamp
        {
            get { return _mainsl3l1voltstimestamp; }
            set
            {
                _mainsl3l1voltstimestamp = value;
                OnPropertyChanged(nameof(MainsL3L1VoltsTimestamp));
            }
        }
        public string MainsL1CurrentTimestamp
        {
            get { return _mainsl1currenttimestamp; }
            set
            {
                _mainsl1currenttimestamp = value;
                OnPropertyChanged(nameof(MainsL1CurrentTimestamp));
            }
        }
        public string MainsL2CurrentTimestamp
        {
            get { return _mainsl2currenttimestamp; }
            set
            {
                _mainsl2currenttimestamp = value;
                OnPropertyChanged(nameof(MainsL2CurrentTimestamp));
            }
        }
        public string MainsL3CurrentTimestamp
        {
            get { return _mainsl3currenttimestamp; }
            set
            {
                _mainsl3currenttimestamp = value;
                OnPropertyChanged(nameof(MainsL3CurrentTimestamp));
            }
        }
        public string MainsEcurrentTimestamp
        {
            get { return _mainsecurrenttimestamp; }
            set
            {
                _mainsecurrenttimestamp = value;
                OnPropertyChanged(nameof(MainsEcurrentTimestamp));
            }
        }
        public string MainsL1WattsTimestamp
        {
            get { return _mainsl1wattstimestamp; }
            set
            {
                _mainsl1wattstimestamp = value;
                OnPropertyChanged(nameof(MainsL1WattsTimestamp));
            }
        }
        public string MainsL2WattsTimestamp
        {
            get { return _mainsl2wattstimestamp; }
            set
            {
                _mainsl2wattstimestamp = value;
                OnPropertyChanged(nameof(MainsL2WattsTimestamp));
            }
        }
        public string MainsL3WattsTimestamp
        {
            get { return _mainsl3wattstimestamp; }
            set
            {
                _mainsl3wattstimestamp = value;
                OnPropertyChanged(nameof(MainsL3WattsTimestamp));
            }
        }
        public string MainsL1VATimestamp
        {
            get { return _mainsl1vatimestamp; }
            set
            {
                _mainsl1vatimestamp = value;
                OnPropertyChanged(nameof(MainsL1VATimestamp));
            }
        }
        public string MainsL2VATimestamp
        {
            get { return _mainsl2vatimestamp; }
            set
            {
                _mainsl2vatimestamp = value;
                OnPropertyChanged(nameof(MainsL2VATimestamp));
            }
        }
        public string MainsL3VATimestamp
        {
            get { return _mainsl3vatimestamp; }
            set
            {
                _mainsl3vatimestamp = value;
                OnPropertyChanged(nameof(MainsL3VATimestamp));
            }
        }
        public string MainsTotalVATimestamp
        {
            get { return _mainstotalvatimestamp; }
            set
            {
                _mainstotalvatimestamp = value;
                OnPropertyChanged(nameof(MainsTotalVATimestamp));
            }
        }
        public string MainsPowerFactorL1Timestamp
        {
            get { return _mainspowerfactorl1timestamp; }
            set
            {
                _mainspowerfactorl1timestamp = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1Timestamp));
            }
        }
        public string MainsPowerFactorL2Timestamp
        {
            get { return _mainspowerfactorl2timestamp; }
            set
            {
                _mainspowerfactorl2timestamp = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2Timestamp));
            }
        }
        public string MainsPowerFactorL3Timestamp
        {
            get { return _mainspowerfactorl3timestamp; }
            set
            {
                _mainspowerfactorl3timestamp = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3Timestamp));
            }
        }
        public string MainsAVGPowerFactorTimestamp
        {
            get { return _mainsavgpowerfactortimestamp; }
            set
            {
                _mainsavgpowerfactortimestamp = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactorTimestamp));
            }
        }
        public string MainsPhaseL1Timestamp
        {
            get { return _mainsphasel1timestamp; }
            set
            {
                _mainsphasel1timestamp = value;
                OnPropertyChanged(nameof(MainsPhaseL1Timestamp));
            }
        }
        public string MainsPhaseL2Timestamp
        {
            get { return _mainsphasel2timestamp; }
            set
            {
                _mainsphasel2timestamp = value;
                OnPropertyChanged(nameof(MainsPhaseL2Timestamp));
            }
        }
        public string MainsPhaseL3Timestamp
        {
            get { return _mainsphasel3timestamp; }
            set
            {
                _mainsphasel3timestamp = value;
                OnPropertyChanged(nameof(MainsPhaseL3Timestamp));
            }
        }
        public string MainsPhaseTotalTimestamp
        {
            get { return _mainsphasetotaltimestamp; }
            set
            {
                _mainsphasetotaltimestamp = value;
                OnPropertyChanged(nameof(MainsPhaseTotalTimestamp));
            }
        }
        public string MainsVoltLLAvgTimestamp
        {
            get { return _mainsvoltllavgtimestamp; }
            set
            {
                _mainsvoltllavgtimestamp = value;
                OnPropertyChanged(nameof(MainsVoltLLAvgTimestamp));
            }
        }
        public string MainsVoltLLDiffTimestamp
        {
            get { return _mainsvoltlldifftimestamp; }
            set
            {
                _mainsvoltlldifftimestamp = value;
                OnPropertyChanged(nameof(MainsVoltLLDiffTimestamp));
            }
        }
        public string MainsVoltLLMinTimestamp
        {
            get { return _mainsvoltllmintimestamp; }
            set
            {
                _mainsvoltllmintimestamp = value;
                OnPropertyChanged(nameof(MainsVoltLLMinTimestamp));
            }
        }
        public string MainsVoltLLMaxTimestamp
        {
            get { return _mainsvoltllmaxtimestamp; }
            set
            {
                _mainsvoltllmaxtimestamp = value;
                OnPropertyChanged(nameof(MainsVoltLLMaxTimestamp));
            }
        }

        public string MainsFreqTimestamp2
        {
            get { return _mainsfreqtimestamp2; }
            set
            {
                _mainsfreqtimestamp2 = value;
                OnPropertyChanged(nameof(MainsFreqTimestamp2));
            }
        }
        public string MainsL1VoltsTimestamp2
        {
            get { return _mainsl1voltstimestamp2; }
            set
            {
                _mainsl1voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL1VoltsTimestamp2));
            }
        }
        public string MainsL2VoltsTimestamp2
        {
            get { return _mainsl2voltstimestamp2; }
            set
            {
                _mainsl2voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL2VoltsTimestamp2));
            }
        }
        public string MainsL3VoltsTimestamp2
        {
            get { return _mainsl3voltstimestamp2; }
            set
            {
                _mainsl3voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL3VoltsTimestamp2));
            }
        }
        public string MainsL1L2VoltsTimestamp2
        {
            get { return _mainsl1l2voltstimestamp2; }
            set
            {
                _mainsl1l2voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL1L2VoltsTimestamp2));
            }
        }
        public string MainsL2L3VoltsTimestamp2
        {
            get { return _mainsl2l3voltstimestamp2; }
            set
            {
                _mainsl2l3voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL2L3VoltsTimestamp2));
            }
        }
        public string MainsL3L1VoltsTimestamp2
        {
            get { return _mainsl3l1voltstimestamp2; }
            set
            {
                _mainsl3l1voltstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL3L1VoltsTimestamp2));
            }
        }
        public string MainsL1CurrentTimestamp2
        {
            get { return _mainsl1currenttimestamp2; }
            set
            {
                _mainsl1currenttimestamp2 = value;
                OnPropertyChanged(nameof(MainsL1CurrentTimestamp2));
            }
        }
        public string MainsL2CurrentTimestamp2
        {
            get { return _mainsl2currenttimestamp2; }
            set
            {
                _mainsl2currenttimestamp2 = value;
                OnPropertyChanged(nameof(MainsL2CurrentTimestamp2));
            }
        }
        public string MainsL3CurrentTimestamp2
        {
            get { return _mainsl3currenttimestamp2; }
            set
            {
                _mainsl3currenttimestamp2 = value;
                OnPropertyChanged(nameof(MainsL3CurrentTimestamp2));
            }
        }
        public string MainsEcurrentTimestamp2
        {
            get { return _mainsecurrenttimestamp2; }
            set
            {
                _mainsecurrenttimestamp2 = value;
                OnPropertyChanged(nameof(MainsEcurrentTimestamp2));
            }
        }
        public string MainsL1WattsTimestamp2
        {
            get { return _mainsl1wattstimestamp2; }
            set
            {
                _mainsl1wattstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL1WattsTimestamp2));
            }
        }
        public string MainsL2WattsTimestamp2
        {
            get { return _mainsl2wattstimestamp2; }
            set
            {
                _mainsl2wattstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL2WattsTimestamp2));
            }
        }
        public string MainsL3WattsTimestamp2
        {
            get { return _mainsl3wattstimestamp2; }
            set
            {
                _mainsl3wattstimestamp2 = value;
                OnPropertyChanged(nameof(MainsL3WattsTimestamp2));
            }
        }
        public string MainsL1VATimestamp2
        {
            get { return _mainsl1vatimestamp2; }
            set
            {
                _mainsl1vatimestamp2 = value;
                OnPropertyChanged(nameof(MainsL1VATimestamp2));
            }
        }
        public string MainsL2VATimestamp2
        {
            get { return _mainsl2vatimestamp2; }
            set
            {
                _mainsl2vatimestamp2 = value;
                OnPropertyChanged(nameof(MainsL2VATimestamp2));
            }
        }
        public string MainsL3VATimestamp2
        {
            get { return _mainsl3vatimestamp2; }
            set
            {
                _mainsl3vatimestamp2 = value;
                OnPropertyChanged(nameof(MainsL3VATimestamp2));
            }
        }
        public string MainsTotalVATimestamp2
        {
            get { return _mainstotalvatimestamp2; }
            set
            {
                _mainstotalvatimestamp2 = value;
                OnPropertyChanged(nameof(MainsTotalVATimestamp2));
            }
        }
        public string MainsPowerFactorL1Timestamp2
        {
            get { return _mainspowerfactorl1timestamp2; }
            set
            {
                _mainspowerfactorl1timestamp2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL1Timestamp2));
            }
        }
        public string MainsPowerFactorL2Timestamp2
        {
            get { return _mainspowerfactorl2timestamp2; }
            set
            {
                _mainspowerfactorl2timestamp2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL2Timestamp2));
            }
        }
        public string MainsPowerFactorL3Timestamp2
        {
            get { return _mainspowerfactorl3timestamp2; }
            set
            {
                _mainspowerfactorl3timestamp2 = value;
                OnPropertyChanged(nameof(MainsPowerFactorL3Timestamp2));
            }
        }
        public string MainsAVGPowerFactorTimestamp2
        {
            get { return _mainsavgpowerfactortimestamp2; }
            set
            {
                _mainsavgpowerfactortimestamp2 = value;
                OnPropertyChanged(nameof(MainsAVGPowerFactorTimestamp2));
            }
        }
        public string MainsPhaseL1Timestamp2
        {
            get { return _mainsphasel1timestamp2; }
            set
            {
                _mainsphasel1timestamp2 = value;
                OnPropertyChanged(nameof(MainsPhaseL1Timestamp2));
            }
        }
        public string MainsPhaseL2Timestamp2
        {
            get { return _mainsphasel2timestamp2; }
            set
            {
                _mainsphasel2timestamp2 = value;
                OnPropertyChanged(nameof(MainsPhaseL2Timestamp2));
            }
        }
        public string MainsPhaseL3Timestamp2
        {
            get { return _mainsphasel3timestamp2; }
            set
            {
                _mainsphasel3timestamp2 = value;
                OnPropertyChanged(nameof(MainsPhaseL3Timestamp2));
            }
        }
        public string MainsPhaseTotalTimestamp2
        {
            get { return _mainsphasetotaltimestamp2; }
            set
            {
                _mainsphasetotaltimestamp2 = value;
                OnPropertyChanged(nameof(MainsPhaseTotalTimestamp2));
            }
        }
        public string MainsVoltLLAvgTimestamp2
        {
            get { return _mainsvoltllavgtimestamp2; }
            set
            {
                _mainsvoltllavgtimestamp2 = value;
                OnPropertyChanged(nameof(MainsVoltLLAvgTimestamp2));
            }
        }
        public string MainsVoltLLDiffTimestamp2
        {
            get { return _mainsvoltlldifftimestamp2; }
            set
            {
                _mainsvoltlldifftimestamp2 = value;
                OnPropertyChanged(nameof(MainsVoltLLDiffTimestamp2));
            }
        }
        public string MainsVoltLLMinTimestamp2
        {
            get { return _mainsvoltllmintimestamp2; }
            set
            {
                _mainsvoltllmintimestamp2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMinTimestamp2));
            }
        }
        public string MainsVoltLLMaxTimestamp2
        {
            get { return _mainsvoltllmaxtimestamp2; }
            set
            {
                _mainsvoltllmaxtimestamp2 = value;
                OnPropertyChanged(nameof(MainsVoltLLMaxTimestamp2));
            }
        }
        #endregion

        #region Generator Group Property
        public string GenFreq
        {
            get { return _genfreq; }
            set
            {
                _genfreq = value;
                OnPropertyChanged(nameof(GenFreq));
            }
        }
        public string GenFreq2
        {
            get { return _genfreq2; }
            set
            {
                _genfreq2 = value;
                OnPropertyChanged(nameof(GenFreq2));
            }
        }
        public string GenL3Volts
        {
            get { return _genl3volts; }
            set
            {
                _genl3volts = value;
                OnPropertyChanged(nameof(GenL3Volts));
            }
        }
        public string GenL3Volts2
        {
            get { return _genl3volts2; }
            set
            {
                _genl3volts2 = value;
                OnPropertyChanged(nameof(GenL3Volts2));
            }
        }
        public string GenL1L2volts
        {
            get { return _genl1l2volts; }
            set
            {
                _genl1l2volts = value;
                OnPropertyChanged(nameof(GenL1L2volts));
            }
        }
        public string GenL1L2volts2
        {
            get { return _genl1l2volts2; }
            set
            {
                _genl1l2volts2 = value;
                OnPropertyChanged(nameof(GenL1L2volts2));
            }
        }
        public string GenL2L3Volts
        {
            get { return _genl2l3volts; }
            set
            {
                _genl2l3volts = value;
                OnPropertyChanged(nameof(GenL2L3Volts));
            }
        }
        public string GenL2L3Volts2
        {
            get { return _genl2l3volts; }
            set
            {
                _genl2l3volts = value;
                OnPropertyChanged(nameof(GenL2L3Volts2));
            }
        }
        public string GenL3L1Volts
        {
            get { return _genl3l1volts; }
            set
            {
                _genl3l1volts = value;
                OnPropertyChanged(nameof(GenL3L1Volts));
            }
        }
        public string GenL3L1Volts2
        {
            get { return _genl3l1volts2; }
            set
            {
                _genl3l1volts2 = value;
                OnPropertyChanged(nameof(GenL3L1Volts2));
            }
        }
        public string GenL3Current
        {
            get { return _genl3current; }
            set
            {
                _genl3current = value;
                OnPropertyChanged(nameof(GenL3Current));
            }
        }
        public string GenL3Current2
        {
            get { return _genl3current2; }
            set
            {
                _genl3current2 = value;
                OnPropertyChanged(nameof(GenL3Current2));
            }
        }       
        public string GeneCurrent
        {
            get { return _genecurrent; }
            set
            {
                _genecurrent = value;
                OnPropertyChanged(nameof(GeneCurrent));
            }
        }
        public string GeneCurrent2
        {
            get { return _genecurrent2; }
            set
            {
                _genecurrent2 = value;
                OnPropertyChanged(nameof(GeneCurrent2));
            }
        }
        public string GenL3Watts
        {
            get { return _genl3watts; }
            set
            {
                _genl3watts = value;
                OnPropertyChanged(nameof(GenL3Watts));
            }
        }
        public string GenL3Watts2
        {
            get { return _genl3watts2; }
            set
            {
                _genl3watts2 = value;
                OnPropertyChanged(nameof(GenL3Watts2));
            }
        }
        public string GenWattsTotal
        {
            get { return _genwattstotal; }
            set
            {
                _genwattstotal = value;
                OnPropertyChanged(nameof(GenWattsTotal));
            }
        }
        public string GenWattsTotal2
        {
            get { return _genwattstotal2; }
            set
            {
                _genwattstotal2 = value;
                OnPropertyChanged(nameof(GenWattsTotal2));
            }
        }
        public string GenTotalVa
        {
            get { return _gentotalva; }
            set
            {
                _gentotalva = value;
                OnPropertyChanged(nameof(GenTotalVa));
            }
        }
        public string GenTotalVa2
        {
            get { return _gentotalva2; }
            set
            {
                _gentotalva2 = value;
                OnPropertyChanged(nameof(GenTotalVa2));
            }
        }
        public string GenaVgPowerFactor
        {
            get { return _genavgpowerfactor; }
            set
            {
                _genavgpowerfactor = value;
                OnPropertyChanged(nameof(GenaVgPowerFactor));
            }
        }
        public string GenaVgPowerFactor2
        {
            get { return _genavgpowerfactor2; }
            set
            {
                _genavgpowerfactor2 = value;
                OnPropertyChanged(nameof(GenaVgPowerFactor2));
            }
        }
        public string GenL1Current
        {
            get { return _genl1current; }
            set
            {
                _genl1current = value;
                OnPropertyChanged(nameof(GenL1Current));
            }
        } 
        public string GenL1Current2
        {
            get { return _genl1current2; }
            set
            {
                _genl1current2 = value;
                OnPropertyChanged(nameof(GenL1Current2));
            }
        }
        public string GenL2Current
        {
            get { return _genl2current; }
            set
            {
                _genl2current = value;
                OnPropertyChanged(nameof(GenL2Current));
            }
        }
        public string GenL2Current2
        {
            get { return _genl2current2; }
            set
            {
                _genl2current2 = value;
                OnPropertyChanged(nameof(GenL2Current2));
            }
        } 
        public string GenL1VA
        {
            get { return _genl1va; }
            set
            {
                _genl1va = value;
                OnPropertyChanged(nameof(GenL1VA));
            }
        }
        public string GenL1VA2
        {
            get { return _genl1va2; }
            set
            {
                _genl1va2 = value;
                OnPropertyChanged(nameof(GenL1VA2));
            }
        }
        public string GenL2VA
        {
            get { return _genl2va; }
            set
            {
                _genl2va = value;
                OnPropertyChanged(nameof(GenL2VA));
            }
        }
        public string GenL2VA2
        {
            get { return _genl2va2; }
            set
            {
                _genl2va2 = value;
                OnPropertyChanged(nameof(GenL2VA2));
            }
        } 
        public string GenL3VA
        {
            get { return _genl3va; }
            set
            {
                _genl3va = value;
                OnPropertyChanged(nameof(GenL3VA));
            }
        }
        public string GenL3VA2
        {
            get { return _genl3va2; }
            set
            {
                _genl3va2 = value;
                OnPropertyChanged(nameof(GenL3VA2));
            }
        }
        public string GenPowerfactorL1
        {
            get { return _genpowerfactorl1; }
            set
            {
                _genpowerfactorl1 = value;
                OnPropertyChanged(nameof(GenPowerfactorL1));
            }
        }
        public string GenPowerfactorL1_2
        {
            get { return _genpowerfactorl1_2; }
            set
            {
                _genpowerfactorl1_2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL1_2));
            }
        }
        public string GenPowerfactorL2
        {
            get { return _genpowerfactorl2; }
            set
            {
                _genpowerfactorl2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL2));
            }
        }
        public string GenPowerfactorL2_2
        {
            get { return _genpowerfactorl2_2; }
            set
            {
                _genpowerfactorl2_2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL2_2));
            }
        }
        public string GenPowerfactorL3
        {
            get { return _genpowerfactorl3; }
            set
            {
                _genpowerfactorl3 = value;
                OnPropertyChanged(nameof(GenPowerfactorL3));
            }
        }
        public string GenPowerfactorL3_2
        {
            get { return _genpowerfactorl3_2; }
            set
            {
                _genpowerfactorl3_2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL3_2));
            }
        }
        public string GenPhase1
        {
            get { return _genphase1; }
            set
            {
                _genphase1 = value;
                OnPropertyChanged(nameof(GenPhase1));
            }
        } 
        public string GenPhase1_2
        {
            get { return _genphase1_2; }
            set
            {
                _genphase1_2 = value;
                OnPropertyChanged(nameof(GenPhase1_2));
            }
        } 
        public string GenPhase2
        {
            get { return _genphase2; }
            set
            {
                _genphase2 = value;
                OnPropertyChanged(nameof(GenPhase2));
            }
        } 
        public string GenPhase2_2
        {
            get { return _genphase2_2; }
            set
            {
                _genphase2_2 = value;
                OnPropertyChanged(nameof(GenPhase2_2));
            }
        } 
        public string GenPhase3
        {
            get { return _genphase3; }
            set
            {
                _genphase3 = value;
                OnPropertyChanged(nameof(GenPhase3));
            }
        }
        public string GenPhase3_2
        {
            get { return _genphase3_2; }
            set
            {
                _genphase3_2 = value;
                OnPropertyChanged(nameof(GenPhase3_2));
            }
        }
        public string GenPhaseTotal
        {
            get { return _genphasetotal; }
            set
            {
                _genphasetotal = value;
                OnPropertyChanged(nameof(GenPhaseTotal));
            }
        }
        public string GenPhaseTotal2
        {
            get { return _genphasetotal2; }
            set
            {
                _genphasetotal2 = value;
                OnPropertyChanged(nameof(GenPhaseTotal2));
            }
        }
        public string GenVoltLLAvg
        {
            get { return _genvoltllavg; }
            set
            {
                _genvoltllavg = value;
                OnPropertyChanged(nameof(GenVoltLLAvg));
            }
        }
        public string GenVoltLLAvg2
        {
            get { return _genvoltllavg2; }
            set
            {
                _genvoltllavg2 = value;
                OnPropertyChanged(nameof(GenVoltLLAvg2));
            }
        }
        public string GenVoltLLDiff
        {
            get { return _genvoltlldiff; }
            set
            {
                _genvoltlldiff = value;
                OnPropertyChanged(nameof(GenVoltLLDiff));
            }
        }
        public string GenVoltLLDiff2
        {
            get { return _genvoltlldiff2; }
            set
            {
                _genvoltlldiff2 = value;
                OnPropertyChanged(nameof(GenVoltLLDiff2));
            }
        }
        public string GenVoltLLMin
        {
            get { return _genvoltllmin; }
            set
            {
                _genvoltllmin = value;
                OnPropertyChanged(nameof(GenVoltLLMin));
            }
        } 
        public string GenVoltLLMin2
        {
            get { return _genvoltllmin2; }
            set
            {
                _genvoltllmin2 = value;
                OnPropertyChanged(nameof(GenVoltLLMin2));
            }
        }
        public string GenVoltLLMax
        {
            get { return _genvoltllmax; }
            set
            {
                _genvoltllmax = value;
                OnPropertyChanged(nameof(GenVoltLLMax));
            }
        }
        public string GenVoltLLMax2
        {
            get { return _genvoltllmax2; }
            set
            {
                _genvoltllmax2 = value;
                OnPropertyChanged(nameof(GenVoltLLMax2));
            }
        }
        public string GenRotation
        {
            get { return _genrotation; }
            set
            {
                _genrotation = value;
                OnPropertyChanged(nameof(GenRotation));
            }
        }
        public string GenRotation2
        {
            get { return _genrotation2; }
            set
            {
                _genrotation2 = value;
                OnPropertyChanged(nameof(GenRotation2));
            }
        }
        public string GenCurrentAve
        {
            get { return _gencurrentave; }
            set
            {
                _gencurrentave = value;
                OnPropertyChanged(nameof(GenCurrentAve));
            }
        }
        public string GenCurrentAve2
        {
            get { return _gencurrentave2; }
            set
            {
                _gencurrentave2 = value;
                OnPropertyChanged(nameof(GenCurrentAve2));
            }
        }
        public string GenCurrentDiff
        {
            get { return _gencurrentdiff; }
            set
            {
                _gencurrentdiff = value;
                OnPropertyChanged(nameof(GenCurrentDiff));
            }
        } 
        public string GenCurrentDiff2
        {
            get { return _gencurrentdiff2; }
            set
            {
                _gencurrentdiff2 = value;
                OnPropertyChanged(nameof(GenCurrentDiff2));
            }
        }
        public string GenFreqIndicator
        {
            get { return _genfreqindicator; }
            set
            {
                _genfreqindicator = value;
                OnPropertyChanged(nameof(GenFreqIndicator));
            }
        }
        public string GenL3VoltsIndicator
        {
            get { return _genl3voltsindicator; }
            set
            {
                _genl3voltsindicator = value;
                OnPropertyChanged(nameof(GenL3VoltsIndicator));
            }
        }
        public string GenL1L2VoltsIndicator
        {
            get { return _genl1l2voltsindicator; }
            set
            {
                _genl1l2voltsindicator = value;
                OnPropertyChanged(nameof(GenL1L2VoltsIndicator));
            }
        }
        public string GenL2L3VoltsIndicator
        {
            get { return _genl2l3voltsindicator; }
            set
            {
                _genl2l3voltsindicator = value;
                OnPropertyChanged(nameof(GenL2L3VoltsIndicator));
            }
        }
        public string GenL3L1VoltsIndicator
        {
            get { return _genl3l1voltsindicator; }
            set
            {
                _genl3l1voltsindicator = value;
                OnPropertyChanged(nameof(GenL3L1VoltsIndicator));
            }
        }
        public string GenL3CurrentIndicator
        {
            get { return _genl3currentindicator; }
            set
            {
                _genl3currentindicator = value;
                OnPropertyChanged(nameof(GenL3CurrentIndicator));
            }
        }
        public string GeneCurrentIndicator
        {
            get { return _genecurrentindicator; }
            set
            {
                _genecurrentindicator = value;
                OnPropertyChanged(nameof(GeneCurrentIndicator));
            }
        }
        public string GenL3WattsIndicator
        {
            get { return _genl3wattsindicator; }
            set
            {
                _genl3wattsindicator = value;
                OnPropertyChanged(nameof(GenL3WattsIndicator));
            }
        }
        public string GenWattsTotalIndicator
        {
            get { return _genwattstotalindicator; }
            set
            {
                _genwattstotalindicator = value;
                OnPropertyChanged(nameof(GenWattsTotalIndicator));
            }
        }
        public string GenTotalVaIndicator
        {
            get { return _gentotalvaindicator; }
            set
            {
                _gentotalvaindicator = value;
                OnPropertyChanged(nameof(GenTotalVaIndicator));
            }
        }
        public string GenaVgPowerFactorIndicator
        {
            get { return _genavgpowerfactorindicator; }
            set
            {
                _genavgpowerfactorindicator = value;
                OnPropertyChanged(nameof(GenaVgPowerFactorIndicator));
            }
        }

        public string GenL1CurrentIndicator
        {
            get { return _genl1currentindicator; }
            set
            {
                _genl1currentindicator = value;
                OnPropertyChanged(nameof(GenL1CurrentIndicator));
            }
        }
        public string GenL2CurrentIndicator
        {
            get { return _genl2currentindicator; }
            set
            {
                _genl2currentindicator = value;
                OnPropertyChanged(nameof(GenL2CurrentIndicator));
            }
        }
        public string GenL1VAIndicator
        {
            get { return _genl1vaindicator; }
            set
            {
                _genl1vaindicator = value;
                OnPropertyChanged(nameof(GenL1VAIndicator));
            }
        }
        public string GenL2VAIndicator
        {
            get { return _genl2vaindicator; }
            set
            {
                _genl2vaindicator = value;
                OnPropertyChanged(nameof(GenL2VAIndicator));
            }
        }
        public string GenL3VAIndicator
        {
            get { return _genl3vaindicator; }
            set
            {
                _genl3vaindicator = value;
                OnPropertyChanged(nameof(GenL3VAIndicator));
            }
        }
        public string GenPowerfactorL1Indicator
        {
            get { return _genpowerfactorl1indicator; }
            set
            {
                _genpowerfactorl1indicator = value;
                OnPropertyChanged(nameof(GenPowerfactorL1Indicator));
            }
        }
        public string GenPowerfactorL2Indicator
        {
            get { return _genpowerfactorl2indicator; }
            set
            {
                _genpowerfactorl2indicator = value;
                OnPropertyChanged(nameof(GenPowerfactorL2Indicator));
            }
        }
        public string GenPowerfactorL3Indicator
        {
            get { return _genpowerfactorl3indicator; }
            set
            {
                _genpowerfactorl3indicator = value;
                OnPropertyChanged(nameof(GenPowerfactorL3Indicator));
            }
        }
        public string GenPhase1Indicator
        {
            get { return _genphase1indicator; }
            set
            {
                _genphase1indicator = value;
                OnPropertyChanged(nameof(GenPhase1Indicator));
            }
        }
        public string GenPhase2Indicator
        {
            get { return _genphase2indicator; }
            set
            {
                _genphase2indicator = value;
                OnPropertyChanged(nameof(GenPhase2Indicator));
            }
        }
        public string GenPhase3Indicator
        {
            get { return _genphase3indicator; }
            set
            {
                _genphase3indicator = value;
                OnPropertyChanged(nameof(GenPhase3Indicator));
            }
        }
        public string GenPhaseTotalIndicator
        {
            get { return _genphasetotalindicator; }
            set
            {
                _genphasetotalindicator = value;
                OnPropertyChanged(nameof(GenPhaseTotalIndicator));
            }
        }
        public string GenVoltLLAvgIndicator
        {
            get { return _genvoltllavgindicator; }
            set
            {
                _genvoltllavgindicator = value;
                OnPropertyChanged(nameof(GenVoltLLAvgIndicator));
            }
        }
        public string GenVoltLLDiffIndicator
        {
            get { return _genvoltlldiffindicator; }
            set
            {
                _genvoltlldiffindicator = value;
                OnPropertyChanged(nameof(GenVoltLLDiffIndicator));
            }
        }
        public string GenVoltLLMinIndicator
        {
            get { return _genvoltllminindicator; }
            set
            {
                _genvoltllminindicator = value;
                OnPropertyChanged(nameof(GenVoltLLMinIndicator));
            }
        }
        public string GenVoltLLMaxIndicator
        {
            get { return _genvoltllmaxindicator; }
            set
            {
                _genvoltllmaxindicator = value;
                OnPropertyChanged(nameof(GenVoltLLMaxIndicator));
            }
        }
        public string GenRotationIndicator
        {
            get { return _genrotationindicator; }
            set
            {
                _genrotationindicator = value;
                OnPropertyChanged(nameof(GenRotationIndicator));
            }
        }
        public string GenCurrentAveIndicator
        {
            get { return _gencurrentaveindicator; }
            set
            {
                _gencurrentaveindicator = value;
                OnPropertyChanged(nameof(GenCurrentAveIndicator));
            }
        }
        public string GenCurrentDiffIndicator
        {
            get { return _gencurrentdiffindicator; }
            set
            {
                _gencurrentdiffindicator = value;
                OnPropertyChanged(nameof(GenCurrentDiffIndicator));
            }
        }
        #region genindicator2
        public string GenFreqIndicator2
        {
            get { return _genfreqindicator2; }
            set
            {
                _genfreqindicator2 = value;
                OnPropertyChanged(nameof(GenFreqIndicator2));
            }
        }
        public string GenL3VoltsIndicator2
        {
            get { return _genl3voltsindicator2; }
            set
            {
                _genl3voltsindicator2 = value;
                OnPropertyChanged(nameof(GenL3VoltsIndicator2));
            }
        }
        public string GenL1L2VoltsIndicator2
        {
            get { return _genl1l2voltsindicator2; }
            set
            {
                _genl1l2voltsindicator2 = value;
                OnPropertyChanged(nameof(GenL1L2VoltsIndicator2));
            }
        }
        public string GenL2L3VoltsIndicator2
        {
            get { return _genl2l3voltsindicator2; }
            set
            {
                _genl2l3voltsindicator2 = value;
                OnPropertyChanged(nameof(GenL2L3VoltsIndicator2));
            }
        }
        public string GenL3L1VoltsIndicator2
        {
            get { return _genl3l1voltsindicator2; }
            set
            {
                _genl3l1voltsindicator2 = value;
                OnPropertyChanged(nameof(GenL3L1VoltsIndicator2));
            }
        }
        public string GenL3CurrentIndicator2
        {
            get { return _genl3currentindicator2; }
            set
            {
                _genl3currentindicator2 = value;
                OnPropertyChanged(nameof(GenL3CurrentIndicator2));
            }
        }
        public string GeneCurrentIndicator2
        {
            get { return _genecurrentindicator2; }
            set
            {
                _genecurrentindicator2 = value;
                OnPropertyChanged(nameof(GeneCurrentIndicator2));
            }
        }
        public string GenL3WattsIndicator2
        {
            get { return _genl3wattsindicator2; }
            set
            {
                _genl3wattsindicator2 = value;
                OnPropertyChanged(nameof(GenL3WattsIndicator2));
            }
        }
        public string GenWattsTotalIndicator2
        {
            get { return _genwattstotalindicator2; }
            set
            {
                _genwattstotalindicator2 = value;
                OnPropertyChanged(nameof(GenWattsTotalIndicator2));
            }
        }
        public string GenTotalVaIndicator2
        {
            get { return _gentotalvaindicator2; }
            set
            {
                _gentotalvaindicator2 = value;
                OnPropertyChanged(nameof(GenTotalVaIndicator2));
            }
        }
        public string GenaVgPowerFactorIndicator2
        {
            get { return _genavgpowerfactorindicator2; }
            set
            {
                _genavgpowerfactorindicator2 = value;
                OnPropertyChanged(nameof(GenaVgPowerFactorIndicator2));
            }
        }

        public string GenL1CurrentIndicator2
        {
            get { return _genl1currentindicator2; }
            set
            {
                _genl1currentindicator2 = value;
                OnPropertyChanged(nameof(GenL1CurrentIndicator2));
            }
        }
        public string GenL2CurrentIndicator2
        {
            get { return _genl2currentindicator2; }
            set
            {
                _genl2currentindicator2 = value;
                OnPropertyChanged(nameof(GenL2CurrentIndicator2));
            }
        }
        public string GenL1VAIndicator2
        {
            get { return _genl1vaindicator2; }
            set
            {
                _genl1vaindicator2 = value;
                OnPropertyChanged(nameof(GenL1VAIndicator2));
            }
        }
        public string GenL2VAIndicator2
        {
            get { return _genl2vaindicator2; }
            set
            {
                _genl2vaindicator2 = value;
                OnPropertyChanged(nameof(GenL2VAIndicator2));
            }
        }
        public string GenL3VAIndicator2
        {
            get { return _genl3vaindicator2; }
            set
            {
                _genl3vaindicator2 = value;
                OnPropertyChanged(nameof(GenL3VAIndicator2));
            }
        }
        public string GenPowerfactorL1Indicator2
        {
            get { return _genpowerfactorl1indicator2; }
            set
            {
                _genpowerfactorl1indicator2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL1Indicator2));
            }
        }
        public string GenPowerfactorL2Indicator2
        {
            get { return _genpowerfactorl2indicator2; }
            set
            {
                _genpowerfactorl2indicator2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL2Indicator2));
            }
        }
        public string GenPowerfactorL3Indicator2
        {
            get { return _genpowerfactorl3indicator2; }
            set
            {
                _genpowerfactorl3indicator2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL3Indicator2));
            }
        }
        public string GenPhase1Indicator2
        {
            get { return _genphase1indicator2; }
            set
            {
                _genphase1indicator2 = value;
                OnPropertyChanged(nameof(GenPhase1Indicator2));
            }
        }
        public string GenPhase2Indicator2
        {
            get { return _genphase2indicator2; }
            set
            {
                _genphase2indicator2 = value;
                OnPropertyChanged(nameof(GenPhase2Indicator2));
            }
        }
        public string GenPhase3Indicator2
        {
            get { return _genphase3indicator2; }
            set
            {
                _genphase3indicator2 = value;
                OnPropertyChanged(nameof(GenPhase3Indicator2));
            }
        }
        public string GenPhaseTotalIndicator2
        {
            get { return _genphasetotalindicator2; }
            set
            {
                _genphasetotalindicator2 = value;
                OnPropertyChanged(nameof(GenPhaseTotalIndicator2));
            }
        }
        public string GenVoltLLAvgIndicator2
        {
            get { return _genvoltllavgindicator2; }
            set
            {
                _genvoltllavgindicator2 = value;
                OnPropertyChanged(nameof(GenVoltLLAvgIndicator2));
            }
        }
        public string GenVoltLLDiffIndicator2
        {
            get { return _genvoltlldiffindicator2; }
            set
            {
                _genvoltlldiffindicator2 = value;
                OnPropertyChanged(nameof(GenVoltLLDiffIndicator2));
            }
        }
        public string GenVoltLLMinIndicator2
        {
            get { return _genvoltllminindicator2; }
            set
            {
                _genvoltllminindicator2 = value;
                OnPropertyChanged(nameof(GenVoltLLMinIndicator2));
            }
        }
        public string GenVoltLLMaxIndicator2
        {
            get { return _genvoltllmaxindicator2; }
            set
            {
                _genvoltllmaxindicator2 = value;
                OnPropertyChanged(nameof(GenVoltLLMaxIndicator2));
            }
        }
        public string GenRotationIndicator2
        {
            get { return _genrotationindicator2; }
            set
            {
                _genrotationindicator2 = value;
                OnPropertyChanged(nameof(GenRotationIndicator2));
            }
        }
        public string GenCurrentAveIndicator2
        {
            get { return _gencurrentaveindicator2; }
            set
            {
                _gencurrentaveindicator2 = value;
                OnPropertyChanged(nameof(GenCurrentAveIndicator2));
            }
        }
        public string GenCurrentDiffIndicator2
        {
            get { return _gencurrentdiffindicator2; }
            set
            {
                _gencurrentdiffindicator2 = value;
                OnPropertyChanged(nameof(GenCurrentDiffIndicator2));
            }
        }
        #endregion
        public string GenFreqTimestamp
        {
            get { return _genfreqtimestamp; }
            set
            {
                _genfreqtimestamp = value;
                OnPropertyChanged(nameof(GenFreqTimestamp));
            }
        }
        public string GenL3VoltsTimestamp
        {
            get { return _genl3voltstimestamp; }
            set
            {
                _genl3voltstimestamp = value;
                OnPropertyChanged(nameof(GenL3VoltsTimestamp));
            }
        }
        public string GenL1L2VoltsTimestamp
        {
            get { return _genl1l2voltstimestamp; }
            set
            {
                _genl1l2voltstimestamp = value;
                OnPropertyChanged(nameof(GenL1L2VoltsTimestamp));
            }
        }
        public string GenL2L3VoltsTimestamp
        {
            get { return _genl2l3voltstimestamp; }
            set
            {
                _genl2l3voltstimestamp = value;
                OnPropertyChanged(nameof(GenL2L3VoltsTimestamp));
            }
        }
        public string GenL3L1VoltsTimestamp
        {
            get { return _genl3l1voltstimestamp; }
            set
            {
                _genl3l1voltstimestamp = value;
                OnPropertyChanged(nameof(GenL3L1VoltsTimestamp));
            }
        }
        public string GenL3CurrentTimestamp
        {
            get { return _genl3currenttimestamp; }
            set
            {
                _genl3currenttimestamp = value;
                OnPropertyChanged(nameof(GenL3CurrentTimestamp));
            }
        }
        public string GenECurrentTimestamp
        {
            get { return _genecurrenttimestamp; }
            set
            {
                _genecurrenttimestamp = value;
                OnPropertyChanged(nameof(GenECurrentTimestamp));
            }
        }
        public string GenL3WattsTimestamp
        {
            get { return _genl3wattstimestamp; }
            set
            {
                _genl3wattstimestamp = value;
                OnPropertyChanged(nameof(GenL3WattsTimestamp));
            }
        }
        public string GenWattsTotalTimestamp
        {
            get { return _genwattstotaltimestamp; }
            set
            {
                _genwattstotaltimestamp = value;
                OnPropertyChanged(nameof(GenWattsTotalTimestamp));
            }
        }
        public string GenTotalVaTimestamp
        {
            get { return _gentotalvatimestamp; }
            set
            {
                _gentotalvatimestamp = value;
                OnPropertyChanged(nameof(GenTotalVaTimestamp));
            }
        }
        public string GenaVgPowerFactorTimestamp
        {
            get { return _genavgpowerfactortimestamp; }
            set
            {
                _genavgpowerfactortimestamp = value;
                OnPropertyChanged(nameof(GenaVgPowerFactorTimestamp));
            }
        }
        public string GenL1CurrentTimestamp
        {
            get { return _genl1currenttimestamp; }
            set
            {
                _genl1currenttimestamp = value;
                OnPropertyChanged(nameof(GenL1CurrentTimestamp));
            }
        }
        public string GenL2CurrentTimestamp
        {
            get { return _genl2currenttimestamp; }
            set
            {
                _genl2currenttimestamp = value;
                OnPropertyChanged(nameof(GenL2CurrentTimestamp));
            }
        }
        public string GenL1VATimestamp
        {
            get { return _genl1vatimestamp; }
            set
            {
                _genl1vatimestamp = value;
                OnPropertyChanged(nameof(GenL1VATimestamp));
            }
        }
        public string GenL2VATimestamp
        {
            get { return _genl2vatimestamp; }
            set
            {
                _genl2vatimestamp = value;
                OnPropertyChanged(nameof(GenL2VATimestamp));
            }
        }
        public string GenL3VATimestamp
        {
            get { return _genl3vatimestamp; }
            set
            {
                _genl3vatimestamp = value;
                OnPropertyChanged(nameof(GenL3VATimestamp));
            }
        }
        public string GenPowerfactorL1Timestamp
        {
            get { return _genpowerfactorl1timestamp; }
            set
            {
                _genpowerfactorl1timestamp = value;
                OnPropertyChanged(nameof(GenPowerfactorL1Timestamp));
            }
        }
        public string GenPowerfactorL2Timestamp
        {
            get { return _genpowerfactorl2timestamp; }
            set
            {
                _genpowerfactorl2timestamp = value;
                OnPropertyChanged(nameof(GenPowerfactorL2Timestamp));
            }
        }
        public string GenPowerfactorL3Timestamp
        {
            get { return _genpowerfactorl3timestamp; }
            set
            {
                _genpowerfactorl3timestamp = value;
                OnPropertyChanged(nameof(GenPowerfactorL3Timestamp));
            }
        }
        public string GenPhase1Timestamp
        {
            get { return _genphase1timestamp; }
            set
            {
                _genphase1timestamp = value;
                OnPropertyChanged(nameof(GenPhase1Timestamp));
            }
        }
        public string GenPhase2Timestamp
        {
            get { return _genphase2timestamp; }
            set
            {
                _genphase2timestamp = value;
                OnPropertyChanged(nameof(GenPhase2Timestamp));
            }
        }
        public string GenPhase3Timestamp
        {
            get { return _genphase3timestamp; }
            set
            {
                _genphase3timestamp = value;
                OnPropertyChanged(nameof(GenPhase3Timestamp));
            }
        }
        public string GenPhaseTotalTimestamp
        {
            get { return _genphasetotaltimestamp; }
            set
            {
                _genphasetotaltimestamp = value;
                OnPropertyChanged(nameof(GenPhaseTotalTimestamp));
            }
        }
        public string GenVoltLLAvgTimestamp
        {
            get { return _genvoltllavgtimestamp; }
            set
            {
                _genvoltllavgtimestamp = value;
                OnPropertyChanged(nameof(GenVoltLLAvgTimestamp));
            }
        }
        public string GenVoltLLDiffTimestamp
        {
            get { return _genvoltlldifftimestamp; }
            set
            {
                _genvoltlldifftimestamp = value;
                OnPropertyChanged(nameof(GenVoltLLDiffTimestamp));
            }
        }
        public string GenVoltLLMinTimestamp
        {
            get { return _genvoltllmintimestamp; }
            set
            {
                _genvoltllmintimestamp = value;
                OnPropertyChanged(nameof(GenVoltLLMinTimestamp));
            }
        }
        public string GenVoltLLMaxTimestamp
        {
            get { return _genvoltllmaxtimestamp; }
            set
            {
                _genvoltllmaxtimestamp = value;
                OnPropertyChanged(nameof(GenVoltLLMaxTimestamp));
            }
        }
        public string GenRotationTimestamp
        {
            get { return _genrotationtimestamp; }
            set
            {
                _genrotationtimestamp = value;
                OnPropertyChanged(nameof(GenRotationTimestamp));
            }
        }
        public string GenCurrentAveTimestamp
        {
            get { return _gencurrentavetimestamp; }
            set
            {
                _gencurrentavetimestamp = value;
                OnPropertyChanged(nameof(GenCurrentAveTimestamp));
            }
        }
        public string GenCurrentDiffTimestamp
        {
            get { return _gencurrentdifftimestamp; }
            set
            {
                _gencurrentdifftimestamp = value;
                OnPropertyChanged(nameof(GenCurrentDiffTimestamp));
            }
        }
        #region Gen time2
        public string GenFreqTimestamp2
        {
            get { return _genfreqtimestamp2; }
            set
            {
                _genfreqtimestamp2 = value;
                OnPropertyChanged(nameof(GenFreqTimestamp2));
            }
        }
        public string GenL3VoltsTimestamp2
        {
            get { return _genl3voltstimestamp2; }
            set
            {
                _genl3voltstimestamp2 = value;
                OnPropertyChanged(nameof(GenL3VoltsTimestamp2));
            }
        }
        public string GenL1L2VoltsTimestamp2
        {
            get { return _genl1l2voltstimestamp2; }
            set
            {
                _genl1l2voltstimestamp2 = value;
                OnPropertyChanged(nameof(GenL1L2VoltsTimestamp2));
            }
        }
        public string GenL2L3VoltsTimestamp2
        {
            get { return _genl2l3voltstimestamp2; }
            set
            {
                _genl2l3voltstimestamp2 = value;
                OnPropertyChanged(nameof(GenL2L3VoltsTimestamp2));
            }
        }
        public string GenL3L1VoltsTimestamp2
        {
            get { return _genl3l1voltstimestamp2; }
            set
            {
                _genl3l1voltstimestamp2 = value;
                OnPropertyChanged(nameof(GenL3L1VoltsTimestamp2));
            }
        }
        public string GenL3CurrentTimestamp2
        {
            get { return _genl3currenttimestamp2; }
            set
            {
                _genl3currenttimestamp2 = value;
                OnPropertyChanged(nameof(GenL3CurrentTimestamp2));
            }
        }
        public string GenECurrentTimestamp2
        {
            get { return _genecurrenttimestamp2; }
            set
            {
                _genecurrenttimestamp2 = value;
                OnPropertyChanged(nameof(GenECurrentTimestamp2));
            }
        }
        public string GenL3WattsTimestamp2
        {
            get { return _genl3wattstimestamp2; }
            set
            {
                _genl3wattstimestamp2 = value;
                OnPropertyChanged(nameof(GenL3WattsTimestamp2));
            }
        }
        public string GenWattsTotalTimestamp2
        {
            get { return _genwattstotaltimestamp2; }
            set
            {
                _genwattstotaltimestamp2 = value;
                OnPropertyChanged(nameof(GenWattsTotalTimestamp2));
            }
        }
        public string GenTotalVaTimestamp2
        {
            get { return _gentotalvatimestamp2; }
            set
            {
                _gentotalvatimestamp2 = value;
                OnPropertyChanged(nameof(GenTotalVaTimestamp2));
            }
        }
        public string GenaVgPowerFactorTimestamp2
        {
            get { return _genavgpowerfactortimestamp2; }
            set
            {
                _genavgpowerfactortimestamp2 = value;
                OnPropertyChanged(nameof(GenaVgPowerFactorTimestamp2));
            }
        }
        public string GenL1CurrentTimestamp2
        {
            get { return _genl1currenttimestamp2; }
            set
            {
                _genl1currenttimestamp2 = value;
                OnPropertyChanged(nameof(GenL1CurrentTimestamp2));
            }
        }
        public string GenL2CurrentTimestamp2
        {
            get { return _genl2currenttimestamp2; }
            set
            {
                _genl2currenttimestamp2 = value;
                OnPropertyChanged(nameof(GenL2CurrentTimestamp2));
            }
        }
        public string GenL1VATimestamp2
        {
            get { return _genl1vatimestamp2; }
            set
            {
                _genl1vatimestamp2 = value;
                OnPropertyChanged(nameof(GenL1VATimestamp2));
            }
        }
        public string GenL2VATimestamp2
        {
            get { return _genl2vatimestamp2; }
            set
            {
                _genl2vatimestamp2 = value;
                OnPropertyChanged(nameof(GenL2VATimestamp2));
            }
        }
        public string GenL3VATimestamp2
        {
            get { return _genl3vatimestamp2; }
            set
            {
                _genl3vatimestamp2 = value;
                OnPropertyChanged(nameof(GenL3VATimestamp2));
            }
        }
        public string GenPowerfactorL1Timestamp2
        {
            get { return _genpowerfactorl1timestamp2; }
            set
            {
                _genpowerfactorl1timestamp2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL1Timestamp2));
            }
        }
        public string GenPowerfactorL2Timestamp2
        {
            get { return _genpowerfactorl2timestamp2; }
            set
            {
                _genpowerfactorl2timestamp2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL2Timestamp2));
            }
        }
        public string GenPowerfactorL3Timestamp2
        {
            get { return _genpowerfactorl3timestamp2; }
            set
            {
                _genpowerfactorl3timestamp2 = value;
                OnPropertyChanged(nameof(GenPowerfactorL3Timestamp2));
            }
        }
        public string GenPhase1Timestamp2
        {
            get { return _genphase1timestamp2; }
            set
            {
                _genphase1timestamp2 = value;
                OnPropertyChanged(nameof(GenPhase1Timestamp2));
            }
        }
        public string GenPhase2Timestamp2
        {
            get { return _genphase2timestamp2; }
            set
            {
                _genphase2timestamp2 = value;
                OnPropertyChanged(nameof(GenPhase2Timestamp2));
            }
        }
        public string GenPhase3Timestamp2
        {
            get { return _genphase3timestamp2; }
            set
            {
                _genphase3timestamp2 = value;
                OnPropertyChanged(nameof(GenPhase3Timestamp2));
            }
        }
        public string GenPhaseTotalTimestamp2
        {
            get { return _genphasetotaltimestamp2; }
            set
            {
                _genphasetotaltimestamp2 = value;
                OnPropertyChanged(nameof(GenPhaseTotalTimestamp2));
            }
        }
        public string GenVoltLLAvgTimestamp2
        {
            get { return _genvoltllavgtimestamp2; }
            set
            {
                _genvoltllavgtimestamp2 = value;
                OnPropertyChanged(nameof(GenVoltLLAvgTimestamp2));
            }
        }
        public string GenVoltLLDiffTimestamp2
        {
            get { return _genvoltlldifftimestamp2; }
            set
            {
                _genvoltlldifftimestamp2 = value;
                OnPropertyChanged(nameof(GenVoltLLDiffTimestamp2));
            }
        }
        public string GenVoltLLMinTimestamp2
        {
            get { return _genvoltllmintimestamp2; }
            set
            {
                _genvoltllmintimestamp2 = value;
                OnPropertyChanged(nameof(GenVoltLLMinTimestamp2));
            }
        }
        public string GenVoltLLMaxTimestamp2
        {
            get { return _genvoltllmaxtimestamp2; }
            set
            {
                _genvoltllmaxtimestamp2 = value;
                OnPropertyChanged(nameof(GenVoltLLMaxTimestamp2));
            }
        }
        public string GenRotationTimestamp2
        {
            get { return _genrotationtimestamp2; }
            set
            {
                _genrotationtimestamp2 = value;
                OnPropertyChanged(nameof(GenRotationTimestamp2));
            }
        }
        public string GenCurrentAveTimestamp2
        {
            get { return _gencurrentavetimestamp2; }
            set
            {
                _gencurrentavetimestamp2 = value;
                OnPropertyChanged(nameof(GenCurrentAveTimestamp2));
            }
        }
        public string GenCurrentDiffTimestamp2
        {
            get { return _gencurrentdifftimestamp2; }
            set
            {
                _gencurrentdifftimestamp2 = value;
                OnPropertyChanged(nameof(GenCurrentDiffTimestamp2));
            }
        }
        #endregion
        #endregion

        #region Engine Group
        public string EngOilPress
        {
            get { return _engoilpress; }
            set
            {
                _engoilpress = value;
                OnPropertyChanged(nameof(EngOilPress));
            }
        }
        public string EngOilPress2
        {
            get { return _engoilpress2; }
            set
            {
                _engoilpress2 = value;
                OnPropertyChanged(nameof(EngOilPress2));
            }
        }
        public string EngTemp
        {
            get { return _engtemp; }
            set
            {
                _engtemp = value;
                OnPropertyChanged(nameof(EngTemp));
            }
        }
        public string EngTemp2
        {
            get { return _engtemp2; }
            set
            {
                _engtemp2 = value;
                OnPropertyChanged(nameof(EngTemp2));
            }
        }
        public string EngOilTemp
        {
            get { return _engoiltemp; }
            set
            {
                _engoiltemp = value;
                OnPropertyChanged(nameof(EngOilTemp));
            }
        } 
        public string EngOilTemp2
        {
            get { return _engoiltemp2; }
            set
            {
                _engoiltemp2 = value;
                OnPropertyChanged(nameof(EngOilTemp2));
            }
        }
        public string EngFuelLevel
        {
            get { return _engfuellevel; }
            set
            {
                _engfuellevel = value;
                OnPropertyChanged(nameof(EngFuelLevel));
            }
        }
        public string EngFuelLevel2
        {
            get { return _engfuellevel2; }
            set
            {
                _engfuellevel2 = value;
                OnPropertyChanged(nameof(EngFuelLevel2));
            }
        }
        public string EngChargeAltVolts
        {
            get { return _engchargealtvolts; }
            set
            {
                _engchargealtvolts = value;
                OnPropertyChanged(nameof(EngChargeAltVolts));
            }
        }
        public string EngChargeAltVolts2
        {
            get { return _engchargealtvolts2; }
            set
            {
                _engchargealtvolts2 = value;
                OnPropertyChanged(nameof(EngChargeAltVolts2));
            }
        }
        public string EngBatteryVolts
        {
            get { return _engbatteryvolts; }
            set
            {
                _engbatteryvolts = value;
                OnPropertyChanged(nameof(EngBatteryVolts));
            }
        }
        public string EngBatteryVolts2
        {
            get { return _engbatteryvolts2; }
            set
            {
                _engbatteryvolts2 = value;
                OnPropertyChanged(nameof(EngBatteryVolts2));
            }
        }
        public string EngModHours
        {
            get { return _engmodhours; }
            set
            {
                _engmodhours = value;
                OnPropertyChanged(nameof(EngModHours));
            }
        }
        public string EngModHours2
        {
            get { return _engmodhours2; }
            set
            {
                _engmodhours2 = value;
                OnPropertyChanged(nameof(EngModHours2));
            }
        }

        public string EngSpeedDisplay
        {
            get { return _engspeeddisplay; }
            set
            {
                _engspeeddisplay = value;
                OnPropertyChanged(nameof(EngSpeedDisplay));
            }
        }
        public string EngSpeedDisplay2
        {
            get { return _engspeeddisplay2; }
            set
            {
                _engspeeddisplay2 = value;
                OnPropertyChanged(nameof(EngSpeedDisplay2));
            }
        }
        public string EngCoolantP1
        {
            get { return _engcoolantp1; }
            set
            {
                _engcoolantp1 = value;
                OnPropertyChanged(nameof(EngCoolantP1));
            }
        }
        public string EngCoolantP1_2
        {
            get { return _engcoolantp1_2; }
            set
            {
                _engcoolantp1_2 = value;
                OnPropertyChanged(nameof(EngCoolantP1_2));
            }
        }
        public string EngCoolantP2
        {
            get { return _engcoolantp2; }
            set
            {
                _engcoolantp2 = value;
                OnPropertyChanged(nameof(EngCoolantP2));
            }
        }
        public string EngCoolantP2_2
        {
            get { return _engcoolantp2_2; }
            set
            {
                _engcoolantp2_2 = value;
                OnPropertyChanged(nameof(EngCoolantP2_2));
            }
        }
        public string EngTurboP1
        {
            get { return _engturbop1; }
            set
            {
                _engturbop1 = value;
                OnPropertyChanged(nameof(EngTurboP1));
            }
        }
        public string EngTurboP1_2
        {
            get { return _engturbop1_2; }
            set
            {
                _engturbop1_2 = value;
                OnPropertyChanged(nameof(EngTurboP1_2));
            }
        }
        public string EngTurboP2
        {
            get { return _engturbop2; }
            set
            {
                _engturbop2 = value;
                OnPropertyChanged(nameof(EngTurboP2));
            }
        }
        public string EngTurboP2_2
        {
            get { return _engturbop2_2; }
            set
            {
                _engturbop2_2 = value;
                OnPropertyChanged(nameof(EngTurboP2_2));
            }
        }
        public string EngExhaustT1
        {
            get { return _engexhaustt1; }
            set
            {
                _engexhaustt1 = value;
                OnPropertyChanged(nameof(EngExhaustT1));
            }
        }
        public string EngExhaustT1_2
        {
            get { return _engexhaustt1_2; }
            set
            {
                _engexhaustt1_2 = value;
                OnPropertyChanged(nameof(EngExhaustT1_2));
            }
        }
        public string EngExhaustT2
        {
            get { return _engexhaustt2; }
            set
            {
                _engexhaustt2 = value;
                OnPropertyChanged(nameof(EngExhaustT2));
            }
        }
        public string EngExhaustT2_2
        {
            get { return _engexhaustt2_2; }
            set
            {
                _engexhaustt2_2 = value;
                OnPropertyChanged(nameof(EngExhaustT2_2));
            }
        }
        public string EngFuelConsumption
        {
            get { return _engfuelconsumption; }
            set
            {
                _engfuelconsumption = value;
                OnPropertyChanged(nameof(EngFuelConsumption));
            }
        }
        public string EngFuelConsumption2
        {
            get { return _engfuelconsumption2; }
            set
            {
                _engfuelconsumption2 = value;
                OnPropertyChanged(nameof(EngFuelConsumption2));
            }
        }
        public string EngOilLevel
        {
            get { return _engoillevel; }
            set
            {
                _engoillevel = value;
                OnPropertyChanged(nameof(EngOilLevel));

            }
        }
        public string EngOilLevel2
        {
            get { return _engoillevel2; }
            set
            {
                _engoillevel2 = value;
                OnPropertyChanged(nameof(EngOilLevel2));

            }
        }
        public string EngCoolantLevel
        {
            get { return _engcoolentlevel; }
            set
            {
                _engcoolentlevel = value;
                OnPropertyChanged(nameof(EngCoolantLevel));

            }
        }
        public string EngCoolantLevel2
        {
            get { return _engcoolentlevel2; }
            set
            {
                _engcoolentlevel2 = value;
                OnPropertyChanged(nameof(EngCoolantLevel2));

            }
        }
        public string EngFanSpeed
        {
            get { return _engfanspeed; }
            set
            {
                _engfanspeed = value;
                OnPropertyChanged(nameof(EngFanSpeed));

            }
        }
        public string EngFanSpeed2
        {
            get { return _engfanspeed2; }
            set
            {
                _engfanspeed2 = value;
                OnPropertyChanged(nameof(EngFanSpeed2));

            }
        }
        public string EngTurboOilTemp
        {
            get { return _engturbooiltemp; }
            set
            {
                _engturbooiltemp = value;
                OnPropertyChanged(nameof(EngTurboOilTemp));

            }
        }
        public string EngTurboOilTemp2
        {
            get { return _engturbooiltemp2; }
            set
            {
                _engturbooiltemp2 = value;
                OnPropertyChanged(nameof(EngTurboOilTemp2));

            }
        }
        public string EngOperatingStage
        {
            get { return _engoperatingstage; }
            set
            {
                _engoperatingstage = value;
                OnPropertyChanged(nameof(EngOperatingStage));

            }
        }
        public string EngOperatingStage2
        {
            get { return _engoperatingstage2; }
            set
            {
                _engoperatingstage2 = value;
                OnPropertyChanged(nameof(EngOperatingStage2));

            }
        }
        public string EngModSpeedFeed
        {
            get { return _engmodspeedfeed; }
            set
            {
                _engmodspeedfeed = value;
                OnPropertyChanged(nameof(EngModSpeedFeed));

            }
        } 
        public string EngModSpeedFeed2
        {
            get { return _engmodspeedfeed2; }
            set
            {
                _engmodspeedfeed2 = value;
                OnPropertyChanged(nameof(EngModSpeedFeed2));

            }
        }
        public string EngModFreqAdj
        {
            get { return _engmodfreqadj; }
            set
            {
                _engmodfreqadj = value;
                OnPropertyChanged(nameof(EngModFreqAdj));

            }
        }
        public string EngModFreqAdj2
        {
            get { return _engmodfreqadj2; }
            set
            {
                _engmodfreqadj2 = value;
                OnPropertyChanged(nameof(EngModFreqAdj2));

            }
        }
        public string EngBattCurrent
        {
            get { return _engbattcurrent; }
            set
            {
                _engbattcurrent = value;
                OnPropertyChanged(nameof(EngBattCurrent));

            }
        }
        public string EngBattCurrent2
        {
            get { return _engbattcurrent2; }
            set
            {
                _engbattcurrent2 = value;
                OnPropertyChanged(nameof(EngBattCurrent2));

            }
        }
        public string EngChargePotential
        {
            get { return _engchargepotential; }
            set
            {
                _engchargepotential = value;
                OnPropertyChanged(nameof(EngChargePotential));

            }
        }
        public string EngChargePotential2
        {
            get { return _engchargepotential2; }
            set
            {
                _engchargepotential2 = value;
                OnPropertyChanged(nameof(EngChargePotential2));

            }
        }
        public string EngDemandSpeed
        {
            get { return _engdemandedspeed; }
            set
            {
                _engdemandedspeed = value;
                OnPropertyChanged(nameof(EngDemandSpeed));

            }
        }
        public string EngDemandSpeed2
        {
            get { return _engdemandedspeed2; }
            set
            {
                _engdemandedspeed2 = value;
                OnPropertyChanged(nameof(EngDemandSpeed2));

            }
        }
        public string EngFuelRate
        {
            get { return _engfuelrate; }
            set
            {
                _engfuelrate = value;
                OnPropertyChanged(nameof(EngFuelRate));

            }
        } 
        public string EngFuelRate2
        {
            get { return _engfuelrate2; }
            set
            {
                _engfuelrate2 = value;
                OnPropertyChanged(nameof(EngFuelRate2));

            }
        }
        public string EngOilPressIndicator
        {
            get { return _engoilpressindicator; }
            set
            {
                _engoilpressindicator = value;
                OnPropertyChanged(nameof(EngOilPressIndicator));
            }
        }
        public string EngTempIndicator
        {
            get { return _engtempindicator; }
            set
            {
                _engtempindicator = value;
                OnPropertyChanged(nameof(EngTempIndicator));
            }
        }
        public string EngOilTempIndicator
        {
            get { return _engoiltempindicator; }
            set
            {
                _engoiltempindicator = value;
                OnPropertyChanged(nameof(EngOilTempIndicator));
            }
        }
        public string EngFuelLevelIndicator
        {
            get { return _engfuellevelindicator; }
            set
            {
                _engfuellevelindicator = value;
                OnPropertyChanged(nameof(EngFuelLevelIndicator));
            }
        }
        public string EngChargeAltVoltsIndicator
        {
            get { return _engchargealtvoltsindicator; }
            set
            {
                _engchargealtvoltsindicator = value;
                OnPropertyChanged(nameof(EngChargeAltVoltsIndicator));
            }
        }
        public string EngBatteryVoltsIndicator
        {
            get { return _engbatteryvoltsindicator; }
            set
            {
                _engbatteryvoltsindicator = value;
                OnPropertyChanged(nameof(EngBatteryVoltsIndicator));
            }
        }
        public string EngModHoursIndicator
        {
            get { return _engmodhoursindicator; }
            set
            {
                _engmodhoursindicator = value;
                OnPropertyChanged(nameof(EngModHoursIndicator));
            }
        }


        public string EngSpeedDisplayIndicator
        {
            get { return _engspeeddisplayindicator; }
            set
            {
                _engspeeddisplayindicator = value;
                OnPropertyChanged(nameof(EngSpeedDisplayIndicator));
            }
        }
        public string EngCoolantP1Indicator
        {
            get { return _engcoolantp1indicator; }
            set
            {
                _engcoolantp1indicator = value;
                OnPropertyChanged(nameof(EngCoolantP1Indicator));
            }
        }
        public string EngCoolantP2Indicator
        {
            get { return _engcoolantp2indicator; }
            set
            {
                _engcoolantp2indicator = value;
                OnPropertyChanged(nameof(EngCoolantP2Indicator));
            }
        }
        public string EngTurboP1Indicator
        {
            get { return _engturbop1indicator; }
            set
            {
                _engturbop1indicator = value;
                OnPropertyChanged(nameof(EngTurboP1Indicator));
            }
        }
        public string EngTurboP2Indicator
        {
            get { return _engturbop2indicator; }
            set
            {
                _engturbop2indicator = value;
                OnPropertyChanged(nameof(EngTurboP2Indicator));
            }
        }
        public string EngExhaustT1Indicator
        {
            get { return _engexhaustt1indicator; }
            set
            {
                _engexhaustt1indicator = value;
                OnPropertyChanged(nameof(EngExhaustT1Indicator));
            }
        }
        public string EngExhaustT2Indicator
        {
            get { return _engexhaustt2indicator; }
            set
            {
                _engexhaustt2indicator = value;
                OnPropertyChanged(nameof(EngExhaustT2Indicator));
            }
        }
        public string EngFuelConsumptionIndicator
        {
            get { return _engfuelconsumptionindicator; }
            set
            {
                _engfuelconsumptionindicator = value;
                OnPropertyChanged(nameof(EngFuelConsumptionIndicator));
            }
        }
        public string EngOilLevelIndicator
        {
            get { return _engoillevelindicator; }
            set
            {
                _engoillevelindicator = value;
                OnPropertyChanged(nameof(EngOilLevelIndicator));

            }
        }
        public string EngCoolantLevelIndicator
        {
            get { return _engcoolentlevelindicator; }
            set
            {
                _engcoolentlevelindicator = value;
                OnPropertyChanged(nameof(EngCoolantLevelIndicator));

            }
        }
        public string EngFanSpeedIndicator
        {
            get { return _engfanspeedindicator; }
            set
            {
                _engfanspeedindicator = value;
                OnPropertyChanged(nameof(EngFanSpeedIndicator));

            }
        }
        public string EngTurboOilTempIndicator
        {
            get { return _engturbooiltempindicator; }
            set
            {
                _engturbooiltempindicator = value;
                OnPropertyChanged(nameof(EngTurboOilTempIndicator));

            }
        }
        public string EngOperatingStageIndicator
        {
            get { return _engoperatingstageindicator; }
            set
            {
                _engoperatingstageindicator = value;
                OnPropertyChanged(nameof(EngOperatingStageIndicator));

            }
        }
        public string EngModSpeedFeedIndicator
        {
            get { return _engmodspeedfeedindicator; }
            set
            {
                _engmodspeedfeedindicator = value;
                OnPropertyChanged(nameof(EngModSpeedFeedIndicator));

            }
        }
        public string EngModFreqAdjIndicator
        {
            get { return _engmodfreqadjindicator; }
            set
            {
                _engmodfreqadjindicator = value;
                OnPropertyChanged(nameof(EngModFreqAdjIndicator));

            }
        }
        public string EngBattCurrentIndicator
        {
            get { return _engbattcurrentindicator; }
            set
            {
                _engbattcurrentindicator = value;
                OnPropertyChanged(nameof(EngBattCurrentIndicator));

            }
        }
        public string EngChargePotentialIndicator
        {
            get { return _engchargepotentialindicator; }
            set
            {
                _engchargepotentialindicator = value;
                OnPropertyChanged(nameof(EngChargePotentialIndicator));

            }
        }
        public string EngDemandSpeedIndicator
        {
            get { return _engdemandedspeedindicator; }
            set
            {
                _engdemandedspeedindicator = value;
                OnPropertyChanged(nameof(EngDemandSpeedIndicator));

            }
        }
        public string EngFuelRateIndicator
        {
            get { return _engfuelrateindicator; }
            set
            {
                _engfuelrateindicator = value;
                OnPropertyChanged(nameof(EngFuelRateIndicator));

            }
        }
        #region eng indicator2
        public string EngOilPressIndicator2
        {
            get { return _engoilpressindicator2; }
            set
            {
                _engoilpressindicator2 = value;
                OnPropertyChanged(nameof(EngOilPressIndicator2));
            }
        }
        public string EngTempIndicator2
        {
            get { return _engtempindicator2; }
            set
            {
                _engtempindicator2 = value;
                OnPropertyChanged(nameof(EngTempIndicator2));
            }
        }
        public string EngOilTempIndicator2
        {
            get { return _engoiltempindicator2; }
            set
            {
                _engoiltempindicator2 = value;
                OnPropertyChanged(nameof(EngOilTempIndicator2));
            }
        }
        public string EngFuelLevelIndicator2
        {
            get { return _engfuellevelindicator2; }
            set
            {
                _engfuellevelindicator2 = value;
                OnPropertyChanged(nameof(EngFuelLevelIndicator2));
            }
        }
        public string EngChargeAltVoltsIndicator2
        {
            get { return _engchargealtvoltsindicator2; }
            set
            {
                _engchargealtvoltsindicator2 = value;
                OnPropertyChanged(nameof(EngChargeAltVoltsIndicator2));
            }
        }
        public string EngBatteryVoltsIndicator2
        {
            get { return _engbatteryvoltsindicator2; }
            set
            {
                _engbatteryvoltsindicator2 = value;
                OnPropertyChanged(nameof(EngBatteryVoltsIndicator2));
            }
        }
        public string EngModHoursIndicator2
        {
            get { return _engmodhoursindicator2; }
            set
            {
                _engmodhoursindicator2 = value;
                OnPropertyChanged(nameof(EngModHoursIndicator2));
            }
        }


        public string EngSpeedDisplayIndicator2
        {
            get { return _engspeeddisplayindicator2; }
            set
            {
                _engspeeddisplayindicator2 = value;
                OnPropertyChanged(nameof(EngSpeedDisplayIndicator2));
            }
        }
        public string EngCoolantP1Indicator2
        {
            get { return _engcoolantp1indicator2; }
            set
            {
                _engcoolantp1indicator2 = value;
                OnPropertyChanged(nameof(EngCoolantP1Indicator2));
            }
        }
        public string EngCoolantP2Indicator2
        {
            get { return _engcoolantp2indicator2; }
            set
            {
                _engcoolantp2indicator2 = value;
                OnPropertyChanged(nameof(EngCoolantP2Indicator2));
            }
        }
        public string EngTurboP1Indicator2
        {
            get { return _engturbop1indicator2; }
            set
            {
                _engturbop1indicator2 = value;
                OnPropertyChanged(nameof(EngTurboP1Indicator2));
            }
        }
        public string EngTurboP2Indicator2
        {
            get { return _engturbop2indicator2; }
            set
            {
                _engturbop2indicator2 = value;
                OnPropertyChanged(nameof(EngTurboP2Indicator2));
            }
        }
        public string EngExhaustT1Indicator2
        {
            get { return _engexhaustt1indicator2; }
            set
            {
                _engexhaustt1indicator2 = value;
                OnPropertyChanged(nameof(EngExhaustT1Indicator2));
            }
        }
        public string EngExhaustT2Indicator2
        {
            get { return _engexhaustt2indicator2; }
            set
            {
                _engexhaustt2indicator2 = value;
                OnPropertyChanged(nameof(EngExhaustT2Indicator2));
            }
        }
        public string EngFuelConsumptionIndicator2
        {
            get { return _engfuelconsumptionindicator2; }
            set
            {
                _engfuelconsumptionindicator2 = value;
                OnPropertyChanged(nameof(EngFuelConsumptionIndicator2));
            }
        }
        public string EngOilLevelIndicator2
        {
            get { return _engoillevelindicator2; }
            set
            {
                _engoillevelindicator2 = value;
                OnPropertyChanged(nameof(EngOilLevelIndicator2));

            }
        }
        public string EngCoolantLevelIndicator2
        {
            get { return _engcoolentlevelindicator2; }
            set
            {
                _engcoolentlevelindicator2 = value;
                OnPropertyChanged(nameof(EngCoolantLevelIndicator2));

            }
        }
        public string EngFanSpeedIndicator2
        {
            get { return _engfanspeedindicator2; }
            set
            {
                _engfanspeedindicator2 = value;
                OnPropertyChanged(nameof(EngFanSpeedIndicator2));

            }
        }
        public string EngTurboOilTempIndicator2
        {
            get { return _engturbooiltempindicator2; }
            set
            {
                _engturbooiltempindicator2 = value;
                OnPropertyChanged(nameof(EngTurboOilTempIndicator2));

            }
        }
        public string EngOperatingStageIndicator2
        {
            get { return _engoperatingstageindicator2; }
            set
            {
                _engoperatingstageindicator2 = value;
                OnPropertyChanged(nameof(EngOperatingStageIndicator2));

            }
        }
        public string EngModSpeedFeedIndicator2
        {
            get { return _engmodspeedfeedindicator2; }
            set
            {
                _engmodspeedfeedindicator2 = value;
                OnPropertyChanged(nameof(EngModSpeedFeedIndicator2));

            }
        }
        public string EngModFreqAdjIndicator2
        {
            get { return _engmodfreqadjindicator2; }
            set
            {
                _engmodfreqadjindicator2 = value;
                OnPropertyChanged(nameof(EngModFreqAdjIndicator2));

            }
        }
        public string EngBattCurrentIndicator2
        {
            get { return _engbattcurrentindicator2; }
            set
            {
                _engbattcurrentindicator2 = value;
                OnPropertyChanged(nameof(EngBattCurrentIndicator2));

            }
        }
        public string EngChargePotentialIndicator2
        {
            get { return _engchargepotentialindicator2; }
            set
            {
                _engchargepotentialindicator2 = value;
                OnPropertyChanged(nameof(EngChargePotentialIndicator2));

            }
        }
        public string EngDemandSpeedIndicator2
        {
            get { return _engdemandedspeedindicator2; }
            set
            {
                _engdemandedspeedindicator2 = value;
                OnPropertyChanged(nameof(EngDemandSpeedIndicator2));

            }
        }
        public string EngFuelRateIndicator2
        {
            get { return _engfuelrateindicator2; }
            set
            {
                _engfuelrateindicator2 = value;
                OnPropertyChanged(nameof(EngFuelRateIndicator2));

            }
        }
        #endregion
        public string EngOilPressTimestamp
        {
            get { return _engoilpresstimestamp; }
            set
            {
                _engoilpresstimestamp = value;
                OnPropertyChanged(nameof(EngOilPressTimestamp));
            }
        }
        public string EngTempTimestamp
        {
            get { return _engtemptimestamp; }
            set
            {
                _engtemptimestamp = value;
                OnPropertyChanged(nameof(EngTempTimestamp));
            }
        }
        public string EngOilTempTimestamp
        {
            get { return _engoiltemptimestamp; }
            set
            {
                _engoiltemptimestamp = value;
                OnPropertyChanged(nameof(EngOilTempTimestamp));
            }
        }
        public string EngFuelLevelTimestamp
        {
            get { return _engfuelleveltimestamp; }
            set
            {
                _engfuelleveltimestamp = value;
                OnPropertyChanged(nameof(EngFuelLevelTimestamp));
            }
        }
        public string EngChargeAltVoltsTimestamp
        {
            get { return _engchargealtvoltstimestamp; }
            set
            {
                _engchargealtvoltstimestamp = value;
                OnPropertyChanged(nameof(EngChargeAltVoltsTimestamp));
            }
        }
        public string EngBatteryVoltsTimestamp
        {
            get { return _engbatteryvoltstimestamp; }
            set
            {
                _engbatteryvoltstimestamp = value;
                OnPropertyChanged(nameof(EngBatteryVoltsTimestamp));
            }
        }
        public string EngModHoursTimestamp
        {
            get { return _engmodhourstimestamp; }
            set
            {
                _engmodhourstimestamp = value;
                OnPropertyChanged(nameof(EngModHoursTimestamp));
            }
        }
        public string EngSpeedDisplayTimestamp
        {
            get { return _engspeeddisplaytimestamp; }
            set
            {
                _engspeeddisplaytimestamp = value;
                OnPropertyChanged(nameof(EngSpeedDisplayTimestamp));
            }
        }
        public string EngCoolantP1Timestamp
        {
            get { return _engcoolantp1timestamp; }
            set
            {
                _engcoolantp1timestamp = value;
                OnPropertyChanged(nameof(EngCoolantP1Timestamp));
            }
        }
        public string EngCoolantP2Timestamp
        {
            get { return _engcoolantp2timestamp; }
            set
            {
                _engcoolantp2timestamp = value;
                OnPropertyChanged(nameof(EngCoolantP2Timestamp));
            }
        }
        public string EngTurboP1Timestamp
        {
            get { return _engturbop1timestamp; }
            set
            {
                _engturbop1timestamp = value;
                OnPropertyChanged(nameof(EngTurboP1Timestamp));
            }
        }
        public string EngTurboP2Timestamp
        {
            get { return _engturbop2timestamp; }
            set
            {
                _engturbop2timestamp = value;
                OnPropertyChanged(nameof(EngTurboP2Timestamp));
            }
        }
        public string EngExhaustT1Timestamp
        {
            get { return _engexhaustt1timestamp; }
            set
            {
                _engexhaustt1timestamp = value;
                OnPropertyChanged(nameof(EngExhaustT1Timestamp));
            }
        }
        public string EngExhaustT2Timestamp
        {
            get { return _engexhaustt2timestamp; }
            set
            {
                _engexhaustt2timestamp = value;
                OnPropertyChanged(nameof(EngExhaustT2Timestamp));
            }
        }
        public string EngFuelConsumptionTimestamp
        {
            get { return _engfuelconsumptiontimestamp; }
            set
            {
                _engfuelconsumptiontimestamp = value;
                OnPropertyChanged(nameof(EngFuelConsumptionTimestamp));
            }
        }
        public string EngOilLevelTimestamp
        {
            get { return _engoilleveltimestamp; }
            set
            {
                _engoilleveltimestamp = value;
                OnPropertyChanged(nameof(EngOilLevelTimestamp));

            }
        }
        public string EngCoolantLevelTimestamp
        {
            get { return _engcoolentleveltimestamp; }
            set
            {
                _engcoolentleveltimestamp = value;
                OnPropertyChanged(nameof(EngCoolantLevelTimestamp));

            }
        }
        public string EngFanSpeedTimestamp
        {
            get { return _engfanspeedtimestamp; }
            set
            {
                _engfanspeedtimestamp = value;
                OnPropertyChanged(nameof(EngFanSpeedTimestamp));

            }
        }
        public string EngTurboOilTempTimestamp
        {
            get { return _engturbooiltemptimestamp; }
            set
            {
                _engturbooiltemptimestamp = value;
                OnPropertyChanged(nameof(EngTurboOilTempTimestamp));

            }
        }
        public string EngOperatingStageTimestamp
        {
            get { return _engoperatingstagetimestamp; }
            set
            {
                _engoperatingstagetimestamp = value;
                OnPropertyChanged(nameof(EngOperatingStageTimestamp));

            }
        }
        public string EngModSpeedFeedTimestamp
        {
            get { return _engmodspeedfeedtimestamp; }
            set
            {
                _engmodspeedfeedtimestamp = value;
                OnPropertyChanged(nameof(EngModSpeedFeedTimestamp));

            }
        }
        public string EngModFreqAdjTimestamp
        {
            get { return _engmodfreqadjtimestamp; }
            set
            {
                _engmodfreqadjtimestamp = value;
                OnPropertyChanged(nameof(EngModFreqAdjTimestamp));

            }
        }
        public string EngBattCurrentTimestamp
        {
            get { return _engbattcurrenttimestamp; }
            set
            {
                _engbattcurrenttimestamp = value;
                OnPropertyChanged(nameof(EngBattCurrentTimestamp));

            }
        }
        public string EngChargePotentialTimestamp
        {
            get { return _engchargepotentialtimestamp; }
            set
            {
                _engchargepotentialtimestamp = value;
                OnPropertyChanged(nameof(EngChargePotentialTimestamp));

            }
        }
        public string EngDemandSpeedTimestamp
        {
            get { return _engdemandedspeedtimestamp; }
            set
            {
                _engdemandedspeedtimestamp = value;
                OnPropertyChanged(nameof(EngDemandSpeedTimestamp));

            }
        }
        public string EngFuelRateTimestamp
        {
            get { return _engfuelratetimestamp; }
            set
            {
                _engfuelratetimestamp = value;
                OnPropertyChanged(nameof(EngFuelRateTimestamp));

            }
        }
        #region Eng time2
        public string EngOilPressTimestamp2
        {
            get { return _engoilpresstimestamp2; }
            set
            {
                _engoilpresstimestamp2 = value;
                OnPropertyChanged(nameof(EngOilPressTimestamp2));
            }
        }
        public string EngTempTimestamp2
        {
            get { return _engtemptimestamp2; }
            set
            {
                _engtemptimestamp2 = value;
                OnPropertyChanged(nameof(EngTempTimestamp2));
            }
        }
        public string EngOilTempTimestamp2
        {
            get { return _engoiltemptimestamp2; }
            set
            {
                _engoiltemptimestamp2 = value;
                OnPropertyChanged(nameof(EngOilTempTimestamp2));
            }
        }
        public string EngFuelLevelTimestamp2
        {
            get { return _engfuelleveltimestamp2; }
            set
            {
                _engfuelleveltimestamp2 = value;
                OnPropertyChanged(nameof(EngFuelLevelTimestamp2));
            }
        }
        public string EngChargeAltVoltsTimestamp2
        {
            get { return _engchargealtvoltstimestamp2; }
            set
            {
                _engchargealtvoltstimestamp2 = value;
                OnPropertyChanged(nameof(EngChargeAltVoltsTimestamp2));
            }
        }
        public string EngBatteryVoltsTimestamp2
        {
            get { return _engbatteryvoltstimestamp2; }
            set
            {
                _engbatteryvoltstimestamp2 = value;
                OnPropertyChanged(nameof(EngBatteryVoltsTimestamp2));
            }
        }
        public string EngModHoursTimestamp2
        {
            get { return _engmodhourstimestamp2; }
            set
            {
                _engmodhourstimestamp2 = value;
                OnPropertyChanged(nameof(EngModHoursTimestamp2));
            }
        }
        public string EngSpeedDisplayTimestamp2
        {
            get { return _engspeeddisplaytimestamp2; }
            set
            {
                _engspeeddisplaytimestamp2 = value;
                OnPropertyChanged(nameof(EngSpeedDisplayTimestamp2));
            }
        }
        public string EngCoolantP1Timestamp2
        {
            get { return _engcoolantp1timestamp2; }
            set
            {
                _engcoolantp1timestamp2 = value;
                OnPropertyChanged(nameof(EngCoolantP1Timestamp2));
            }
        }
        public string EngCoolantP2Timestamp2
        {
            get { return _engcoolantp2timestamp2; }
            set
            {
                _engcoolantp2timestamp2 = value;
                OnPropertyChanged(nameof(EngCoolantP2Timestamp2));
            }
        }
        public string EngTurboP1Timestamp2
        {
            get { return _engturbop1timestamp2; }
            set
            {
                _engturbop1timestamp2 = value;
                OnPropertyChanged(nameof(EngTurboP1Timestamp2));
            }
        }
        public string EngTurboP2Timestamp2
        {
            get { return _engturbop2timestamp2; }
            set
            {
                _engturbop2timestamp2 = value;
                OnPropertyChanged(nameof(EngTurboP2Timestamp2));
            }
        }
        public string EngExhaustT1Timestamp2
        {
            get { return _engexhaustt1timestamp2; }
            set
            {
                _engexhaustt1timestamp2 = value;
                OnPropertyChanged(nameof(EngExhaustT1Timestamp2));
            }
        }
        public string EngExhaustT2Timestamp2
        {
            get { return _engexhaustt2timestamp2; }
            set
            {
                _engexhaustt2timestamp2 = value;
                OnPropertyChanged(nameof(EngExhaustT2Timestamp2));
            }
        }
        public string EngFuelConsumptionTimestamp2
        {
            get { return _engfuelconsumptiontimestamp2; }
            set
            {
                _engfuelconsumptiontimestamp2 = value;
                OnPropertyChanged(nameof(EngFuelConsumptionTimestamp2));
            }
        }
        public string EngOilLevelTimestamp2
        {
            get { return _engoilleveltimestamp2; }
            set
            {
                _engoilleveltimestamp2 = value;
                OnPropertyChanged(nameof(EngOilLevelTimestamp2));

            }
        }
        public string EngCoolantLevelTimestamp2
        {
            get { return _engcoolentleveltimestamp2; }
            set
            {
                _engcoolentleveltimestamp2 = value;
                OnPropertyChanged(nameof(EngCoolantLevelTimestamp2));

            }
        }
        public string EngFanSpeedTimestamp2
        {
            get { return _engfanspeedtimestamp2; }
            set
            {
                _engfanspeedtimestamp2 = value;
                OnPropertyChanged(nameof(EngFanSpeedTimestamp2));

            }
        }
        public string EngTurboOilTempTimestamp2
        {
            get { return _engturbooiltemptimestamp2; }
            set
            {
                _engturbooiltemptimestamp2 = value;
                OnPropertyChanged(nameof(EngTurboOilTempTimestamp2));

            }
        }
        public string EngOperatingStageTimestamp2
        {
            get { return _engoperatingstagetimestamp2; }
            set
            {
                _engoperatingstagetimestamp2 = value;
                OnPropertyChanged(nameof(EngOperatingStageTimestamp2));

            }
        }
        public string EngModSpeedFeedTimestamp2
        {
            get { return _engmodspeedfeedtimestamp2; }
            set
            {
                _engmodspeedfeedtimestamp2 = value;
                OnPropertyChanged(nameof(EngModSpeedFeedTimestamp2));

            }
        }
        public string EngModFreqAdjTimestamp2
        {
            get { return _engmodfreqadjtimestamp2; }
            set
            {
                _engmodfreqadjtimestamp2 = value;
                OnPropertyChanged(nameof(EngModFreqAdjTimestamp2));

            }
        }
        public string EngBattCurrentTimestamp2
        {
            get { return _engbattcurrenttimestamp2; }
            set
            {
                _engbattcurrenttimestamp2 = value;
                OnPropertyChanged(nameof(EngBattCurrentTimestamp2));

            }
        }
        public string EngChargePotentialTimestamp2
        {
            get { return _engchargepotentialtimestamp2; }
            set
            {
                _engchargepotentialtimestamp2 = value;
                OnPropertyChanged(nameof(EngChargePotentialTimestamp2));

            }
        }
        public string EngDemandSpeedTimestamp2
        {
            get { return _engdemandedspeedtimestamp2; }
            set
            {
                _engdemandedspeedtimestamp2 = value;
                OnPropertyChanged(nameof(EngDemandSpeedTimestamp2));

            }
        }
        public string EngFuelRateTimestamp2
        {
            get { return _engfuelratetimestamp2; }
            set
            {
                _engfuelratetimestamp2 = value;
                OnPropertyChanged(nameof(EngFuelRateTimestamp2));

            }
        }
        #endregion

        #endregion
        public string SubSystemIP
        {
            get { return _subsystemip; }
            set
            {
                _subsystemip = value;
                OnPropertyChanged(nameof(SubSystemIP));
            }
        }
        public string PrameterName
        {
            get { return _prametername; }
            set
            {
                _prametername = value;
                OnPropertyChanged(nameof(PrameterName));
            }
        }
        public string UnitName
        {
            get { return _Unitname; }
            set
            {
                _Unitname = value;
                OnPropertyChanged(nameof(UnitName));
            }
        }
        public string PrameterValue
        {
            get { return _prametervalue; }
            set
            {
                _prametervalue = value;
                OnPropertyChanged(nameof(PrameterValue));
            }
        }
        public string TimeStamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = value;
                OnPropertyChanged(nameof(TimeStamp));
            }
        }
        public bool IsLeftSliderShow
        {
            get { return _isleftslidershow; }
            set
            {
                _isleftslidershow = value;
                OnPropertyChanged(nameof(IsLeftSliderShow));
            }
        }
        public bool IsDashbordScreenEnable
        {
            get { return _isdashbordscreenenable; }
            set
            {
                _isdashbordscreenenable = value;
                OnPropertyChanged(nameof(IsDashbordScreenEnable));
            }
        }
        public bool IsConfigurationEnable
        {
            get { return _isconfigurationenable; }
            set
            {
                _isconfigurationenable = value;
                OnPropertyChanged(nameof(IsConfigurationEnable));
            }
        }
        public bool IsManageArchiveEnable
        {
            get { return _ismanagearchiveenable; }
            set
            {
                _ismanagearchiveenable = value;
                OnPropertyChanged(nameof(IsManageArchiveEnable));
            }
        }
        public bool IsLineGraphEnable
        {
            get { return _islinegraphenable; }
            set
            {
                _islinegraphenable = value;
                OnPropertyChanged(nameof(IsLineGraphEnable));
            }
        }
        public bool IsReport
        {
            get { return _isReport; }
            set
            {
                _isReport = value;
                OnPropertyChanged(nameof(IsReport));
            }
        }
        public bool IsManageUserEnable
        {
            get { return _ismanageuserenable; }
            set
            {
                _ismanageuserenable = value;
                OnPropertyChanged(nameof(IsManageUserEnable));
            }
        }
        public bool? IsNavigationEnable
        {
            get { return _isnavigationenable; }
            set
            {
                _isnavigationenable = value;
                OnPropertyChanged(nameof(IsNavigationEnable));
            }
        }
        public bool? IsSubsystemsPanelOne
        {
            get { return _issubsystemspanelone; }
            set
            {
                _issubsystemspanelone = value;
                OnPropertyChanged(nameof(IsSubsystemsPanelOne));
            }
        }
        public bool? IsSubsystemsPanelTwo
        {
            get { return _issubsystemspaneltwo; }
            set
            {
                _issubsystemspaneltwo = value;
                OnPropertyChanged(nameof(IsSubsystemsPanelTwo));
            }
        }
        public bool? IsSubsystemsPanelThree
        {
            get { return _issubsystemspanelthree; }
            set
            {
                _issubsystemspanelthree = value;
                OnPropertyChanged(nameof(IsSubsystemsPanelThree));
            }
        }
        public bool? IsSubsystemsPanelFour 
        {
            get { return _issubsystemspanelfour; }
            set
            {
                _issubsystemspanelfour = value;
                OnPropertyChanged(nameof(IsSubsystemsPanelFour));
            }
        }
        public bool? IsManageUserTabEnable
        {
            get { return _ismanageusertabenable; }
            set
            {
                _ismanageusertabenable = value;
                OnPropertyChanged(nameof(IsManageUserTabEnable));
            }
        }
        public CollectionView DgTrapCollection
        {
            get { return _dgtrapcollection; }
            set
            {
                _dgtrapcollection = value;
                OnPropertyChanged(nameof(DgTrapCollection));
            }
        }
        public CollectionView DgTrapCollection2
        {
            get { return _dgtrapcollection2; }
            set
            {
                _dgtrapcollection2 = value;
                OnPropertyChanged(nameof(DgTrapCollection2));
            }
        }
        public CollectionView RouterTrapcollection
        {
            get { return _routertrapcollection; }
            set
            {
                _routertrapcollection = value;
                OnPropertyChanged(nameof(RouterTrapcollection));
            }
        }
        public CollectionView RouterTrapcollection2
        {
            get { return _routertrapcollection2; }
            set
            {
                _routertrapcollection2 = value;
                OnPropertyChanged(nameof(RouterTrapcollection2));
            }
        }
        public CollectionView RadioTrapcollection
        {
            get { return _radiotrapcollection; }
            set
            {
                _radiotrapcollection = value;
                OnPropertyChanged(nameof(RadioTrapcollection));
            }
        }
        public CollectionView RadioTrapcollection2
        {
            get { return _radiotrapcollection2; }
            set
            {
                _radiotrapcollection2 = value;
                OnPropertyChanged(nameof(RadioTrapcollection2));
            }
        }
        public CollectionView SwitchTrapcollection
        {
            get { return _switchtrapcollection; }
            set
            {
                _switchtrapcollection = value;
                OnPropertyChanged(nameof(SwitchTrapcollection));
            }
        }
        public CollectionView SwitchTrapcollection2
        {
            get { return _switchtrapcollection2; }
            set
            {
                _switchtrapcollection2 = value;
                OnPropertyChanged(nameof(SwitchTrapcollection2));
            }
        }
        public CollectionView UpsTrapcollection
        { 
            get { return _upstrapcollection; }
            set
            {
                _upstrapcollection = value;
                OnPropertyChanged(nameof(UpsTrapcollection));
            }
        }
        public CollectionView UpsTrapcollection2
        {
            get { return _upstrapcollection2; }
            set
            {
                _upstrapcollection2 = value;
                OnPropertyChanged(nameof(UpsTrapcollection2));
            }
        }
        #region eng time2
      
#endregion
    }
}
