using System;
using System.IO;

namespace others
{
    public class IO1
    {
        private static string line;

        public static void Main(string[] args)
        {
            using StreamWriter file = new StreamWriter("pedro.txt", append: true);
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("pedro.txt");

                //Write a line of text
                sw.WriteLine("Hello");

                //Write a second line of text
                sw.WriteLine("Bye");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("pedro.txt");

                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
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

        }
    }
}