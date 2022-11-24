using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Raschet
    {
       public static string FirstIterat(DateTimePicker Value)
        {
            StreamReader Timet = new StreamReader("Statistics\\BusTimetable.txt");
            string Timetable;
            Timetable = Convert.ToString(Timet.ReadToEnd());
            double[,] G = new double[5, 40];
            string Per;
            string[] Cron = new string[1000];
            Per = "";
            int j = 0;
            int k = 0;
            for (int i = 0; i < Timetable.Length; i++)
            {
                Per = Per + Convert.ToString(Timetable[i]);
                if (Timetable[i] == Convert.ToChar("\r"))
                {
                    i = i + 1;
                    Cron[j] = Convert.ToString(Per);
                    Per = "";
                    j++;
                }
            }
            //602
            for (int i = 0; i < 30; i++)
            {
                G[0, i] = 6 * 60 + 15 + 30 * i; 
            }
            //652Д
            for(int i = 0; i < 30; i++)
            {
                G[1, i] = 6 * 60 + 15 + 30 * i;
            }
            //652T
            for (int i = 0; i < 30; i++)
            {
                G[2, i] = 6 * 60 + 15 + 30 * i;
            }
            //607
            for (int i = 0; i < 30; i++)
            {
                G[3, i] = 6 * 60 + 15 + 30 * i;
            }
            //
            //Ласточка
            //
            G[4, 0] = 8 * 60 + 12;
            G[4, 1] = 8 * 60 + 25;
            G[4, 2] = 8 * 60 + 30;
            G[4, 3] = 8 * 60 + 37;
            G[4, 4] = 8 * 60 + 46;
            G[4, 5] = 8 * 60 + 53;
            G[4, 6] = 9 * 60;
            G[4, 7] = 9 * 60 + 25;
            G[4, 8] = 9 * 60 + 42;
            G[4, 9] = 10 * 60 + 11;
            G[4, 10] = 14 * 60;
            G[4, 11] = 14 * 60 + 10;
            G[4, 12] = 14 * 60 + 13;
            G[4, 13] = 14 * 60 + 21;
            G[4, 14] = 14 * 60 + 30;
            G[4, 15] = 14 * 60 + 38;
            G[4, 16] = 14 * 60 + 45;
            G[4, 17] = 15 * 60 + 10;
            G[4, 18] = 15 * 60 + 27;
            G[4, 19] = 15 * 60 + 56;
            G[4, 20] = 18 * 60;
            G[4, 21] = 18 * 60 + 10;
            G[4, 22] = 18 * 60 + 15;
            G[4, 23] = 18 * 60 + 22;
            G[4, 24] = 18 * 60 + 30;
            G[4, 25] = 18 * 60 + 38;
            G[4, 26] = 18 * 60 + 45;
            G[4, 27] = 19 * 60 + 10;
            G[4, 28] = 19 * 60 + 28;
            G[4, 29] = 19 * 60 + 56;
            G[4, 30] = 20 * 60 + 15;
            G[4, 31] = 20 * 60 + 23;
            G[4, 32] = 20 * 60 + 28;
            G[4, 33] = 20 * 60 + 35;
            G[4, 34] = 20 * 60 + 45;
            G[4, 35] = 20 * 60 + 52;
            G[4, 36] = 20 * 60 + 59;
            G[4, 37] = 21 * 60 + 25;
            G[4, 38] = 21 * 60 + 42;
            G[4, 39] = 22 * 60 + 11;
            //
            //Метробус
            //
            G[5, 0] = 7 * 60;
            G[5, 1] = 13 * 60;
            G[5, 2] = 18 * 60 + 30;
            //
            //
            //Время поездок
            double[] Time = new double[5];
            Time[0] = 2 * 60 + 30;
            Time[1] = 2 * 60 + 47;
            Time[2] = 2 * 60 + 5;
            Time[3] = 2 * 60 + 50;
            Time[4] = 60 + 56;
            Time[5] = 60 + 10;
            //
            //Цена за билет
            double[] Price = new double[5];
            Price[0] = 370;
            Price[1] = 370;
            Price[2] = 370;
            Price[3] = 370;
            Price[4] = 199;
            Price[5] = 179;
            //
            // Время прибытия
            for(int i = 0; i < 5; i++)
            {
                switch (i) 
                {
                    case 0:
                        for(j =0;j<30)
                    break;

                }

            /*            for (int i = 0; i < j; i++)
                        {   

                            if (Cron[i] == "№602\r" || Cron[i] == "№652Т\r" || Cron[i] == "№652Д\r" || Cron[i] == "№607\r")
                            {
                                k++;
                            }
                            else
                            {  
                                G[k, i] = Convert.ToDouble(Cron[i].Substring(0) + Cron[i].Substring(1)) * 60 + Convert.ToDouble(Cron[i].Substring(3) + Cron[i].Substring(4));

                            }
                        }
                        Cron.
                       */
            // string Duration = Convert.ToString(Durat.ReadToEnd());
            // StreamReader Durat = new StreamReader("Statisctics\\TripDuration.txt");

            string X = Value.Value.DayOfWeek.ToString();

            switch (X)
            {
                case "Monday":

                    break;
               
                case "Tuesday":
                
                    break;
                
                case "Wednesday":
                
                    break;
               
                case "Thursday":
                
                    break;
                
                case "Friday":
                    
                    break;

                case "Saturday":

                    break;

                case "Sunday":

                    break;
            }
            return Convert.ToString(G[2, 5]);
        }        
    }
}
