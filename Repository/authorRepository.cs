using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using configFile;
using System.IO;
namespace Repository
{
    public interface IRepository<T>
    {
        List<T> FindAll();
    }
    public class authorRepository : IRepository<author>
    {

        public List<string> auFields = new List<string>();

        public bool contractField;

        public List<author> FindAll()
        {
            author au;
            List<author> authors = new List<author>();
            int count = 0;
            int[] widths = null;
           

            string author_file = configurationFile.getSetting("authorFile");

            // using statement: object is correctly disposed of
            using (StreamReader reader = File.OpenText(author_file))
            {
                string line = null;

                line = reader.ReadLine(); // get line from file, or null at end of file

                while (line != null)
                {
                    if (count == 0)
                    {
                        string[] fields = line.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                        count++;
                    }
                    else if (count == 1)
                    {

                        string[] fields = line.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
                        widths = new int[fields.Count()];

                        for (int i = 0; i < fields.Count(); i++)
                        {
                            widths[i] = fields[i].Length;
                        }

                        count++;

                    }
                    else if (char.IsNumber(line[0]))
                    {

                        List<string> fields = new List<string>();

                        for (int i = 0; i < widths.Count(); i++)
                        {
                            int width = widths[i];
                            char[] a = new char[width];

                            line = line.Trim();

                            using (StringReader sr = new StringReader(line))
                            {
                                sr.Read(a, 0, width);
                                fields.Add(new string(a).Trim());
                            }

                            if (i < widths.Count() - 1)
                                line = line.Remove(0, width);
                        }

                        for (int i = 0; i < fields.Count(); i++)
                        {
                            if(i == 8)
                            {
                                if(fields[i] == "1\0\0\0\0\0\0\0")
                                {
                                    contractField = true;
                                }
                                else
                                {
                                    contractField = false;
                                }
                            }

                            auFields.Add("nothing yet");
                            auFields[i] = fields[i];
                        }

                        au = new author(auFields[0], auFields[1], auFields[2], auFields[3], auFields[4], auFields[5], auFields[6], auFields[7], contractField);
                        authors.Add(au);

                    }
                   
                    line = reader.ReadLine(); // next line in file 
 
                }

                return authors;
            }
        }
    }
}
