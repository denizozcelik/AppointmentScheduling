using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient("YourApiKey", "YourApiSecret")
            {

            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", "senderMailAdress@gmail.com"},
                  {"Name", "Appointment Scheduler"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", email},
                   }
                  }},
                 {"Subject", subject},

                 {"HTMLPart", htmlMessage}
                 }
                   });
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}