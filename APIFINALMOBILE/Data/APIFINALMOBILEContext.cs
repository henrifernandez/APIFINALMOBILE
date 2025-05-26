using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIFINALMOBILE.Models;

namespace APIFINALMOBILE.Data
{
    public class APIFINALMOBILEContext : DbContext
    {
        public APIFINALMOBILEContext (DbContextOptions<APIFINALMOBILEContext> options)
            : base(options)
        {
        }

        public DbSet<APIFINALMOBILE.Models.Produtos> Produtos { get; set; } = default!;
    }
}
