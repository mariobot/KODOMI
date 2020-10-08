using Microsoft.EntityFrameworkCore;
using Order.Persistence.Database;
using Order.Service.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Service.Queries
{
    public interface IOrderQueryService
    {
        Task<DataCollection<OrderDto>> GetAllAsync(int page, int take);
        Task<OrderDto> GetAsync(int id);
    }

    public class OrderQueryService : IOrderQueryService
    {
        private readonly ApplicationDbContext _context;

        public OrderQueryService(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<OrderDto>> GetAllAsync(int page, int take) 
        {
            var collection = await _context.Orders                
                .OrderByDescending(x => x.OrderId)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<OrderDto>>();
        }

        public async Task<OrderDto> GetAsync(int id)
        {
            Domain.Order result = (from c in _context.Orders
                         where c.OrderId == id
                         select c).FirstOrDefault();

            OrderDto resultDto = (result).MapTo<OrderDto>();

            resultDto.Items = (from od in _context.OrdersDetails
                            where od.OrderId == id
                            select new OrderDetailDto(){ 
                                OrderDetailId = od.OrderDetailId,
                                OrderId = od.OrderId,
                                ProductId = od.ProductId,
                                Quantity = od.Quantity,
                                Total = od.Total,
                                UnitPrice = od.UnitPrice                                
                            }).ToList();

            return resultDto;
        }
    }
}
