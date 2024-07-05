using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using magalu_notify.src.Domain.Entities;
using magalu_notify.src.Domain.Interfaces;
using magalu_notify.src.Infra;

namespace magalu_notify.src.Domain.Repositories;

public class NotificationRepository : INotification
{
    private readonly AppDbContext _context;

    public NotificationRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public async Task ScheduleNotification(Notification notification)
    {
        await _context.Notifications.AddAsync(notification);
        await _context.SaveChangesAsync();
    }
}
