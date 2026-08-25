using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01
{
    public class UserRepository : IRepository<User>
    {
        public void Add(User user)
        {
            //Add user
        }

        public User Get(int id)
        {
            return new User();
        }
    }
}
