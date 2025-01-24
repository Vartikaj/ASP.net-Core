using CommonService.Utility;
using MasterServiceDemo.Interfaces;
using MasterServiceDemo.Models;

namespace MasterServiceDemo.Services
{
    public class UserService : IUser
    {
        private DbGateway _dbgateway;
        public UserService(string _connection)
        {
            this._dbgateway = new DbGateway(_connection);
        }

        public Task<Response<object>> GetAllData()
        {
            throw new NotImplementedException();
        }
    }
}
