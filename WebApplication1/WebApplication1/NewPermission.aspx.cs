using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestBL;
using TestEntities;

namespace WebApplication1
{
    public partial class NewPermission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<TestEntities.PermissionTypeEntity> permissionType_GetData()
        {
            PermissionTypeBL permissionTypeBL = new PermissionTypeBL();
            List<PermissionTypeEntity> permissionTypes = permissionTypeBL.All();

            permissionTypes.Insert(0, new PermissionTypeEntity { Id = -1, Description = "(Select one)" });

            return permissionTypes;
        }

        protected void saveData_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                PermissionEntity permission = new PermissionEntity
                {
                    EmployeeLastName = employeeName.Text,
                    EmployeeName= employeeLastName.Text,
                    PermissionTypeId = Convert.ToInt32( permissionType.SelectedValue),
                    PermissionDate = DateTime.Now
                };

                PermissionBL permissionBL = new PermissionBL();
                try
                {
                    permissionBL.Add(permission);
                }
                catch (Exception)
                {

                }

                Server.Transfer("Default.aspx");
            }
        }
    }
}