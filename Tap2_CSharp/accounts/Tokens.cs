using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace accounts
{
    public class Tokens
    {
        
        public static void Main(String[] args)
        {
            string line;
            List<Account> list = new List<Account>();

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("accounts.txt");
                
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();

                    StringTokenizer tokens = new StringTokenizer(line, ",");
                    while (tokens.HasMoreTokens)
                    {
                        Account c = new Account(tokens.NextToken, tokens.NextToken, tokens.NextToken, Double.Parse(tokens.NextToken));
                        list.Add(c);
                    }

                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


     
            foreach (Account acc in list)
            {
                Console.WriteLine(acc);
            }



            Console.WriteLine("Exercise 1: MAP");
            //List<Account> result0= list.OfType<Account>().ToList().ForEach(c => c.deposit(100));
            list.ForEach(c => c.deposit(100));
            list.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("Exercise 2: FILTER");
            List<Account> result = (List<Account>)list.Where(c => c.GetType().Equals((AccType.IF)));
            result.ForEach(e => Console.WriteLine(e));


            Console.WriteLine("Exercise 3: MAX");
            List<Account> result1 = (List<Account>)list.Where(c => c.GetType().Equals((AccType.IF)));
            //string resultacc = result1.Max(p => p.GetBalance() == result1.Max(y => y.GetBalance()));

            //Console.WriteLine(resultacc);
        }
    }
}
