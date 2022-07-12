using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("customers")]
[Index(nameof(Id), IsUnique = true)]
[Index(nameof(Email), IsUnique = true)]
public class Customer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    [Required]
    [Column("customer_email")]
    public string Email { get; set; }

    public List<Order> Orders { get; set; }
}

