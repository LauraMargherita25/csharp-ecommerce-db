using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("orders")]
[Index(nameof(Id), IsUnique = true)]
public class Order
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Status { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }
}

