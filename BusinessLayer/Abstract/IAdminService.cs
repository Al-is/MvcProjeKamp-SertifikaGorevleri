﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        List<Admin> GetListByHeadingId(int id);
        void AdminAdd(Admin admin);
        Admin GetById(int id);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
    }
}
