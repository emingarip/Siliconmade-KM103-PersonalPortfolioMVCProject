using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class AboutUser : Entity<int>
{
    public string Introduction { get; set; }
    public string ImageUrl1 { get; set; }
    public string ImageUrl2 { get; set; }

    public int UserId { get; set; }

    public DateTime DateOfBirth { get; set; }
    public string AddressFirstLine { get; set; }
    public string ZipCode { get; set; }
    
    public virtual User User { get; set; }


    public AboutUser()
    {
        Introduction = string.Empty;
        ImageUrl1 = string.Empty;
        ImageUrl2 = string.Empty;
    }
    public AboutUser(string introduction,string imageUrl1, string imageUrl2, int userID ,string addressFirstLine, string zipCode ):this()
    {
        Introduction = introduction;
        ImageUrl1 = imageUrl1;
        ImageUrl2 = imageUrl2;
        User = userID;
        AddressFirstLine = addressFirstLine;
        ZipCode = zipCode;
    }
}
