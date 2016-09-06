using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sage_One_Authorisation_Client;
using Sage_One_Authorisation_Client.Contact_Helpers;
using Sage_One_Authorisation_Client.Invoice_Helpers;

namespace Sage_One_API_Sample_Website
{

    public partial class Contacts : System.Web.UI.Page
    {

        private SageOneOAuth oauth = new SageOneOAuth();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //ListContacts();
                //ListInvoices();
            }
        }

        //private void ListContacts()
        //{
        //    string token = (string)Session["token"];

        //    txtCompanyName.Text = "";
        //    //txtContactName.Text = "";
        //    txtContactTypeID.Text = "";

        //    ContactManager contactManager = new ContactManager();

        //    ContactGetHeader contactHeader = contactManager.GetContacts(token);

        //    DisplayContacts(contactHeader);
        //}

        //private void ListInvoices()
        //{
        //    string token = (string)Session["token"];

        //    TextInvoiceContactName.Text = "";
        //    TextPaymentStatus.Text = "";
        //    TextDate.Text = "";

        //    InvoiceManager invoiceManager = new InvoiceManager();
            
        //    InvoiceGetHeader invoiceHeader = invoiceManager.GetInvoices(token);

        //    DisplayInvoices(invoiceHeader);
        //}

        //private void DisplayContacts(ContactGetHeader contactHeader)
        //{
        //    string listText;
        //    ListItem item;
        //    ContactToGet contact;

        //    ListBoxContacts.Items.Clear();

            

        //    for (int i = 0; i < contactHeader.Contacts.Count; i++)
        //    {
        //        contact = contactHeader.Contacts[i];
        //        List<ContactType> types = contact.ContactTypes;

        //        string contactTypeID = types[0].Id.ToString();

        //        listText = contact.CompanyName + "," + contact.Name + "," + contact.Email + "," + contact.Telephone + "," + contactTypeID;

        //        item = new ListItem(listText, contact.Id.ToString());

        //        this.ListBoxContacts.Items.Add(item);
        //    }
        //}

        //private void DisplayInvoices(InvoiceGetHeader invoiceHeader)
        //{
        //    string listText;
        //    ListItem item;
        //    InvoiceToGet invoice;

        //    ListBoxInvoices.Items.Clear();



        //    for (int i = 0; i < invoiceHeader.Invoices.Count; i++)
        //    {
        //        invoice = invoiceHeader.Invoices[i];
        //        //List<InvoiceType> types = invoice.InvoiceTypes;

        //        string status = invoice.Status.Name;

        //        listText = invoice.Id + "," + invoice.ContactName + "," + invoice.Status.Name + "," + invoice.ArtefactNumberPrefix + "," + invoice.date;

        //        item = new ListItem(listText, invoice.Id.ToString());

        //        this.ListBoxInvoices.Items.Add(item);
        //    }
        //}

        //protected void btnCreateContact_Click(object sender, EventArgs e)
        //{
        //    string contactName = txtContactName.Text;
        //    string companyName = txtCompanyName.Text;
        //    int contactTypeID = Int32.Parse(txtContactTypeID.Text);

        //    string token = (string)Session["token"];

        //    ContactManager contactManager = new ContactManager();

        //    string result = contactManager.CreateContact(contactName, companyName, "", "", contactTypeID, token);
                       
        //    ListContacts();

        //}

        //protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedContact = ListBoxContacts.SelectedItem.Value.ToString();
        //    string text = ListBoxContacts.SelectedItem.Text.ToString();
        //    string[] contactValues = text.Split(',');
        //    //txtContactName.Text = contactValues[1];
        //    txtCompanyName.Text = contactValues[0];
        //    txtContactTypeID.Text = contactValues[4];
            
        //}

        //protected void ListBoxInvoices_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedAccount = ListBoxInvoices.SelectedItem.Value.ToString();
        //    string text = ListBoxInvoices.SelectedItem.Text.ToString();
        //    string[] invoiceValues = text.Split(',');
        //    TextPaymentStatus.Text = invoiceValues[2];
        //    TextInvoiceContactName.Text = invoiceValues[1];
        //    TextDate.Text = invoiceValues[4];
        //}

        //protected void ListBoxHeaders_SelectedIndexChanged(object sender, EventArgs e)
        //{
             
        //}

        //protected void ListBoxRespone_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //protected void btnUpdateContact_Click(object sender, EventArgs e)
        //{
        //    string token = (string)Session["token"];
        //    ContactManager contactManager = new ContactManager();
        //    string result = contactManager.UpdateContact(ListBoxContacts.SelectedItem.Value.ToString(), 
        //        txtContactName.Text , txtCompanyName.Text, "", "", 
        //        Int32.Parse(txtContactTypeID.Text), token);

        //    ListContacts();
        //}

        //protected void btnDeleteContact_Click(object sender, EventArgs e)
        //{
        //    string token = (string)Session["token"];
        //    ContactManager contactManager = new ContactManager();
        //    string result = contactManager.DeleteContact(ListBoxContacts.SelectedItem.Value.ToString(), token);

        //    ListContacts();
        //}

        //protected void btnClear_Click(object sender, EventArgs e)
        //{
        //    txtCompanyName.Text = "";
        //    txtContactName.Text = "";
        //    txtContactTypeID.Text = "";
        //}

        //protected void btnUpdateInvoice_Click(object sender, EventArgs e)
        //{
        //    string token = (string)Session["token"];
        //    InvoiceManager invoiceManager = new InvoiceManager();
        //    string result = invoiceManager.UpdateInvoice(ListBoxInvoices.SelectedItem.Value.ToString(),
        //        TextInvoiceContactName.Text, null, "", "",
        //        TextDate.Text, token);

        //    ListContacts();
        //}

        //protected void btnDeleteInvoice_Click(object sender, EventArgs e)
        //{
        //    string token = (string)Session["token"];
        //    InvoiceManager invoiceManager = new InvoiceManager();
        //    string result = invoiceManager.DeleteInvoice(ListBoxInvoices.SelectedItem.Value.ToString(), token);

        //    ListInvoices();
        //}

        //protected void btnClearInvoice_Click(object sender, EventArgs e)
        //{
        //    TextInvoiceContactName.Text = "";
        //    TextPaymentStatus.Text = "";
        //    TextDate.Text = "";
        //}

        //protected void btnCreateInvoice_Click(object sender, EventArgs e)
        //{
        //    string invoiceName = TextInvoiceContactName.Text;
        //    string paymentStatus = TextPaymentStatus.Text;
        //    string date = TextDate.Text;

        //    string token = (string)Session["token"];

        //    InvoiceManager invoiceManager = new InvoiceManager();

        //    string result = invoiceManager.CreateInvoice("Alex", null, "", "671814", date, token);

        //    ListInvoices();

        //}

        protected void btnCreatePackage_Click(object sender, EventArgs e)
        {
            string url = TextURL.Text;
            string postdata = TextBody.Text;

            string token = (string)Session["token"];

            SageOneWebRequest webRequest = new SageOneWebRequest();

            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();

            postdata = postdata.Replace(System.Environment.NewLine, "");

            foreach (string dataline in postdata.Split('&'))
            {
                string[] pair = dataline.Split('=');
                if(pair.Count() > 1)
                {
                    postData.Add(new KeyValuePair<string, string>(pair[0], pair[1]));
                }
            }

            Uri packageURI = new Uri(url);

            string _return = webRequest.PostData(packageURI, postData, token, oauth.SigningSecret);

            HeadersBox.Text = webRequest.webRequestinfo.Headers.ToString();

            ResponseBox.Text = _return;
        }
        protected void btnSendPackage_Click(object sender, EventArgs e)
        {
            string url = TextBoxURL2.Text;

            string token = (string)Session["token"];

            SageOneWebRequest webRequest = new SageOneWebRequest();

            Uri packageURI = new Uri(url);

            string _return = webRequest.GetData(packageURI, token, oauth.SigningSecret);

            GetResponseBox.Text = _return;
        }
    }
}
