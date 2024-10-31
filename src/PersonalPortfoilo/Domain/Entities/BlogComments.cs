using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class BlogComments : Entity<int>
{
    public string Content { get; set; }
    public DateTime? PublishDate { get; set; } //PublishDate atanmışsa comment onaylanmış demektir. 
    public int BlogPostId { get; set; }
    public int UserId { get; set; }

    public virtual BlogPosts BlogPost { get; set; }
    public virtual User User { get; set; }

    public BlogComments()
    {
        Content = string.Empty;
        PublishDate = null;

    }

    public BlogComments(string content, DateTime publishDate,int blogPostId, int userId): this()
    {
        Content = content;
        PublishDate= publishDate;
        BlogPostId= blogPostId;
        UserId= userId;

        
    }

}
