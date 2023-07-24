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
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {
        }
    }
}
