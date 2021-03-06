using System;
using DwUtils.Core.Models.Base;

namespace DwUtils.Core.Models.Firebird
{
    public class Reestr : IEntity
    {
        public int Id { get; set; }
        public long Num { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string DirectionIndex { get; set; } = "125993";
        public string DirectionPlace { get; set; } = "ГСП-3";
        public int StateId { get; set; }
        public int PlaceId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public int UserId { get; set; }
        public int RpoCount { get;set;}

        public override string ToString()
        {
            return $"[{Num}] {DirectionIndex} {DirectionPlace}";
        }
    }
}
