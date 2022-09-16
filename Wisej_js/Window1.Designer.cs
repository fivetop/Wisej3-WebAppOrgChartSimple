namespace Wisej_js
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            this.widgetOrgChart = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widgetOrgChart
            // 
            this.widgetOrgChart.InitScript = resources.GetString("widgetOrgChart.InitScript");
            this.widgetOrgChart.Location = new System.Drawing.Point(34, 42);
            this.widgetOrgChart.Name = "widgetOrgChart";
            this.widgetOrgChart.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "jquery.js";
            package1.Source = "/HTML/js/jquery.min.js";
            package2.Name = "orgchart.js";
            package2.Source = "/HTML/js/jquery.orgchart.js";
            package3.Name = "orgchart.css";
            package3.Source = "/HTML/css/jquery.orgchart.css";
            this.widgetOrgChart.Packages.Add(package1);
            this.widgetOrgChart.Packages.Add(package2);
            this.widgetOrgChart.Packages.Add(package3);
            this.widgetOrgChart.Size = new System.Drawing.Size(742, 455);
            this.widgetOrgChart.TabIndex = 0;
            this.widgetOrgChart.Text = "widget1";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 633);
            this.Controls.Add(this.widgetOrgChart);
            this.Name = "Window1";
            this.Text = "Window1";
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Widget widgetOrgChart;
    }
}

