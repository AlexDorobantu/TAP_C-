using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;


namespace generics
{
    public class Test
    {

        public static void Main(String[] args)
        {
            Collection<String> c;
            String[] lista = new String[] {
                "uno",
                "dos",
                "tres",
                "cuatro",
                "tres"};

            c = new ArrayList<string>();

            for (int i = 0; (i < lista.Length); i++)
            {
                c.Add(lista[i]);
            }

            Test.test(c);
            //  test2(c); //ES ILEGAL !!!!
            Test.test3(c);
        }

        public static void test<T>(Collection<T> c)
        {
            //  string lista[] = {"uno", "dos" , "tres", "cuatro", "tres"};
            //  for( int i=0; i < lista.Length; i++ )
            //  c.add( lista[i] ); //ILEGAL !!
            foreach (T elem in c)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("-------------------------");
        }

        public static void test2(Collection<Object> c)
        {
            foreach (Object elem in c)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("-------------------------");
        }

        public static void test3(Collection<Object> c)
        {
            Iterator it = c.iterator();
            while (it.hasNext())
            {
                Console.WriteLine(it.next());
            }

            Console.WriteLine("-------------------------");
        }
    }

    internal class ArrayList<T> : Collection<string>
    {
    }
}
