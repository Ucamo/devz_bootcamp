/*
Problema #1
Escribe   un   programa   que   verifique   que   una   frase   es   un   palíndromo. 
Un palíndromo es una frase que se lee igual de derecha a izquierda que de izquierda a derecha.
Ejemplos
In:  “La ruta nos aportó otro paso natural”
Out:true
In:“Claramente, esto no es un palíndromo”
Out:  false
*/

class IsPalindromeClass {
    static void Main() {
        string palindrome="anita lava la tina";
        TestIsPalindrome(palindrome);
        palindrome="This is not a palindrome";
        TestIsPalindrome(palindrome);
        palindrome="La ruta nos aportó otro paso natural";
        TestIsPalindrome(palindrome);
        palindrome="Claramente, esto no es un palíndromo";
        TestIsPalindrome(palindrome);
    }
    
    static void TestIsPalindrome(string input){
        Console.WriteLine(input);
        IsPalindrome(input);
    }
    
    static bool IsPalindrome(string input){
        input = CleanInput(input); //remove spaces, special characters, etc
        char[] a1 = input.ToCharArray();
        char[] a2 = new char[a1.Length];
        int counter=0;
        for(int x=a1.Length-1;x>=0;x--){
            a2[counter]=a1[x];
            counter++;
        }
        string pal = new string(a2);
        if(input==pal){
            Console.WriteLine("true");
            return true;
        }else{
            Console.WriteLine("false");
            return false;
        }
    }
    
    static string CleanInput(string inp){
        inp = inp.ToLower();
        inp = inp.Replace(" ","");
        inp = inp.Replace("á","a");
        inp = inp.Replace("é","e");
        inp = inp.Replace("í","i");
        inp = inp.Replace("ó","o");
        inp = inp.Replace("ú","u");
        inp = inp.Replace(",","");
        inp = inp.Replace(".","");
        return inp;
    }
}