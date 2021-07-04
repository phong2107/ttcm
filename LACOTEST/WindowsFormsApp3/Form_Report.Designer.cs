
namespace WindowsFormsApp3
{
    partial class Form_Report
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.USPGetHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.USPGetHoaDonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// USPGetHoaDonBindingSource
			// 
			this.USPGetHoaDonBindingSource.DataMember = "USP_GetHoaDon";
			// 
			// reportViewer3
			// 
			this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer3.DocumentMapWidth = 46;
			this.reportViewer3.Location = new System.Drawing.Point(0, 0);
			this.reportViewer3.Name = "reportViewer3";
			this.reportViewer3.ServerReport.BearerToken = null;
			this.reportViewer3.Size = new System.Drawing.Size(904, 577);
			this.reportViewer3.TabIndex = 1;
			// 
			// Form_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 577);
			this.Controls.Add(this.reportViewer3);
			this.Name = "Form_Report";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Report";
			this.Load += new System.EventHandler(this.Form_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.USPGetHoaDonBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USPGetHoaDonBindingSource;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;

		//private System.Windows.Forms.BindingSource USP_GetHoaDonBindingSource;
	}
}