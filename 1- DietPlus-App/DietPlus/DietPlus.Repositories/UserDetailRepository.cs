using DietPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class UserDetailRepository : BaseRepository<UserDetail>
    {
        UserDetail _userDetail;
        public UserDetailRepository(UserDetail userDetail)
        {
            _userDetail = userDetail;
        }
        public UserDetailRepository()
        {
            
        }
    }
}
