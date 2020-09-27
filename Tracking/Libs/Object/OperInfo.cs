
namespace Tracking.Libs.Object
{
    public class OperInfo
    {
        // ШПИ
        public string Barcode { get; set; }
        // Отметка
        public string PostMark { get; set; }
        // Вид и категория РПО
        public string Name { get; set; }
        // Отправитель
        public string Sndr { get; set; }
        // Получатель
        public string Rcpn { get; set; }

        // Порядок операции
        public int Id { get; set; }
        // Дата операции
        public string Date { get; set; }
        // Тип операции
        public string Type { get; set; }
        // Id операции
        public int TypeId { get; set; }
        // Атрибут операции
        public string Attr { get; set; }
        // Id атрибута операции
        public int AttrId { get; set; }
        // Разряд отправления
        public string Rank { get; set; }
        // Id разряда отправления
        public int RankId { get; set; }
        // Индекс операции
        public string IndexFrom { get; set; }
        // Место операции
        public string DescFrom { get; set; }
        // Вес отправления
        public string Mass { get; set; }
        // Объявленная ценность отправления
        public string Value { get; set; }
        // Весовой сбор
        public string MassRate { get; set; }
        // Индекс следующей операции
        public string IndexTo { get; set; }
        // Место следующей операции
        public string DescTo { get; set; }

        public string FullRpoName()
        {
            return $"{Name} | {PostMark} | {Rank}";
        }
    }
}
