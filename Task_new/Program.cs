using System;

namespace Task_new
{
    class Program
    {

        public static char cipher(char ch, int key) {  
            if (!char.IsLetter(ch)) {  
               char num = '0';
               return (char)((((ch + key) - num) % 9) + num);  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - d) % 26) + d);  
        }  
  
  
        public static string Encipher(string input, int key) {  
            string output = string.Empty;  
  
            foreach(char ch in input)  
                output += cipher(ch, key);  
    
            return output;  
        }  
  
        public static string Decipher(string input, int key) { 
            string output = string.Empty;

            foreach(char ch in input){
                if (!char.IsLetter(ch)) {
                    output += cipher(ch, 9 - key);
                } else {
                    output += cipher(ch, 26 - key);
                }
            }
            return output;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt:");  
            string UserString = Console.ReadLine();  
  
            Console.WriteLine("\n");  
  
            Console.Write("Enter your Key: ");  
            int key = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("\n");  
  
            Console.WriteLine("Encrypted Data");  
  
            string cipherText = Encipher(UserString, key);  
            Console.WriteLine(cipherText);  
            Console.Write("\n");  
  
            Console.WriteLine("Decrypted Data:");  
  
            string t = Decipher(cipherText, key);  
            Console.WriteLine(t);  
            Console.Write("\n");  

            Console.ReadKey(); 
        }
    }
}
