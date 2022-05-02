using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL;
using TestEntities;

namespace TestBL
{
    public class PermissionBL
    {
        private TestDBEntities context;

        public PermissionBL()
        {
            context = new TestDBEntities();
        }

        public List<PermissionEntity> All()
        {
            List<PermissionEntity> permissions = new List<PermissionEntity>();
            context.Permissions.Include("PermissionType").ToList().ForEach(d =>
            {
                permissions.Add(new PermissionEntity
                {
                    EmployeeLastName = d.EmployeeLastName,
                    EmployeeName = d.EmployeeName,
                    Id=d.Id,
                    PermissionDate=d.PermissionDate,
                    PermissionTypeId = d.PermissionTypeId,
                    PermissionTypeDescription=d.PermissionType?.Description
                });
            });

            return permissions;
        }
        public int Add(PermissionEntity entity)
        {
            TestDBEntities context = new TestDBEntities();
            Permission permission = new Permission
            {
                EmployeeLastName = entity.EmployeeLastName,
                EmployeeName = entity.EmployeeName,
                PermissionDate = entity.PermissionDate,
                PermissionTypeId = entity.PermissionTypeId
            };

            context.Permissions.Add(permission);

            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            TestDBEntities context = new TestDBEntities();
            Permission permission = context.Permissions.FirstOrDefault(d => d.Id == id);
            if (permission == null) return 0;

            context.Permissions.Remove(permission);            

            return context.SaveChanges();
        }

        public int Update(PermissionEntity entity)
        {
            TestDBEntities context = new TestDBEntities();
            Permission permission = context.Permissions.FirstOrDefault(d => d.Id == entity.Id);
            if (permission == null) return 0;

            permission.EmployeeLastName = entity.EmployeeLastName;
            permission.EmployeeName = entity.EmployeeName;
            permission.PermissionTypeId = entity.PermissionTypeId;            

            return context.SaveChanges();
        }

        public PermissionEntity Find(int id)
        {
            Permission permission = context.Permissions.Include("PermissionType").FirstOrDefault(d => d.Id == id);
            PermissionEntity item = new PermissionEntity();

            if (permission != null)
            {
                item.PermissionDate = permission.PermissionDate;
                item.EmployeeLastName = permission.EmployeeLastName;
                item.EmployeeName = permission.EmployeeName;
                item.PermissionType = new PermissionTypeEntity { Description = permission.PermissionType.Description, Id = permission.PermissionType.Id };
                item.PermissionTypeId = permission.PermissionTypeId;
                item.PermissionTypeDescription = permission?.PermissionType?.Description;
                item.Id = permission.Id;
            }

            return item;
        }

    }
}
