using System.ComponentModel.Design;
using System.Transactions;
using System.Xml.Schema;

namespace EducationC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   ///////////////Data types///////////////////

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
            #endregion


            #region yeni task
            //string command;
            //while (true)
            //{
            //    Console.WriteLine("Enter command:");
            //    command = Console.ReadLine();

            //    if (command == "/givemyname")
            //    {
            //        Console.WriteLine("Yusif");
            //    }
            //    else if (command == "/hello")
            //    {
            //        Console.WriteLine("Salam");
            //    }
            //    else if (command == "/hellohowareyou")
            //    {
            //        Console.WriteLine("Unknown command. Available commands: /hello, /givemyname, /exit");
            //    }
            //    else if (command == "/exit")
            //    {
            //        Console.WriteLine("Exit program :");
            //    }
            //    else command = "/wrong command :";

            //    Console.WriteLine("Unknwon command :");








            #endregion

            #region kecmis tasklardan
            //string fullmyName = "Huseynzade Yusif";
            //int myAge = 62;
            //bool myIsMarried = false;
            //bool haschild = false;

            //Console.WriteLine("FullmyName :" + " " + fullmyName);
            //Console.WriteLine("MyAge :" + " " + myAge);
            //Console.Write("IsMarried :");

            //if (myIsMarried)
            //{
            //    Console.WriteLine(" Beli evlidir.");
            //    if (haschild)
            //    {
            //        Console.WriteLine(" Beli usagi var. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Xeyr usagi yoxdur. ");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine(" Xeyr evli deyildir.");
            //}
            //if (myAge <= 25)
            //{
            //    Console.WriteLine(myAge + " Yasli Gencdir." );
            //}
            //else if (myAge >= 25 && myAge <= 50)
            //{
            //    Console.WriteLine(myAge + " Yasli Cavandir. ");

            //}
            //else { Console.WriteLine(myAge + " Yasli Qocadir. "); }
            #endregion

            #region 1. Məzənnə hesablama programı
            /// Calculating step
            //float USD = 1.70f;
            //float EURO = 1.8104f;
            //float RUB = 0.0223f;

            //Console.WriteLine("Enter the amount :");
            //float azns = float.Parse(Console.ReadLine());

            //Console.WriteLine("Total Azn :" + azns);
            //Console.WriteLine("Usd :" + USD * azns);
            //Console.WriteLine("Euro :" + EURO * azns);
            //Console.WriteLine("Rub :" + RUB * azns);
            #endregion

            #region 2. Ölkə büdcəsini hesablanmasına aid program 

            //int Governmentamount = 200000000;

            //Console.WriteLine(Governmentamount);
            //Console.WriteLine("Military Ministry :" + Governmentamount / 100 * 20 );
            //Console.WriteLine("High Tech Ministry :" +  Governmentamount / 100  * 10);
            //Console.WriteLine("");
            //Console.WriteLine("The lastest in amount :" + Governmentamount / 100 * 70);


            #endregion

            #region 3. Kargo sifarişlərinin hesablanması üçün program 
            ///Defining step 
            //string firstBrandName = "Adidas";
            //int firstBuyingShoes = 4;
            //int firstCount = 200;

            //string secondBrandName = "Gucci";
            //int secondBuyingShoes = 2;
            //int secondCount = 1000;

            //string thirdBrandName = "Nike";
            //int thirdBuyingShoes = 1;
            //int thirdCount = 150;

            //Console.WriteLine("Company of Name :" + firstBrandName);
            //Console.WriteLine("Number of shoes :" + firstBuyingShoes);
            //Console.WriteLine("Shoes of count :"  + firstCount);
            //Console.WriteLine("Price all together :" + firstBuyingShoes * firstCount);
            //Console.WriteLine("");
            //Console.WriteLine("Company of Name :" + secondBrandName);
            //Console.WriteLine("Number of shoes :" + secondBuyingShoes);
            //Console.WriteLine("Shoes of count :" + secondCount);
            //Console.WriteLine("Price all together :" + secondBuyingShoes * secondCount);
            //Console.WriteLine("");
            //Console.WriteLine("Company of Name :" + thirdBrandName);
            //Console.WriteLine("Number of shoes :" + thirdBuyingShoes);
            //Console.WriteLine("Shoes of count :" + thirdCount);
            //Console.WriteLine("Price all together :" + thirdBuyingShoes * thirdCount);
            #endregion

            #region Arrayler ve 2. Terminalda məzənnə idarəetmə sistemi

            /// Array loop 
            //int namesCount = int.Parse(Console.ReadLine());
            //string[] names = new string[namesCount];    
            //int fillIndex = 0;
            //while (fillIndex < namesCount)
            //{
            //    names[fillIndex] = Console.ReadLine();
            //    fillIndex++;    
            //}
            //int index = 0;

            //while (index < names.Length)
            //{
            //    Console.Write(names[index]);
            //    index++;
            //}

            /// 2. Terminalda məzənnə idarəetmə sistemi
            //do
            //{
            //    string[] currencies = { "USD", "RUB", "TRY", "EUR" };
            //    decimal[] currencyRates = { 1.70M, 0.0223M, 0.0894M, 1.82M };
            //    Console.WriteLine("Available command : ");
            //    Console.WriteLine("/ show - recent - currency - rates");
            //    Console.WriteLine("/ find - currency - rate - by - code");
            //    Console.WriteLine("/ calculate - amount - by - currency");
            //    Console.WriteLine("/exit");
            //    Console.WriteLine();

            //    Console.Write("Please enter cmd :");
            //    string command = Console.ReadLine();



            //    if (command == "/ show - recent - currency - rates")
            //    {
            //        Console.WriteLine("Currency Rates ");
            //    }
            //    else if (command == "/ find - currency - rate - by - code")
            //    {
            //        Console.WriteLine("Currency rate by code ");
            //    }
            //    else if (command == "/ calculate - amount - by - currency")
            //    {
            //        Console.WriteLine("Amount by currency");
            //    }
            //    else if (command == "/exit")
            //    {
            //        Console.WriteLine("Exit ");
            //        break

            //    }
            //    else
            //    {
            //        Console.WriteLine("/Command not found");
            //    }
            //} while (true);






            #endregion
        }
    }
}
