using System;
using System.Security.Cryptography;

namespace HTMTTuan3
{
    class Program
    {
        private static int i;
        private static double pow;

        //Chuyển đổi số từ hệ 10 về hệ 2
        static string DecToBin(byte DecNumber)
        {
            if (DecNumber == 0)
            {
                return "00000000";
            }
            string BinResult = "";
            while (DecNumber > 0)
            {
                byte Exc = (byte)(DecNumber % 2);
                BinResult = Exc + BinResult;
                DecNumber = (byte)(DecNumber / 2);
            }

            return BinResult;
        }

        //Chuyển đổi số từ hệ 10 về hệ 16
        static string DecToHex(byte DecNumber)
        {
            if (DecNumber == 0)
            {
                return "0";
            }
            string HexResult = "";
            string HexDigits = "0123456789ABCDEF";
            while (DecNumber > 0)
            {
                int Exc = DecNumber % 16;
                char Hex = HexDigits[Exc];
                HexResult = Hex + HexResult;
                DecNumber = (byte)(DecNumber / 16);
            }
            return HexResult;
        }

        //Chuyển đổi số từ hệ 16 về hệ 10
        static byte HexToDec(string HexNumber)
        {
            byte DecResult = 0;
            string HexDigits = "0123456789ABCDEF";
            for (int i = HexNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
            {
                char Hex = HexNumber[i];
                int HexIndex = HexDigits.IndexOf(Hex); ;
                DecResult += (byte)(HexIndex *(int)Math.Pow(16, pow));
            }
            return DecResult;
        }
        
        //Chuyển đổi số từ hệ 16 về hệ 2
        static string HexToBin(string HexNumber)
        {
            //Chuyển đổi số từ hệ 16 về hệ 10
            byte DecResult = 0;
            string HexDigits = "0123456789ABCDEF";
            for (int i = HexNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
            {
                char Hex = HexNumber[i];
                int HexIndex = HexDigits.IndexOf(Hex); ;
                DecResult += (byte)(HexIndex *(int)Math.Pow(16, pow));
            }
            
            //Chuyển đổi số từ hệ 10 về hệ 2
            if (DecResult == 0)
            {
                return "00000000";
            }
            string BinResult = "";
            while (DecResult > 0)
            {
                byte Exc = (byte)(DecResult % 2);
                BinResult = Exc + BinResult;
                DecResult = (byte)(DecResult / 2);
            }

            return BinResult;
        }

        
        //Chuyển đổi số từ hệ 2 về hệ 10
        static byte BinToDec(string BinNumber)
        {
            byte DecResult = 0;
            for (int i=BinNumber.Length-1, pow = 0;i>=0;pow--,i++)
            {
                DecResult += (byte)Math.Pow(2, pow);
            }    
            return DecResult;
        }
        
        //Chuyển đổi số từ hệ 2 về hệ 16
        static string BinToHex(string BinNumber)
        {
            //Chuyển đổi số từ hệ 2 về hệ 10
            byte DecResult = 0;
            for (int i = BinNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
                {
                int digit = BinNumber[i] - '0'; // Convert character to integer value
                DecResult += (byte)(digit*(int)Math.Pow(2, pow));
            }
            //Chuyển đổi số từ hệ 10 về hệ 16
            if (DecResult == 0)
            {
                return "0";
            }
            string HexResult = "";
            string HexDigits = "0123456789ABCDEF";
            while (DecResult > 0)
            {
                int Exc = DecResult % 16;
                char Hex = HexDigits[Exc];
                HexResult = Hex + HexResult;
                DecResult = (byte)(DecResult / 16);
            }
            return HexResult;
        }
		
        static void Main(string[] args)
        {

            //Chuyển từ hệ 10 sang hệ 2,16
            Console.WriteLine("Nhap so he 10 can chuyen: ");
            byte input = byte.Parse(Console.ReadLine());
            string BinResult = DecToBin(input);
            string HexResult = DecToHex(input);
            Console.WriteLine($"He 2 cua so {input}: {BinResult}");
            Console.WriteLine($"He 16 cua so {input}: {HexResult}");


            
            //Chuyển từ hệ 16 sang hệ 10,2
            Console.WriteLine("Nhap so he 16 can chuyen: ");
            string input2 = Console.ReadLine();
            byte DecResult2 = HexToDec(input2);
            string BinResult2=HexToBin(input2);
            Console.WriteLine($"He 10 cua so {input2}: {DecResult2}");
            Console.WriteLine($"He 2 cua so {input2}: {BinResult2}");
           

            
            //Chuyển từ hệ 2 sang hệ 10,16
            Console.WriteLine("Nhap so he 2 can chuyen: ");
            string input3 = Console.ReadLine();
            byte DecResult3 = BinToDec(input3);
            string HexResult3 = BinToHex(input3);
            Console.WriteLine($"He 10 cua so {input3}: {DecResult3}");
            Console.WriteLine($"He 16 cua so {input3}: {HexResult3}");
            
        }
    }
}