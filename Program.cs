using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsoulDataFile;
namespace hash
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {

                UInt32[] x = { 0x400A7A71, 0xBE0A9967, 0xED26C8B1, 0x9BFB132F, 0x4B0C5A46, 0x4F14EAAE, 0xE6FEDCB8, 0xE3E3A0DB, 0x5A653E54, 0x7A757C7B, 0xFD89E867, 0xD9B384DD, 0xE5EAEC06, 0x9203B544, 0x43FF82A7, 0x159226D6, 0x2742FD2E };
                String s = "'0123456789abcdefghijklmnopqrstuvwxyz!#$%&()*+,-./:;<=>?@[\\]^_`{|}~\t";
                int l = s.Length;
                /*
                foreach (char a in s) {
                    foreach (char b in s) {
                        foreach (char c in s) {

                            String tmp = String.Format("{0}{1}{2}", a, b, c);
                            UInt32 hash = HashAlgorithm.Hash(tmp);
                            int pos = Array.IndexOf(x, hash);
                            if (pos != -1) {
                                Console.WriteLine("{0:x4} -> {1}", hash, tmp);
                            }

                        }
                    }
                }
                */
                for (int a = 0; a < 128; ++a)
                {
                    for (int b = 0; b < 128; ++b)
                    {
                        for (int c = 0; c < 128; ++c)
                        {
                        

                            String tmp = String.Format("{0}{1}{2}", (char)a, (char)b, (char)c);
                            UInt32 hash = HashAlgorithm.Hash(tmp);
                            int pos = Array.IndexOf(x, hash);
                            if (pos != -1)
                            {
                                Console.WriteLine("map[0x{0:x4}] = '{1}'", hash, tmp);
                            }
                        }
                    }
                }
                Console.WriteLine("all things done.");
                Console.ReadKey(true);

            }
            else {
                Console.WriteLine("0x{0:x4}", HashAlgorithm.Hash(args[0]));
            }
        }
    }
}
