using System;
using System.Collections.Generic;

namespace JBHRIS.Api.Dal.JBHR
{
    public partial class ChkOtNightFood
    {
        public string Rote { get; set; }
        public decimal? 應給金額 { get; set; }
        public decimal? 實際金額 { get; set; }
        public decimal? 差異金額 { get; set; }
        public string Nobr { get; set; }
        public DateTime Bdate { get; set; }
        public string Btime { get; set; }
        public string Etime { get; set; }
        public decimal TotHours { get; set; }
        public decimal OtHrs { get; set; }
        public decimal RestHrs { get; set; }
        public decimal OtCar { get; set; }
        public string OtDept { get; set; }
        public string KeyMan { get; set; }
        public DateTime KeyDate { get; set; }
        public decimal OtFood { get; set; }
        public string Note { get; set; }
        public decimal FoodPri { get; set; }
        public decimal FoodCnt { get; set; }
        public string Yymm { get; set; }
        public string Ser { get; set; }
        public decimal NotW133 { get; set; }
        public decimal NotW167 { get; set; }
        public decimal NotW200 { get; set; }
        public decimal NotH200 { get; set; }
        public decimal TotW100 { get; set; }
        public decimal TotW133 { get; set; }
        public decimal TotW167 { get; set; }
        public decimal TotW200 { get; set; }
        public decimal TotH200 { get; set; }
        public decimal NotExp { get; set; }
        public decimal TotExp { get; set; }
        public decimal RestExp { get; set; }
        public decimal FstHours { get; set; }
        public decimal Salary { get; set; }
        public bool Notmodi { get; set; }
        public string Otrcd { get; set; }
        public bool Nofood { get; set; }
        public bool FixAmt { get; set; }
        public decimal Rec { get; set; }
        public bool CantAdj { get; set; }
        public DateTime OtEdate { get; set; }
        public string Otno { get; set; }
        public string OtRote { get; set; }
        public decimal OtFood1 { get; set; }
        public decimal OtFoodh { get; set; }
        public decimal OtFoodh1 { get; set; }
        public decimal NopW133 { get; set; }
        public decimal NopW167 { get; set; }
        public decimal NopW200 { get; set; }
        public decimal NopH100 { get; set; }
        public decimal NopH133 { get; set; }
        public decimal NopH167 { get; set; }
        public decimal NopH200 { get; set; }
        public decimal TopW133 { get; set; }
        public decimal TopW167 { get; set; }
        public decimal TopW200 { get; set; }
        public decimal TopH200 { get; set; }
        public decimal NotH133 { get; set; }
        public decimal NotH167 { get; set; }
        public decimal Hot133 { get; set; }
        public decimal Hot166 { get; set; }
        public decimal Hot200 { get; set; }
        public decimal Wot133 { get; set; }
        public decimal Wot166 { get; set; }
        public decimal Wot200 { get; set; }
        public bool Sum { get; set; }
        public bool Syscreat { get; set; }
        public string OtrateCode { get; set; }
        public decimal NotW100 { get; set; }
        public decimal TopW100 { get; set; }
        public bool Syscreat1 { get; set; }
        public decimal NopW100 { get; set; }
        public bool SysOt { get; set; }
        public string Serno { get; set; }
        public decimal Diff { get; set; }
        public bool Eat { get; set; }
        public bool Res { get; set; }
        public bool Nofood1 { get; set; }
        public string Expr1 { get; set; }
        public DateTime Adate { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public DateTime Expr4 { get; set; }
        public decimal LateMins { get; set; }
        public decimal EMins { get; set; }
        public bool Abs { get; set; }
        public string AdjCode { get; set; }
        public bool Expr5 { get; set; }
        public decimal Expr6 { get; set; }
        public decimal NightHrs { get; set; }
        public decimal Foodamt { get; set; }
        public string Foodsalcd { get; set; }
        public decimal Forget { get; set; }
        public decimal AttHrs { get; set; }
        public decimal Nigamt { get; set; }
        public string Expr7 { get; set; }
        public string Rotename { get; set; }
        public string OnTime { get; set; }
        public string OffTime { get; set; }
        public string ResBTime { get; set; }
        public string ResETime { get; set; }
        public decimal WkHrs { get; set; }
        public decimal DkHrs { get; set; }
        public decimal MoHrs { get; set; }
        public string Offtime2 { get; set; }
        public string Expr8 { get; set; }
        public DateTime Expr9 { get; set; }
        public bool Overday { get; set; }
        public bool Night { get; set; }
        public decimal HoliMins { get; set; }
        public decimal WrHrsa { get; set; }
        public decimal WrHrsb { get; set; }
        public decimal Fcolor { get; set; }
        public decimal Bcolor { get; set; }
        public bool Ot { get; set; }
        public string ResB1Time { get; set; }
        public string ResE1Time { get; set; }
        public string ResB2Time { get; set; }
        public string ResE2Time { get; set; }
        public string ResB3Time { get; set; }
        public string ResE3Time { get; set; }
        public string ResB4Time { get; set; }
        public string ResE4Time { get; set; }
        public decimal YrrestHrs { get; set; }
        public bool Rate2 { get; set; }
        public bool Earaward { get; set; }
        public string Expr10 { get; set; }
        public decimal Expr11 { get; set; }
        public string Nightsalcd { get; set; }
        public decimal Nightamt { get; set; }
        public decimal Nightamt1 { get; set; }
        public bool Notfood { get; set; }
        public decimal Foodamt1 { get; set; }
        public decimal WkHrsa { get; set; }
        public decimal WkHrsb { get; set; }
        public decimal Alllates { get; set; }
        public string OtBegin { get; set; }
        public string Dd { get; set; }
        public string Calot { get; set; }
        public decimal Foodamto { get; set; }
        public string OverTime { get; set; }
        public string StrTime { get; set; }
        public string Specsalcd { get; set; }
        public decimal Specamt { get; set; }
        public decimal Specamt1 { get; set; }
        public decimal Specamt2 { get; set; }
        public decimal Alllates1 { get; set; }
        public string AttEnd { get; set; }
        public bool Helf { get; set; }
        public decimal BefNightamt { get; set; }
        public decimal AftNightamt { get; set; }
        public string Foodrule { get; set; }
        public string Nightrule { get; set; }
        public string Specrule { get; set; }
    }
}
