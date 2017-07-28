using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdkTests
{
    class TestConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IntegratorKey { get; set; }
        public string Host { get; set; }
        public DocuSign.eSign.Client.ApiClient ApiCLient { get; set; }
        public DocuSign.eSign.Client.Configuration Configuration { get; set; }
        public string AccountId { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public string TemplateRoleName { get; set; }
        public string TemplateId { get; set; }
        public string EnvelopeId { get; set; }
        public string ReturnUrl { get; set; }

        public TestConfig(string username = null, string password = null, string integratorKey = null, string host = null, string recipientEmail = null, string recipientName = null, string templateRoleName = null, string templateId = null, string returnUrl = null)
        {
		    this.Host = (host != null) ? host : "https://demo.docusign.net/restapi";
            this.Username = (username != null) ? username : "rfeely.docusign+demo@gmail.com";
            this.Password = (password != null) ? password : "+YRC3Ksh94ZhLp6u6oNHesJYIf8=";
            this.IntegratorKey = (integratorKey != null) ? integratorKey : "c1bf6319-5ece-42eb-a6b9-860bee3de1e9";

            this.RecipientEmail = (recipientEmail != null) ? recipientEmail : "rfeely.docusign+demo@gmail.com";
            this.RecipientName = (recipientName != null) ? recipientName : "Ronan Feely";

            this.TemplateRoleName = (templateRoleName != null) ? templateRoleName : "Customer";
            this.TemplateId = (templateId != null) ? templateId : "4e6654e4-ce61-4d95-b36d-db5610ff71b9";

            this.ReturnUrl = (returnUrl != null) ? returnUrl : "https://www.docusign.com/devcenter";
        }
    }
}
