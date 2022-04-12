using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Order;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class CatalogOrderRepository : GenericRepository<CatalogOrder>, ICatalogOrderRepository
    {
        private readonly CatalogDbContext _context;
        public CatalogOrderRepository(CatalogDbContext _context) : base(_context)
        {
            this._context = _context;
        }

       

    }

    
}
