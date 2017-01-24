using SLD.Logic.Implementation;
using SLD.Logic.Interfaces;
using SLD.Object.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLD.Service.Controllers
{
    public class UserController : ApiController
    {
        IUserLogic _userLogic = new UserLogic();

        public IEnumerable<UserDto> GetAllUsers(int userTypeId)
        {
            return _userLogic.Users(userTypeId);
        }
    }
}
