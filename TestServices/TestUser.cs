using OnlineShop.Users.Models;
using OnlineShop.Users.Service;
using OnlineShop.Users.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestServices
{
    public class TestUser
    {

        private IUserComandService _comandUser;

        private string path = @"Users\Data\users.txt";

        [Fact]
        public void Comand_WhenIstrue()
        {

            User user = new User(1, "ASd", "ASd", "sad", "0434444", "asda", 18);

            List<User> users = new List<User>();    

            _comandUser = new UserComandService(users);

            Assert.Equal(path, _comandUser.Path());

        }

        private IUserQueryService _queryUser;

        [Fact]
        public void QueryUser_WhenIstrue()
        {

            User user = new User(1, "ASd", "ASd", "sad", "0434444", "asda", 18);

            List<User> users = new List<User>();

            _queryUser = new UserQueryservice(users);

            Assert.NotEqual(user, _queryUser.getById(1));
        }

    }
}
