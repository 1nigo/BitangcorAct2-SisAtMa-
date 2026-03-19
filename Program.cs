using attedanceModels;
using attendanceAppService;

namespace BitangcorAct2_SisAtMa_
{
    internal class Program
    {
        static string studname;
        static int present, absent;
        static char ans;
        static void Main(string[] args)
        {
            Console.WriteLine("-----Attendance Management (PUPSIS)-----");
            while (true)
            {
                Console.Write("Enter Student Name: ");
                studname = Console.ReadLine();
                Console.Write("Enter Numbers of Days Present: ");
                present = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Numbers of Days Absent: ");
                absent = Convert.ToInt32(Console.ReadLine());
            ;

                Console.WriteLine("Student has been recorded successfully!");

                Console.Write("do you want to add another student? (Y/N)");
                ans = Console.ReadKey().KeyChar;
                ans = char.ToUpper(ans);
                Console.WriteLine();
                if (ans != 'Y')
                {
                    break;
                }

            }

        }
    }
}