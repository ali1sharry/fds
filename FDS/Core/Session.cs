using FDS.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.Core
{
   static class Session
    {
         public static string username;
         public static string password;
         public static int? type;
         public static string name;
        static Session()
        {

        }
       public static void Role(ObservableCollection<User> _u)
        {
            username = _u[0].Username;
            password = _u[0].Password;
            name = _u[0].FullName;
            type = _u[0].Role;
                
        }
    }
}
