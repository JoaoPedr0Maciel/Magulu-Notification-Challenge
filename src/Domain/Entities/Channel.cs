using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using magalu_notify.src.Domain.Enums;

namespace magalu_notify.src.Domain.Entities;

[Table("channel")]
public class Channel
{
    public int Id { get; set; }
    public ChannelValues? ChannelName { get; set; }
}
