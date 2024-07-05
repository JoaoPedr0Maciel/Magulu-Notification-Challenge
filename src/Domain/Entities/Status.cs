using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using magalu_notify.src.Domain.Enums;

namespace magalu_notify.src.Domain.Entities;

[Table("status")]
public class Status
{
    public int StatusId { get; set; }
    public StatusValues? Description { get; set; }
}
