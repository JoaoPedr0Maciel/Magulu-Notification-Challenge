using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace magalu_notify.src.Domain.Entities;

[Table("channel")]
public class Channel
{
    public int Id { get; set; }
    public string? ChannelName { get; set; }
}
