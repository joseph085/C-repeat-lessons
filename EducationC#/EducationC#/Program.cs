using System.Transactions;

namespace EducationC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////Data types///////////////////

            //bool heYadaYox = false; // true
            //string ad = "Salam";
            //char herf = 'A';
            //int reqem = 5;
            //float natamamEded = 1.4254f;
            //double dahaBoyukNatamamEded = 1.4256216231d;
            //decimal heddinanArtiqBoyukNatamamEded = 1.35258239581895891235185981351818M;

            /////////////////////////////////////////////
            //     == (beraber)  != (beraber deyil)  || (ve ya)  && (ve)   ! (deyil)   <    >   <=   >=

            //Example:
            // Console.Write("Enter the number: ");
            // int a = int.Parse(Console.ReadLine());

            // if (a % 4 == 0)
            // {
            //     Console.WriteLine("Even");      //12    13    14    15    16    17    18    19    20
            // }
            // else if (a % 4 == 1)
            // {
            //     Console.WriteLine("Odd");
            // }
            // else if (a % 4 == 2)
            // {
            //     Console.WriteLine("ok");
            // }
            //else if  (a % 4 == 3)
            // {
            //     Console.WriteLine("Odin");
            // }
            // else  
            // {
            //     Console.WriteLine("Salam");

            // }



            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine("daga");
            //}
            //while (a < 5)
            //{
            //    Console.WriteLine("sda");
            //}
            //do
            //{
            //    Console.WriteLine("sd");
            //} while (a + 5 < 51);

            ///// New Task \\\\\\

            //string givemyName = "Enter the command :" + Console.ReadLine();
            //string hello = "Salam";
            //string enter = "Enter the command :";
            //string exit = "Cixis :";

            //while (enter == enter )
            //{
            //    Console.WriteLine();
            //}

            #region yeni task
            string command;
            while (true)
            {
                Console.WriteLine("Enter command:");
                command = Console.ReadLine();

                if (command == "/givemyname")
                {
                    Console.WriteLine("Yusif");
                }
                else if (command == "/hello")
                {
                    Console.WriteLine("Salam");
                }
                else if (command == "/hellohowareyou")
                {
                    Console.WriteLine("Unknown command. Available commands: /hello, /givemyname, /exit");
                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Exit program :");
                }
                else command = "wrong command :";

                {
                    Console.WriteLine("Unknwon command :");

                }



               
            }
            #endregion






        }
    }
}