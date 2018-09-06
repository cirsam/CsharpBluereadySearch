using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BluereadySearch.Models
{
    public class SendMessage
    {
        readonly IMessageClass _message;
        private string _status;

        public string Status
        {
            get{
                return _status;
            }
            set { _status = value; }
        }

        public SendMessage(IMessageClass message)
        {
            _message = message;
            _status = SendEmail();
        }

        private string SendEmail()
        {
            string to = string.Format("cirsam@hotmail.com,{0}",_message.Email);
            string password = "Store1hubs@#$";
            string from = "Blueready Search<rittalantwi@gmail.com>";
            string body = string.Format("Dear {0} {1}, <br /> Thank you for contacting Blueready.<br /> We will be in touch with you in the next 24 hours either by your phone number {2} or email {3}.<br /><br />Your request:<br />{4}<br /><br /> Yours Sincerely,<br />Samuel Antwi",_message.FirstName,_message.LastName,_message.Phone,_message.Email,_message.Message);

            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "mail.storehubs.com",
                    Port = 587,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential("_mainaccount@storehubs.com", password),
                    Timeout = 10000,
                };

                MailMessage message = new MailMessage(from,to, "Blueready Email Message",body);
                message.IsBodyHtml = true;
                client.Send(message);
            }
            catch (Exception ex) {

                return ex.ToString();

            }
            return "Your message has been sent";
        }

    }
}
