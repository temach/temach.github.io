using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace EncodingsTemplate
{

    [Serializable]
    public class Point
    {
        private double xVal;
        private double yVal;
        [NonSerialized]
        private double len = 0;

        public Point(int x, int y)
        {
            xVal = x;
            yVal = y;
        }

        public double x { get { return xVal; } }
        public double y { get { return xVal; } }
        public double Length
        {
            get
            {
                if (len == 0) {
                    len = Math.Sqrt(x * x + y * y);
                }
                return len;
            }
        }

        public void SaveData(Stream s)
        {
            var w = new BinaryWriter(s);
            w.Write(xVal);
            w.Write(yVal);
            w.Flush();
            // don't close so other can write here too
        }

        public void LoadData(Stream s)
        {
            var r = new BinaryReader(s);
            xVal = r.ReadDouble();
            yVal = r.ReadDouble();
        }

    }

    class Program
    {

        public static void SerialisePoints(Stream stm )
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);

            // this needs to be fixed
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stm, p1);
            bf.Serialize(stm, p2);
            bf.Serialize(stm, p3);
            str.Close();
        }
        public static void ExampleAdvancedRead()
        {
            // complicated file string write to file
            string file = @"C:\Temp\New Folder\New Text Document.txt";
            // open the back end FileStream, throws if file not exists
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {
                // Get a highler level interface with StreamReader, 
                // (pass fs into the constructor, since FileStream can be downcast to Stream)
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    // do stuff with it
                    while (!sr.EndOfStream)
                    {
                        string tmp = sr.ReadLine();
                        Console.WriteLine(tmp != null ? tmp : "another way to detect file end");
                    }
                }

                // this can not read normal strings, because it 
                // prefixes them with their length, but it can read/write 
                // any standard sata type
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
                {
                    bw.Seek(0, SeekOrigin.End);
                    // just remember to read them in the same order!
                    bw.Write(true);
                    bw.Write("what the heck");
                    decimal price = 102.44m;
                    bw.Write(price);
                }
            }
        }

        // example write to file
        public static void CoolReadWrite()
        {
            FileStream my_stream = new FileStream(@"..\..\my_file_stream.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] data = Encoding.ASCII.GetBytes("Hello world!");
            my_stream.Write(data, 0, data.Length);
            //my_stream.Close();

            Stream outStr = my_stream;
            // Seek two bytes back, this will _overwrite_ the "world!"
            my_stream.Seek(-6, SeekOrigin.Current);
            byte[] outBuf = new byte[7] { 82, 105, 99, 104, 97, 114, 100 };     // "Richard"
            outStr.Write(outBuf, 0, outBuf.Length);
            // if we .Close() the my_stream will close
            // outStr.Close();

            Stream inStr = my_stream;
            // skip the capital "H"
            my_stream.Seek(1, SeekOrigin.Begin);
            byte[] inBuf = new byte[(int)inStr.Length];
            // read: (inBuf.Length -1) because we seeked to 1
            int chars_read = inStr.Read(inBuf, 0, inBuf.Length-1);
            // .Read() can return any number between 0 and what you ask for. 
            // Always check how much it read
            if (chars_read == 0)
            {
                Console.WriteLine("reached end of Stream.");
            }
            inStr.Close();

            // just for fun
            string str_from_koi8_bytes = Encoding.GetEncoding("KOI8-R").GetString(inBuf);
            Console.WriteLine(str_from_koi8_bytes);
        }

        public static void CorrectWayToRead_1000_Bytes(Stream stm)
        {
            byte[] data = new byte[1000];
            int total_read = 0;     // this will be 1000 at the end, unless the stm has EOF earlier.
            int cur_chunk_size = 1;
            while (total_read < data.Length && cur_chunk_size > 0)
            {
                total_read += 
                    (cur_chunk_size = stm.Read(data, total_read, data.Length - total_read));
            }
            // Alternatively (much better) use: 
            byte[] data2 = new BinaryReader(stm).ReadBytes(1000);
        }

        static void Main(string[] args)
        {
            // when data is read from file that is supposed to be a text file
            // then this data gets filtered through some Encoding object (by default 
            // System.Text.Encoding.Unicode) which tries to parse the file bytes into UTF-16 char/string
            // similarly when we write the string out it gets filtered through System.Text.Encoding.UTF-8

            // get some encoding object, we use IANA names for the encoding:
            // http://www.iana.org/assignments/character-sets/character-sets.xhtml
            Encoding china = Encoding.GetEncoding("GB18030");
            Encoding utf8 = Encoding.UTF8;

            byte[] utf8_bytes = utf8.GetBytes("asdas11122");
            byte[] utf32_bytes = Encoding.UTF32.GetBytes("asdas11122");

            Console.WriteLine(utf8_bytes.Length);   // 10
            Console.WriteLine(utf32_bytes.Length);  // 40

            string original_utf8 = Encoding.UTF8.GetString(utf8_bytes);

            // more complex file string write to file
            try
            {
                ExampleAdvancedRead();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // throw;
            }

            CoolReadWrite();

            // Remember that File.ReadLines() is lazy evaluated. So its ok with big, big files.
            // HOLY CRAP! when we write with StreamWriter and specify the encoding explicitly, it writes the BOM mark!
            // Be careful when you read the shit back in!
            // to get rid of BOM give StreamWriter constructor a custom encoding:
            var no_bom_utf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);


            // see http://www.codeguru.com/csharp/csharp/cs_data/streaming/article.php/c4223/Streams-and-NET.htm
            // for good stream data including: [Serializable] [NonSerialized]

            // best of all see appendix of chris seil's book
            // ftp://210.212.172.242/Digital_Library/CSE/Programming/Dot%20Net/c%23/Windows%20Forms%20Programming%20in%20C%20Sharp%20by%20chris%20sells%202003.pdf
            Console.ReadKey();
        }


    }
}
