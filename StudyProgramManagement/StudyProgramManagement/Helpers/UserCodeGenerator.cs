using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Helpers
{
    public static class UserCodeGenerator
    {
        public static int GenerateUserCode(int nextUser)
        {
            var checkSum = 0;
            for (int i = 0; i < 5; i++)
            {
                var temp = nextUser % 10;
                checkSum += temp * (9 - i);
                nextUser = (nextUser - temp) / 10;
            }
            checkSum += 27;
            checkSum = checkSum % 10;
            return checkSum;
        }
    }
}
