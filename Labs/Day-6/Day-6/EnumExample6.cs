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
    class ABC
    {

    }
    internal class EnumExample6
    {
        public static void Main()
        {
            if ((int)UserStatus.Active==1)
            {
                Console.WriteLine(UserStatus.Active);
            }
            ABC c=new ABC();

            var sampleData = new
            {
                StudentID=1,
                StudentName="Vikash"
            };
            Console.WriteLine(sampleData.StudentID);
        }
    }
}
