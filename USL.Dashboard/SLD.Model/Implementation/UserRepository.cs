using SLD.Model.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Model.Implementation
{
    public class UserRepository : IUserRepository
    {
        SLD_DatabaseEntities context = new SLD_DatabaseEntities();

        public IList<UserDto> Users(int userTypeId)
        {
            return context.Users.Select(u => new UserDto
            {
                UserId = u.UserId,
                Username = u.Username,
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                UserTypeId = u.UserTypeId,
                Country = context.Countries.Where(c => c.CountryId == u.CountryId).Select(s => s.CountryName).FirstOrDefault(),
                Designation = u.Designation,
                Image = u.Image
            }).Where(u => u.UserTypeId == userTypeId).ToList();
        }
    }
}
