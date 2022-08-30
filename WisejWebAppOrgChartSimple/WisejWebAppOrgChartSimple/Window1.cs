using System;
using Wisej.Core;
using Wisej.Web;

namespace WisejWebAppOrgChartSimple
{
    public partial class Window1 : Form
    {
        private object orgChartData;

        public Window1()
        {
            InitializeComponent();

            CreateOrgChartData();
        }

        [WebMethod]
        public object GetOrgChartData()
        {
            return this.orgChartData;
        }

        private void CreateOrgChartData()
        {
            orgChartData = new
            {
                name = "Günter",
                title = "Manager",
                children = new[] {
                    new {
                        name = "Heike",
                        title = "Senior Developter"
                    },
                    new {
                        name = "Michael",
                        title = "Senior Developer"
                    }
                }
            };
        }

        private void widget1_WidgetEvent(object sender, WidgetEventArgs e)
        {
            switch (e.Type)
            {
                case "nodeClick":
                    AlertBox.Show("You clicked: " + e.Data);
                    break;
            }
        }
    }
}