using System;
using System.ComponentModel.DataAnnotations;

namespace BluereadySearch.Models
{
    public class MessageClass : IMessageClass
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        [Required]
        public string Phone
        {
            get;
            set;
        }

        [Required]
        public string Email {
            get;
            set;
        }
    }
}