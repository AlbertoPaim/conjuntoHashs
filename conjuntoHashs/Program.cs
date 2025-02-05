﻿using conjuntoHashs.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)

        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file full path:");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord
                        {
                            UserName = name,
                            Instant = instant
                        });

                    }

                    Console.WriteLine("Total users:" + set.Count);
                }
            }
            catch (IOException error)
            {
                Console.WriteLine(error.Message);
            }
        }

    }
}