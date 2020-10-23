using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.Blazor.Models
{
    public class ClientDto
    {
        public int ClientId { get; set; }
        [Required(ErrorMessage ="Not empty value")]
        public string Name { get; set; }
    }
}
