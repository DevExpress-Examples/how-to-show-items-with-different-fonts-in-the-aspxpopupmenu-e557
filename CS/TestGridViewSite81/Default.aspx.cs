using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Collections;
using DevExpress.Web.ASPxEditors;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.Web.ASPxPopupControl;
using DevExpress.Web.ASPxPanel;
using System.Globalization;
using DevExpress.Web.ASPxClasses.Internal;
using DevExpress.Web.ASPxClasses;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Data;
using DevExpress.Web.ASPxTitleIndex;
using DevExpress.Web.ASPxNavBar;
using DevExpress.Web.ASPxGridView;
using DevExpress.XtraPrinting;

public partial class _Default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        
    }

    protected void ASPxPopupMenu1_PopupElementResolve(object sender, ControlResolveEventArgs e) {
        e.ResolvedControl = ASPxButton1;
    }
}
