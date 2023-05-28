using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Fire
    {
        int employeeid{set; get;}

        date date{set; get;}

        string reason{set; get}
    }
}
class randomGenerator
{

    static void main()
    {
    DateTime startDate = new DateTime(2021, 1, 1); // replace with actual start date
    DateTime endDate = new DateTime(2021, 1, 10); // replace with actual end date

     TimeSpan duration = endDate - startDate;
      int numberOfDays = duration.Days;

      Console.WriteLine("Number of days: " + numberOfDays);
    }
}