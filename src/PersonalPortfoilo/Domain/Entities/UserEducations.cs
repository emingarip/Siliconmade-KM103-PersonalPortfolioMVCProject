using Core.Persistence.Repositories;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;


public class UserEducations : Entity<int>
{
    public string School { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int UserId { get; set; }
    public Educations Educations { get; set; }

    public virtual User User { get; set; }

    public UserEducations()
    {
        School = string.Empty;
    }
    public UserEducations(string school,DateTime startDate, DateTime endDate,int userID,Educations educations):this()
    {
        School=school;
        StartDate=startDate;
        EndDate=endDate;
        UserId =userID;
        Educations = educations;
        
    }
}

