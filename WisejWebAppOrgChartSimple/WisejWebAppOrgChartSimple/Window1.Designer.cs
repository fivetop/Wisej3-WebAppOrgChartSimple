namespace WisejWebAppOrgChartSimple
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
            this.widget1 = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(116, 82);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "jquery.js";
            package1.Source = "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js";
            package2.Name = "orgchart.js";
            package2.Source = "https://cdnjs.cloudflare.com/ajax/libs/orgchart/2.1.3/js/jquery.orgchart.js";
            package3.Name = "orgchart.css";
            package3.Source = "https://cdnjs.cloudflare.com/ajax/libs/orgchart/2.1.3/css/jquery.orgchart.min.css" +
    "";
            this.widget1.Packages.Add(package1);
            this.widget1.Packages.Add(package2);
            this.widget1.Packages.Add(package3);
            this.widget1.Size = new System.Drawing.Size(643, 463);
            this.widget1.TabIndex = 0;
            this.widget1.Text = "widget1";
            this.widget1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widget1_WidgetEvent);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 586);
            this.Controls.Add(this.widget1);
            this.Name = "Window1";
            this.Text = "Window1";
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Widget widget1;
    }
}

