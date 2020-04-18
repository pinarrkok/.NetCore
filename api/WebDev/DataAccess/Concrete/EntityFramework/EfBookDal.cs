using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntitityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal:EfEntityRepositoryBase<Book,BookStoreContext>,IBookDal
    {
    }
}
