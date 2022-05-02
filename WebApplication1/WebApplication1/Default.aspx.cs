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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        public IEnumerable<TestEntities.PermissionEntity> GridView1_GetData()
        {
            PermissionBL permissionBL = new PermissionBL();
            List<PermissionEntity> permissions = permissionBL.All();

            return permissions;
        }

        protected void newPermission_Click(object sender, EventArgs e)
        {
            
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridView1_UpdateItem(int id)
        {
            TestEntities.PermissionEntity item = null;
            PermissionBL permissionBL = new PermissionBL();
            item = permissionBL.Find(id);

            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                permissionBL.Update(item);

            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridView1_DeleteItem(int id)
        {
            PermissionBL permissionBL = new PermissionBL();
            permissionBL.Delete(id);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Enabled = false;
            e.Row.Cells[4].Enabled = false;
        }
    }
}