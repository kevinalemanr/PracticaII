using System;

namespace Programa05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPalindrome;
            string result;

            Console.WriteLine("Escriba la palabra a validar: ");
            string valor = Console.ReadLine();
            ValidarString newArr = new ValidarString(valor);

            isPalindrome =newArr.ValidarCadena();
            
            result = isPalindrome ? "Es Palindromo" : "No es palindromo";

            Console.WriteLine(result);


        }
    }
}
