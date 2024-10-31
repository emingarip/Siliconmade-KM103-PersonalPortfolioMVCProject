using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ContactFormMessages : Entity<int>
{
    public string SenderName { get; set; }
    public string SenderEmail { get; set; }
    public string SenderPhone { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public bool isRead { get; set; }
    public string? Replay { get; set; }
    public DateTime? ReplayDate { get; set; }

    public int ReplyedUserId { get; set; }

    public virtual User ReplyedUser { get; set; }

}
