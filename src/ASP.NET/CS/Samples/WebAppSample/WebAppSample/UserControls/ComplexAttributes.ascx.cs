using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMOD.UserControls
{
    public partial class ComplexAttributes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region "Private Methods"
        void BindGridView(string workOrder)
        {
            //  WorkPerformedDS.SelectParameters["WORKORDER"].DefaultValue = workOrder;
            grdAttributes.DataBind();
        }
        #endregion

        #region Public Methods
        internal void BindData(string workOrder)
        {
            BindGridView(workOrder);

        }

        internal void SetDataBaseParametersControlID(string selectionControlID)
        {
            ControlParameter SelectParameter = (ControlParameter)AttributesDS.SelectParameters["WorkOrder"];
            SelectParameter.ControlID = selectionControlID;

        }

        #endregion


    }
}