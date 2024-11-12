using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Collaborator
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TeamRole { get; set; }
        public DateTime? Created { get; set; }
        public int Sales { get; set; }
    }
}

