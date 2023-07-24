using ArsaProject.DataAccessLayer.Abstract;
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
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
        {

        }
    }
}
