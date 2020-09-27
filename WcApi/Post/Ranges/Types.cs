
namespace WcApi.Post.Ranges
{
    /// <summary>
    /// Статус диапазона
    /// </summary>
    public enum StateRange
    {
        // Свободен
        Free = 1,
        // Занят
        Busy = 2,
        // Использован
        Used = 3
    }

    /// <summary>
    /// Вид международного отправления
    /// </summary>
    public enum MailTypePref
    {
        // ReSharper disable once InconsistentNaming
        RA,
        // ReSharper disable once InconsistentNaming
        RO,
        // ReSharper disable once InconsistentNaming
        RR,
        // ReSharper disable once InconsistentNaming
        RB
    }
}
