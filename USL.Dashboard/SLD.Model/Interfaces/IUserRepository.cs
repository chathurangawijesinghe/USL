using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Model.Interfaces
{
    public interface IUserRepository
    {
        IList<UserDto> Users(int userTypeId);
    }
}
