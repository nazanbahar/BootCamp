using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// PascalCase
/// PrimaryKey→ Basket.Id olduğu için Id veriyoruz.(ex. ClasName.Id)
/// ForeignKey→ ProductId (OK) don't use Id
/// veritabanındaki,  bigint 'i  long karşılıyor.
/// basket| brand|order|orderdetail , long olarak verildi.
/// </summary>
namespace Entities.Concrete
{
    public class Basket : IEntity
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? Active { get; set; }
    }
}
