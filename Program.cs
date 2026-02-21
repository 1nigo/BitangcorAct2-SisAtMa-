namespace BitangcorAct2_SisAtMa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Attendance Management (PUPSIS)-----");


            String[] students = new string[12];

            students[0] = "Alcantara";
            students[1] = "Baseleres";
            students[2] = "Bitangcor";
            students[3] = "Cabillo";
            students[4] = "Cruz";
            students[5] = "David";
            students[6] = "Fernandez";
            students[7] = "Mallon";
            students[8] = "Penaflor";
            students[9] = "Rodriguez";
            students[10] = "Santa  Rosa";
            students[11] = "Trinidad";

            String[] results = new string[12];

            for (int i = 0; i < students.Length; i++){
                Console.Write((i + 1) + ".) " + students[i] + " = ");
                string y = Console.ReadLine();

                for (int j = 0; j < students[i].Length; j++){
                    results[j] = y;
                }


            }
            Console.WriteLine("Summarization of the Attendance:");

            for (int x = 0; x < students.Length; x++) {
                Console.WriteLine((x + 1) + ".) " + students[x] + " = " + results[x]);
            }





        }
    }
}