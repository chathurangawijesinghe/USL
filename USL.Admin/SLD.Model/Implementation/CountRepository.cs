using SLD.Model.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Model.Implementation
{
    public class CountRepository : ICountRepository
    {
        SLD_DatabaseEntities context = new SLD_DatabaseEntities();

        public Counts GetCounts()
        {
            return new Counts
            {
                Admins = context.Users.Where(u => u.UserTypeId == 1).ToList().Count,
                Checkers = context.Users.Where(u => u.UserTypeId == 2).ToList().Count,
                Definers = context.Users.Where(u => u.UserTypeId == 3).ToList().Count,
                Users = context.Users.Where(u => u.UserTypeId == 4).ToList().Count,
                Languages = context.Languages.ToList().Count
            };
        }
    }
}
