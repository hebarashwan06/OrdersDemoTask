using OrdersDemo.DataMapping.Entities;
using OrdersDemo.DataMapping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDemo.DataAccess.Repositories
{
    public class UserProfileRepository
    {
        public List<UserProfile> GetList()
        {
            using (var db = new SalesDBContext())
            {
                return db.UserProfiles.ToList();
            }
        }

        public EditUserProfile GetEditUserProfileById(int id)
        {
            using (var db = new SalesDBContext())
            {
                var userProfile= db.UserProfiles.FirstOrDefault(u => u.ID == id);
                EditUserProfile editUseProfile = new EditUserProfile
                {
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    UserName=userProfile.UserName,
                    Email = userProfile.Email,
                    Address = userProfile.Address
                };
                return editUseProfile;
            }
        }

        public UserProfile GetById(int id)
        {
            using (var db = new SalesDBContext())
            {
                return db.UserProfiles.FirstOrDefault(u => u.ID == id);
            }
        }

        public bool Create(UserProfile userProfile)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    db.UserProfiles.Add(userProfile);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Update(EditUserProfile editUserProfile)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    var q = db.UserProfiles.FirstOrDefault(u => u.ID == editUserProfile.ID);
                    if (q != null)
                    {
                        q.FirstName = editUserProfile.FirstName;
                        q.LastName = editUserProfile.LastName;
                        q.Email = editUserProfile.Email;
                        q.Address = editUserProfile.Address;
                        db.SaveChanges();
                    }
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new SalesDBContext())
            {
                try
                {
                    var q = db.UserProfiles.FirstOrDefault(x => x.ID == id);
                    if (q != null)
                    {
                        db.UserProfiles.Remove(q);
                        db.SaveChanges();
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

    }
}
