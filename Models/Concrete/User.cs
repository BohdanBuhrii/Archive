﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models
{
    public class User : IModel
    {
        public long user_id;
        public string user_name;
        public string email;
        public string date_of_birth;
    }
}
