using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestBL;
using TestEntities;

namespace WebApplication1
{
    public partial class PermissionType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void saveData_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                PermissionTypeEntity permission = new PermissionTypeEntity
                {
                    Description = description.Text
                };

                PermissionTypeBL permissionTypeBL = new PermissionTypeBL();
                try
                {
                    permissionTypeBL.Add(permission);
                }
                catch (Exception)
                {

                }

                Server.Transfer("PermissionTypes.aspx");
            }
        }
    }
}