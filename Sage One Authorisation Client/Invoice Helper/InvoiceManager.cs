using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sage_One_Authorisation_Client.Invoice_Helpers
{
    public class InvoiceManager
    {
        private string JSON = null;

        private SageOneOAuth oauth = new SageOneOAuth();

        private Uri invoiceUri = new Uri("https://api.sageone.com/accounts/v2/sales_invoices");
        
        public InvoiceGetHeader GetInvoices(string token)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            string JSON = webRequest.GetData(invoiceUri, token, oauth.SigningSecret);

            InvoiceGetHeader invoice = JsonConvert.DeserializeObject<InvoiceGetHeader>(JSON);

            return invoice;
        }

        public InvoiceGetHeader GetInvoices(string token, string emailAddress)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            UriBuilder uriWithParameters = new UriBuilder(invoiceUri.AbsoluteUri);

            uriWithParameters.Query = "email=" + emailAddress;

            string JSON = webRequest.GetData(uriWithParameters.Uri, token, oauth.SigningSecret);

            InvoiceGetHeader invoice = JsonConvert.DeserializeObject<InvoiceGetHeader>(JSON);

            return invoice;
        }

        public InvoiceGetHeader GetInvoiceItemsPerPage(string token, string page)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            UriBuilder uriWithParameters = new UriBuilder(invoiceUri.AbsoluteUri);

            uriWithParameters.Query = "$itemsPerPage=" + page;

            string JSON = webRequest.GetData(uriWithParameters.Uri, token, oauth.SigningSecret);

            InvoiceGetHeader invoice = JsonConvert.DeserializeObject<InvoiceGetHeader>(JSON);

            return invoice;
        }

        public InvoiceToGet GetInvoice(string id, string token)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            Uri specificInvoiceUri = new Uri(invoiceUri.AbsoluteUri + "/" + id);

            string JSON = webRequest.GetData(specificInvoiceUri, token, oauth.SigningSecret);

            InvoiceToGet invoice = JsonConvert.DeserializeObject<InvoiceToGet>(JSON);

            return invoice;
        }

        public string CreateInvoice(string invoiceName, PaymentStatus paymentStatus, string reference, string contactid, string date, string token)
        {

            SageOneWebRequest webRequest = new SageOneWebRequest();

            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>> {
                      new KeyValuePair<string,string>("sales_invoice[contact_id]","671814"),
                      //new KeyValuePair<string,string>("sales_invoice[contact_name]","Alex"),
                      new KeyValuePair<string,string>("sales_invoice[date]","2016-08-27"),
                      ////new KeyValuePair<string,string>("sales_invoice[carriage_tax_code_id]","1"),
                      //new KeyValuePair<string,string>("sales_invoice[status_id]","0"),
                      new KeyValuePair<string,string>("sales_invoice[due_date]","2016-09-27"),
                      //new KeyValuePair<string,string>("sales_invoice[main_address]","Customer Address"),
                      new KeyValuePair<string,string>("sales_invoice[reference]","INV1" + DateTime.Now.ToString("HHmm")),
                     /* new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][description]","Hardware Test Code"),
                      new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][product_code]","HW1"),
                      new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][quantity]","5"),
                      new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][unit_price]","6"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][ledger_account_id]","2745837"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][tax_rate_id]","114914"),
                      new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][discount_percentage]","0")
                     */ 
                      // UK version
                      //new KeyValuePair<string,string>("sales_invoice[contact_id]","671814"),
                      //new KeyValuePair<string,string>("sales_invoice[contact_name]","Alex"),
                      //new KeyValuePair<string,string>("sales_invoice[date]","2017-01-10"),
                      //new KeyValuePair<string,string>("sales_invoice[due_date]","2017-01-15"),
                      //new KeyValuePair<string,string>("sales_invoice[main_address]","address"),
                      //new KeyValuePair<string,string>("sales_invoice[carriage_tax_code_id]","1"),
                      //new KeyValuePair<string,string>("sales_invoice[reference]","12241224"),
                      //new KeyValuePair<string,string>("sales_invoice[status_id]","0"),
                     
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][description]","Hardware Test Code"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][product_code]","HW"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][product_id]","1"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][quantity]","5.0"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][unit_price]","4.55"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][tax_code_id]","1"),
                      //new KeyValuePair<string,string>("sales_invoice[line_items_attributes][0][ledger_account_id]","4050")
            };

            string _return = webRequest.PostData(invoiceUri, postData, token, oauth.SigningSecret);


            return _return;
        }

        public string UpdateInvoice(string id, string invoiceName, PaymentStatus paymentStatus, string reference, string contatctid, string date, string token)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            Uri specificInvoiceUri = new Uri(invoiceUri.AbsoluteUri + "/" + id);

            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>> {
                      new KeyValuePair<string,string>("sales_invoice[contact_name]", "Alex"),
                      //new KeyValuePair<string,string>("sales_invoice[contact_name])", invoiceName),
                      new KeyValuePair<string,string>("sales_invoice[date]",date.ToString()),
                      new KeyValuePair<string,string>("sales_invoice[reference]",reference),
                      new KeyValuePair<string,string>("sales_invoice[contact_id]",contatctid)
            };

            string _return = webRequest.PutData(specificInvoiceUri, postData, token, oauth.SigningSecret);

            return _return;
        }

        public string DeleteInvoice(string id, string token)
        {
            SageOneWebRequest webRequest = new SageOneWebRequest();

            Uri specificInvoiceUri = new Uri(invoiceUri.AbsoluteUri + id);

            return webRequest.DeleteData(specificInvoiceUri, token, oauth.SigningSecret);
        }

    }
}