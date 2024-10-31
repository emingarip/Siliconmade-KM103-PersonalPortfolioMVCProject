using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class BlogPosts : Entity<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; } // Created Date farklıdır. Blog yazısı onaylandıktan sonra yayına alındığı için ayrıca tarih tutulmalıdır

    public int UserId { get; set; }
    public virtual ICollection<BlogComments> BlogComments { get; set; }

    public virtual User User { get; set; }


    public BlogPosts()
    {
        Title = string.Empty;
        Content = string.Empty;
        BlogComments = new List<BlogComments>();

    }

    public BlogPosts(int id, string title, string content, DateTime publishDate, int userId) : this()
    {
        Id = id;
        Title = title;
        Content = content;
        PublishDate = publishDate;
        UserId = userId;
    }

}
