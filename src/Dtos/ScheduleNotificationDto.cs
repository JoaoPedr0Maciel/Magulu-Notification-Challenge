using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using magalu_notify.src.Domain.Entities;
using magalu_notify.src.Domain.Enums;

namespace magalu_notify.src.Dtos;

public record ScheduleNotificationDto(DateTime Datetime, string Destination, string Message, ChannelValues Channel)
{

}
