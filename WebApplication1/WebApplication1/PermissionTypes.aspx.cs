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
    public partial class PermissionTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IEnumerable<TestEntities.PermissionTypeEntity> GridView1_GetData()
        {
            PermissionTypeBL permissionTypeBL = new PermissionTypeBL();
            List<PermissionTypeEntity> permissions = permissionTypeBL.All();

            return permissions;
        }

        protected void newPermission_Click(object sender, EventArgs e)
        {

        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridView1_UpdateItem(int id)
        {
            TestEntities.PermissionTypeEntity item = null;
            PermissionTypeBL permissionTypeBL = new PermissionTypeBL();
            item = permissionTypeBL.Find(id);

            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                permissionTypeBL.Update(item);

            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridView1_DeleteItem(int id)
        {
            PermissionTypeBL permissionTypeBL = new PermissionTypeBL();
            permissionTypeBL.Delete(id);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Enabled = false;
        }
    }
}