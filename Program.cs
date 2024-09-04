namespace MidTerm_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IJE4R1
            //Muhammad Eman Aftab

            try
            {
                Enor t = new Enor("input.txt");
                t.first();

                if (t.end())
                {
                    Console.WriteLine("File is empty or not enough data.");
                }

                else
                {
                    //Maximum Search
                    Data elem = t.current();
                    int max = t.current().count;
                    t.next();

                    while (!t.end())
                    {
                        if (t.current().count > max)
                        {
                            max = t.current().count;
                            elem = t.current();
                        }
                        t.next();
                    }

                    Console.WriteLine(elem.month);
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found.");
            }
        }
    }
}