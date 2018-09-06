using System;
using System.ComponentModel.DataAnnotations;

namespace BluereadySearch.Models
{
    public interface IMessageClass
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        [Required]
        string Message { get; set; }
        [Required]
        string Phone { get; set; }
        string Email { get; set; }
    }
}