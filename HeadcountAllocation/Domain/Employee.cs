

using System.Collections.Concurrent;
using static HeadcountAllocation.Domain.Enums;

namespace HeadcountAllocation.Domain{

    public class Employee
    {
        public string? Name {get;set;}

        public int EmployeeId{get;set;}

        public int PhoneNumber{get;set;}

        public string? EmailAddress{get;set;}

        public TimeZones TimeZone{get;set;}
        
        public List<string>? ForeignLanguages{get;set;} = new();

        public ConcurrentDictionary<int, Skill> Skills{get;set;} = new();

        public List<Role> Roles{get;set;} = new();

        public int YearsExperience{get;set;}

        public double JobPercentage{get;set;}

    }
}