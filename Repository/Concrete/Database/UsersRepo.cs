﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concrete;
using Models.Abstract;
using Repository.Abstract;

namespace Repository.Concrete.Database
{
    public class UsersRepo : ConnectionManager, IRepository
    {
        public bool Add(IModel model)
        {
            return true;
        }

        public bool Delete(IModelFilter filter)
        {
            return true;
        }

        public bool Update(IModelFilter filter, IModelFilter model)
        {
            return true;
        }

        public List<IModel> Get(IModelFilter filter)
        {
            List<IModel> result = new List<IModel>();

            return result;
        }
    }
}
