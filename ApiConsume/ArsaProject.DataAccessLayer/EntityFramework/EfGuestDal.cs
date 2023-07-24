﻿using ArsaProject.DataAccessLayer.Abstract;
using ArsaProject.DataAccessLayer.Concrete;
using ArsaProject.DataAccessLayer.Repositories;
using ArsaProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsaProject.DataAccessLayer.EntityFramework
{
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        public EfGuestDal(Context context) : base(context)
        {

        }
    }
}
