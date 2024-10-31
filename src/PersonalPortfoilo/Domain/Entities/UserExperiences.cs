using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class UserExperiences : Entity<int>
{
    public string Title { get; set; }
    public string Org { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }



    public UserExperiences()
    {
        Title = string.Empty;
        Org = string.Empty;
        Description = string.Empty;
    }
    public UserExperiences(string title, string org, DateTime startDate, DateTime endDate, int userID): this()
    {
       Title=title;
       Org=org;
       StartDate=startDate;
       EndDate=endDate;
       UserId =userID;

    }
}

