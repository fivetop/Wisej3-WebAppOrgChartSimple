
using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej_js
{
	public partial class Window1 : Form
	{
		#region members
		private object orgChartData = null;
		bool showIcons = true;
		bool showPhoto = true;
		#endregion

		public Window1()
		{
			InitializeComponent();

			this.widgetOrgChart.Eval("this.getContentElement().addClass(\"orgchartcustomized\")");

			orgChartData = CreateData();

		}

        #region methods
        private object CreateData()
        {
            OrgChartItem orgChartItem = new OrgChartItem(1, "Günter", "Manager");
            FormatItem(orgChartItem);

            OrgChartItem orgChartItemChild = new OrgChartItem(2, "David", "Senior Developer");
            orgChartItem.children.Add(orgChartItemChild);
            FormatItem(orgChartItemChild);

            OrgChartItem orgChartItemChild2 = new OrgChartItem(3, "Florian", "Developer");
            orgChartItemChild.children.Add(orgChartItemChild2);
            FormatItem(orgChartItemChild2);

            orgChartItemChild2 = new OrgChartItem(4, "Sascha", "Developer");
            orgChartItemChild.children.Add(orgChartItemChild2);
            FormatItem(orgChartItemChild2);

            orgChartItemChild = new OrgChartItem(5, "Niko", "Senior Developer");
            orgChartItem.children.Add(orgChartItemChild);
            FormatItem(orgChartItemChild);

            orgChartItemChild2 = new OrgChartItem(6, "Susi", "Developer");
            orgChartItemChild.children.Add(orgChartItemChild2);
            FormatItem(orgChartItemChild2);
            orgChartItemChild2 = new OrgChartItem(7, "Karin", "Developer");
            orgChartItemChild.children.Add(orgChartItemChild2);
            FormatItem(orgChartItemChild2);


            return orgChartItem;
        }


        // 자바 스크립트에서 보내온 이벤트 처리 
        private void widgetOrgChart_WidgetEvent(object sender, WidgetEventArgs e)
        {
            switch (e.Type)
            {
                case "nodeClick":
                    AlertBox.Show("You clicked: " + e.Data);
                    break;
                case "nodeDropEvent":
                    AlertBox.Show("You dropped: " + e.Data);
                    break;
            }
        }

        private void FormatItem(OrgChartItem item)
        {
            MakeHeader(item);
            MakeContent(item);
        }

        private void MakeHeader(OrgChartItem item)
        {
            string headerText = item.name;

            string headerStyle = "padding:2px; text-align:left; ";
            string headerIcons = "";

            //Build Header
            if (showIcons)
            {
                headerIcons += (headerIcons == "" ? "" : "&nbsp;") + "<img src=\"" + "/images/fecher-logo.png" + "\" width=15>";
            }
            string headerTableStyle = "border-radius: 10px 10px 0 0; ";
            headerTableStyle += "background-color:" + "navajowhite" + ";";

            string header = "<table width=\"100%\" style=\"" + headerTableStyle + "\"><tr>";
            if (headerIcons != "") header += "<td width=\"1%\" style=\"" + headerStyle + "\">" + headerIcons + "</td>";
            header += "<td style=\"" + headerStyle + "\">" + headerText + "</td>";
            header += "</tr></table>";

            item.name = header;
        }

        private void MakeContent(OrgChartItem item)
        {
            string contentText = item.title;
            short textAlignment = 1;

            // CONTENT - picture and text

            string contentStyle = "padding:2px;";
            if (textAlignment == 0)
                contentStyle += " text-align: left;";
            else if (textAlignment == 1)
                contentStyle += " text-align: center;";
            else if (textAlignment == 2)
                contentStyle += " text-align: right;";

            contentStyle += "background-color:" + "sandybrown" + ";";
            string contentPhoto = "";
            if (showPhoto && item.id != 0)
            {
                contentPhoto += "<img src=\"" + "/images/" + item.id + ".jpg" + "\" width=50>";
                contentPhoto += "</td><td style=\"" + contentStyle + "\">";
            }
            string content = "<table width=\"100%\"><tr><td style=\"" + contentStyle + "\">" + contentPhoto;
            content += contentText;
            content += "</td></tr></table>";

            item.title = content;
        }

        [WebMethod]
        public object GetOrgChartData()
        {
            return this.orgChartData;
        }
        #endregion

        #region Event-Actions
        private void btnChangeSource_Click(object sender, EventArgs e)
        {
            OrgChartItem orgChartItem = new OrgChartItem(1, "Michael", "Manager");
            FormatItem(orgChartItem);

            OrgChartItem orgChartItemChild = new OrgChartItem(2, "Peter", "Senior Developer");
            orgChartItem.children.Add(orgChartItemChild);
            FormatItem(orgChartItemChild);

            orgChartItemChild = new OrgChartItem(3, "Karl", "Developer");
            orgChartItem.children.Add(orgChartItemChild);
            FormatItem(orgChartItemChild);

            orgChartData = orgChartItem;

            // 스크립트 호출
            this.widgetOrgChart.Call("reload");
        }
        #endregion

    }
}
