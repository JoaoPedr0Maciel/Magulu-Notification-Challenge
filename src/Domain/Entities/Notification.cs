using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace magalu_notify.src.Domain.Entities;

[Table("Notification")]
public class Notification 
{
    [Key]
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public string? Destination { get; set; }
    public string? Message { get; set; }

    [Column("channel_id")]
    public Channel? Channel { get; set; }

    [Column("status_id")]
    public Status? Status { get; set; }
}
