//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlazorDemo.Reports.Subreports {
    
    public partial class DetailReport : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "BlazorDemo.Reports.Subreports.DetailReport.repx");

            // Controls
            this.GroupHeader0 = reportInitializer.GetControl<DevExpress.XtraReports.UI.GroupHeaderBand>("GroupHeader0");
            this.Detail = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail");
            this.GroupFooter0 = reportInitializer.GetControl<DevExpress.XtraReports.UI.GroupFooterBand>("GroupFooter0");
            this.topMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("topMarginBand1");
            this.bottomMarginBand1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("bottomMarginBand1");
            this.xrTable1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable1");
            this.xrTableRow1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow1");
            this.xrTableCell1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell1");
            this.xrTableCell10 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell10");
            this.xrTableCell2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell2");
            this.xrTableCell13 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell13");
            this.xrTableCell16 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell16");
            this.xrTableCell3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell3");
            this.xrTable2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable2");
            this.xrTableRow2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow2");
            this.clNo = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clNo");
            this.clID = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clID");
            this.clDate = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clDate");
            this.clTime = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clTime");
            this.clPaymentType = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clPaymentType");
            this.clAmount = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clAmount");
            this.xrTable3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTable>("xrTable3");
            this.xrTableRow3 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableRow>("xrTableRow3");
            this.clOrderCount = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clOrderCount");
            this.xrTableCell8 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("xrTableCell8");
            this.clTotal = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRTableCell>("clTotal");

            // Parameters
            this.customerIDParameter = reportInitializer.GetParameter("customerIDParameter");
            this.dateRangeParameter = reportInitializer.GetParameter("dateRangeParameter");
            this.dateRangeParameter_Start = ((DevExpress.XtraReports.Parameters.RangeStartParameter)(reportInitializer.GetParameter("dateRangeParameter_Start")));
            this.dateRangeParameter_End = ((DevExpress.XtraReports.Parameters.RangeEndParameter)(reportInitializer.GetParameter("dateRangeParameter_End")));

            // Data Sources
            this.dsOrders1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("dsOrders1");

            // Styles
            this.EvenStyle = reportInitializer.GetStyle("EvenStyle");
            this.OddStyle = reportInitializer.GetStyle("OddStyle");
        }
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader0;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter0;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell clNo;
        private DevExpress.XtraReports.UI.XRTableCell clID;
        private DevExpress.XtraReports.UI.XRTableCell clDate;
        private DevExpress.XtraReports.UI.XRTableCell clTime;
        private DevExpress.XtraReports.UI.XRTableCell clPaymentType;
        private DevExpress.XtraReports.UI.XRTableCell clAmount;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell clOrderCount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell clTotal;
        private DevExpress.DataAccess.Sql.SqlDataSource dsOrders1;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.Parameters.Parameter customerIDParameter;
        private DevExpress.XtraReports.Parameters.Parameter dateRangeParameter;
        private DevExpress.XtraReports.Parameters.RangeStartParameter dateRangeParameter_Start;
        private DevExpress.XtraReports.Parameters.RangeEndParameter dateRangeParameter_End;
    }
}
