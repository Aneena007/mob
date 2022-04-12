using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogOrderController : ControllerBase
    {
        private readonly CatalogDbContext _context;

        public CatalogOrderController(CatalogDbContext context)
        {
            _context = context;
        }
      
        [HttpGet]
                public async Task<ActionResult<IEnumerable<CatalogOrder>>>GetCatalogOrders()
              {
                   return await _context.CatalogOrder.ToListAsync();
               }

    }
}
