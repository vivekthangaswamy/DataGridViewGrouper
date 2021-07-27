using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevDash.Controls;

namespace Test
{
    public partial class ExampleWithControl : FormBase
    {
        public ExampleWithControl()
        {
            InitializeComponent();

            //all that is done to get the datagridview to work with the grouping control, is adding the
            // DataGridViewGrouperControl and setting its DataGridView property to the grid
            // the grouper control can reuse existing DataGridViewGrouper components or creates its own (as is done here)

            
            //once the datagridview is set (in this case in the designer), the Grouper property can be used to set the grouping
            var grouper = this.dataGridViewGrouperControl1.Grouper;
            grouper.SetGroupOn("AString");

            //also valid:
            //grouper.SetGroupOn<TestData>(t => t.AString);
            //grouper.SetGroupOn(this.dataGridView1.Columns["AString"]);


            //all options available in the control (via the dropdown menu) can be set in code as well and vice versa all options in this example can be set via the control.

            //to start with all rows collapsed on a (re)load or when the group is changed you can set the option startcollapsed:
            //grouper.Options.StartCollapsed = true;

            //to collapse all loaded rows: (the difference with setting the option above, is that after choosing a new grouping (or on a reload), the new groups would expand.
            //grouper.CollapseAll();

            //if you don't want the (rowcount) to be shown in the headers:
            //grouper.Options.ShowCount = false;

            //if you don't want the grouped column name to be repeated in the headers:
            //grouper.Options.ShowGroupName = false;

            //default sort order for the groups is ascending, you can change that in the options as well (ascending, descending or none)
            //grouper.Options.GroupSortOrder = SortOrder.Descending;

            //besides grouping on a property/column value, you can set a custom group:
            //grouper.SetCustomGroup<TestData>(t => t.AnInt % 10, "Mod 10");

            //to customize the grouping display, you can attach to the DisplayGroup event:
            //grouper.DisplayGroup += grouper_DisplayGroup;
        }


        //optionally, you can customize the grouping display by subscribing to the DisplayGroup event
        void grouper_DisplayGroup(object sender, GroupDisplayEventArgs e)
        {
            e.BackColor = (e.Group.GroupIndex % 2) == 0 ? Color.Orange : Color.LightBlue;
            e.Header = "[" + e.Header + "], grp: " + e.Group.GroupIndex;
            e.DisplayValue = "Value is " + e.DisplayValue;
            e.Summary = "contains " + e.Group.Count + " rows";
        }
    }
}
