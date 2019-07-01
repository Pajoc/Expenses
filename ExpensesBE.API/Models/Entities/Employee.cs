using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesBE.API.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(5)]
        public string Code { get; set; }

        public decimal Treshold { get; set; }
        [StringLength(50)]
        [EmailAddress]
        public string MainEmail { get; set; }

        public bool? IsActive { get; set; }

        public Guid? DepartmentId { get; set; }

        public Department DepartmentOfEmployee { get; set; }
    }
}
