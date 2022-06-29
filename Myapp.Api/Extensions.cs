using MyApp.Api.Api.Dtos;
using MyApp.Api.Api.Entities;

namespace MyApp.Api.Api
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
    
}