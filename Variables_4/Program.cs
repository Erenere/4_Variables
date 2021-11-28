using System;

namespace Variables_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

            namespace Variables_4
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        byte b = 5;
                        sbyte sb = 5;
                        short s = 5;
                        ushort us = 5;

                        Int16 i16 = 2; //2 byte
                        int i = 2;  // 4 b

                        Int32 i32 = 2; //4
                        Int64 i64 = 3; // 8

                        uint ui = 2; //4
                        long l = 4; //8
                        ulong ul = 4; //8

                        float f = 5; //4
                        double d = 6; //8
                        decimal de = 10;// 16

                        char ch = '2'; //2
                        string s1 = "Eren"; //Unlimited

                        bool b1 = true;
                        bool b2 = false;
            
                        DateTime dt = DateTime.Now;
                        Console.WriteLine(dt);

                        object o1 = "x";
                        object o2 = 'y';
                        object o3 = 4;
                        object o4 = 3.2;

                        string str1 = string.Empty;
                        str1 = "Eren Ack";

                        string ad = "Eren";
                        string soyad = "Ack";
                        string fullname = ad + "" + soyad;

                        string str20 = "20";
                        int int20 = 20;

                        string yeniDeger = str20 + int20.ToString();
                        Console.WriteLine(yeniDeger);

                        int int21 = int20 + Convert.ToInt32(str20);
                        Console.WriteLine(int21);// 40

                        int int22 = int20 + int.Parse(str20);

                        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            
                        Console.WriteLine(datetime);
                        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
                        Console.WriteLine(datetime2);

                        string hour = DateTime.Now.ToString("HH:mm");
                        Console.WriteLine(hour);
                    }
        
                }
            }
        }
    }
}