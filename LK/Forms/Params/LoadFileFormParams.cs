using System;
using WcApi.Cryptography;

namespace LK.Forms.Params
{
    public class LoadFileFormParams
    {
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today;
        public Auth Auth { get; set; }
        public string FilePath { get; set; } = null;
    }
}
