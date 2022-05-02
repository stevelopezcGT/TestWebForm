using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntities
{
    public class PermissionEntity
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        
        [ForeignKey("PermissionType")]
        public int PermissionTypeId { get; set; }
        public DateTime PermissionDate { get; set; }
        public PermissionTypeEntity PermissionType { get; set; }
        public string PermissionTypeDescription { get; set; }
    }
}
