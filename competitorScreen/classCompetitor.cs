using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace competitorScreen
{
    public class classCompetitor
    {
        //connectionLink
        public string connLink = System.IO.File.ReadAllText(@"C:\connLink.txt");
        //variables
        public static int questionNo, point, time, a, totalPoint, b;
        public static string answer, addPoint;
    }
}
