using DwUtils.Core.Models.Base;
using DwUtils.Core.Models.Sqlite;

namespace DwUtils.Core.Models.Firebird
{
    public class DeliveryFb : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public Delivery ToDelivery()
        {
            return new Delivery
            {
                Id = Id,
                Name = Name,
                Code = Code
            };
        }
    }
}
