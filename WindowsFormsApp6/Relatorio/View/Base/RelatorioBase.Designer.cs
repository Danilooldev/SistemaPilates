namespace Relatorios.View.Cadastros.Venda
{
    partial class RelatorioBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrNome = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotal = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle1";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitulo});
            this.TopMargin.HeightF = 71F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.50001F);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTitulo.SizeF = new System.Drawing.SizeF(750.9999F, 48.33333F);
            this.lblTitulo.StylePriority.UseFont = false;
            this.lblTitulo.StylePriority.UseTextAlignment = false;
            this.lblTitulo.Text = "00 - Nome do Relatório";
            this.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 48F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.BackColor = System.Drawing.Color.LightGray;
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle2
            // 
            this.xrControlStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.xrControlStyle2.Name = "xrControlStyle2";
            this.xrControlStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle3
            // 
            this.xrControlStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xrControlStyle3.Name = "xrControlStyle3";
            this.xrControlStyle3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 30.20833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrNome,
            this.xrTotal});
            this.ReportFooter.HeightF = 37.58335F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrNome
            // 
            this.xrNome.BackColor = System.Drawing.Color.Transparent;
            this.xrNome.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrNome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrNome.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.58333F);
            this.xrNome.Name = "xrNome";
            this.xrNome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrNome.SizeF = new System.Drawing.SizeF(580.6666F, 23F);
            this.xrNome.StylePriority.UseBackColor = false;
            this.xrNome.StylePriority.UseBorders = false;
            this.xrNome.StylePriority.UseFont = false;
            this.xrNome.StylePriority.UseTextAlignment = false;
            this.xrNome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTotal
            // 
            this.xrTotal.BackColor = System.Drawing.Color.Transparent;
            this.xrTotal.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTotal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTotal.LocationFloat = new DevExpress.Utils.PointFloat(580.6666F, 14.58333F);
            this.xrTotal.Name = "xrTotal";
            this.xrTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotal.SizeF = new System.Drawing.SizeF(160.3333F, 23F);
            this.xrTotal.StylePriority.UseBackColor = false;
            this.xrTotal.StylePriority.UseBorders = false;
            this.xrTotal.StylePriority.UseFont = false;
            this.xrTotal.StylePriority.UseTextAlignment = false;
            this.xrTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RelatorioBase
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(50, 49, 71, 48);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2,
            this.xrControlStyle3});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblTitulo;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle3;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrNome;
        private DevExpress.XtraReports.UI.XRLabel xrTotal;
    }
}
