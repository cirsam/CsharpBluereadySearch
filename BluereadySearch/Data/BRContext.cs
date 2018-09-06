using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluereadySearch.Data
{
    public class BRContext : DbContext
    {
        public BRContext(DbContextOptions<BRContext> options)
         : base(options)
        {
        } 
   }
}
