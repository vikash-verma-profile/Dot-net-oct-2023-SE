using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    enum UserStatus
    {
        Active=1,
        Inactive=2,
        Hold=3
    }
    internal class EnumExample6
    {
        public static void Main()
        {
            if ((int)UserStatus.Active==1)
            {
                Console.WriteLine(UserStatus.Active);
            }
        }
    }
}
