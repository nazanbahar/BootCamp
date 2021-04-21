using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// PascalCase
/// PrimaryKey→ Product.Id olduğu için Id veriyoruz.(ex. ClasName.Id)
/// ForeignKey→ CategoryId (OK) don't use Id(x)
/// </summary>
namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }


    }
}
