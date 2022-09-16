using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej_js
{
    public class OrgChartItem
    {
        #region members
        private int _id = 0;
        private string _name = string.Empty;
        private string _title = string.Empty;
        private List<OrgChartItem> _children;
        #endregion

        #region properties
        public int id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public string title { get => _title; set => _title = value; }
        public List<OrgChartItem> children { get => _children; set => _children = value; }
        #endregion

        #region constructor
        public OrgChartItem(int id, string name, string title)
        {
            this.id = id;
            this.name = name;
            this.title = title;
            this.children = new List<OrgChartItem>();
        }
        #endregion

        #region methods
        public OrgChartItem GetItem()
        {
            return this;
        }
        #endregion
    }
}