using System;
using Newtonsoft.Json;

namespace LK.Core.Libs.Auth.Model
{
    public class ReceiveDoc
    {
        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("accepted-batch-id")]
        public string AcceptedBatchId { get; set; }

        [JsonProperty("batch-name")]
        public string BatchName { get; set; }

        [JsonProperty("postoffice-code")]
        public string PostofficeCode { get; set; }

        [JsonProperty("list-number")]
        public string ListNumber { get; set; }

        [JsonProperty("send-date")]
        public DateTime SendDate { get; set; }

        [JsonProperty("org-name")]
        public string OrgName { get; set; }

        [JsonProperty("batch-size")]
        public int? BatchSize { get; set; }

        [JsonProperty("batch-size-accepted")]
        public int? BatchSizeAccepted { get; set; }

        [JsonProperty("batch-size-rejected")]
        public int? BatchSizeRejected { get; set; }

        [JsonProperty("batch-size-missed")]
        public int? BatchSizeMissed { get; set; }

        [JsonProperty("rate")]
        public int? Rate { get; set; }

        [JsonProperty("operator-user")]
        public string OperatorUserName { get; set; }

        [JsonProperty("operator-display-name")]
        public string OperatorDisplayName { get; set; }

        [JsonProperty("last-status-date")]
        public DateTime LastStatusDate { get; set; }

        [JsonProperty("mail-type")]
        public string MailType { get; set; }

        [JsonProperty("batch-status")]
        public string BatchStatus { get; set; }

        [JsonProperty("payment-method")]
        public string PaymentMethods { get; set; }

        [JsonProperty("batch-source")]
        public string BatchSource { get; set; }

        public override string ToString()
        {
            return $"{OrgName} сп {ListNumber}";
        }
    }
}
