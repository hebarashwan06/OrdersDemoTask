using OrdersDemo.DataAccess.Repositories;
using OrdersDemo.DataMapping.Entities;
using OrdersDemo.DataMapping.Services;
using System;
using System.Collections.Generic;


namespace OrdersDemo.BusinessLogic.Core
{
    public class UserProfileLogic
    {
        public List<UserProfile> GetList()
        {
            return new UserProfileRepository().GetList();
        }

        public UserProfile GetById(int id)
        {
            return new UserProfileRepository().GetById(id);
        }

        public EditUserProfile GetEditUserProfileById(int id)
        {
            return new UserProfileRepository().GetEditUserProfileById(id);
        }

        public bool Create(UserProfile userProfile)
        {
            return new UserProfileRepository().Create(userProfile);
        }

        public bool Update(EditUserProfile editUserProfile)
        {
            return new UserProfileRepository().Update(editUserProfile);
        }

        public bool Delete(int id)
        {
            return new UserProfileRepository().Delete(id);
        }
    }
}
