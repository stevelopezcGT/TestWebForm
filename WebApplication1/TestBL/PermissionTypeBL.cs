using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL;
using TestEntities;

namespace TestBL
{
    public class PermissionTypeBL
    {
        private TestDBEntities context;

        public PermissionTypeBL()
        {
            context = new TestDBEntities();
        }

        public List<PermissionTypeEntity> All()
        {
            List<PermissionTypeEntity> permissionTypes = new List<PermissionTypeEntity>();
            context.PermissionTypes.ToList().ForEach(d =>
            {
                permissionTypes.Add(new PermissionTypeEntity
                {   
                    Id=d.Id,
                   Description= d.Description
                });
            });

            return permissionTypes;
        }
        public int Add(PermissionTypeEntity entity)
        {
            PermissionType permissionType = new PermissionType
            {
                Description= entity.Description
            };

            context.PermissionTypes.Add(permissionType);
            try
            {
                return context.SaveChanges();
            }
            catch(Exception ex)
            {

            }
            return 0;
        }

        public int Delete(int id)
        {
            PermissionType permissionType = context.PermissionTypes.FirstOrDefault(d => d.Id == id);
            if (permissionType == null) return 0;

            context.PermissionTypes.Remove(permissionType);            

            return context.SaveChanges();
        }

        public int Update(PermissionTypeEntity entity)
        {
            PermissionType permissionType = context.PermissionTypes.FirstOrDefault(d => d.Id == entity.Id);
            if (permissionType == null) return 0;

            permissionType.Description = entity.Description;

            return context.SaveChanges();
        }

        public PermissionTypeEntity Find(int id)
        {
            PermissionType permissionType = context.PermissionTypes.FirstOrDefault(d => d.Id == id);
            PermissionTypeEntity item = new PermissionTypeEntity();

            if (permissionType != null)
            {
                item.Description = permissionType.Description;
                item.Id = permissionType.Id;
            }

            return item;
        }
    }
}
