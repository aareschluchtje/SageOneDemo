using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sage_One_Authorisation_Client.Invoice_Helper;

namespace Sage_One_Authorisation_Client.Invoice_Helpers
{
    public partial class InvoiceGetHeader
    {
        [JsonProperty("$totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("$startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("$itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("$resources")]
        public List<InvoiceToGet> Invoices { get; set; }
    }

    public class InvoicePostHeader
    {
        [JsonProperty("invoice")]
        public InvoiceToPost Invoice { get; set; }
    }

    public class InvoiceToPost : Invoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("contact_id")]
        public int ContactID { get; set; }

        [JsonProperty("line_items")]
        public List<LineItem> LineItems { get; set; }
    }

    public class InvoiceToGet : Invoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("contact_id")]
        public int ContactID { get; set; }
    }

    public abstract class Invoice
    {
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("artefact_number")]
        public string ArtefactNumber { get; set; }

        [JsonProperty("artefact_number_prefix")]
        public string ArtefactNumberPrefix { get; set; }

        [JsonProperty("status")]
        public PaymentStatus Status { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("void_reason")]
        public string VoidReason { get; set; }

        [JsonProperty("outstanding")]
        public double Outstanding { get; set; }
    }    
}
