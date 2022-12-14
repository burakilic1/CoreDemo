﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
    }
}
