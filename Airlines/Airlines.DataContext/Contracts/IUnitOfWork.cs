using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.DataContext.Contracts
{
    interface IUnitOfWork
    {
        int SaveChanges();
    }
}
