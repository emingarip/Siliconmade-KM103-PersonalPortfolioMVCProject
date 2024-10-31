using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class UserProjects : Entity<int>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int UserId { get; set; }

    public virtual User User { get; set; }


    public UserProjects()
    {
           
    }
    public UserProjects(string title, string description, string imageUrl,int userId ) : this()
    {
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
        UserId = userId;

    }

}
