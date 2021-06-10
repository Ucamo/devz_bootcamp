/*
Semana 8 Problema 1
Radix Sort
En radix sort aprovechamos el hecho de que los enteros tienen un número finito de bits.
Iteramos sobre cada dígito y ordenamos los elementos dependiendo del valor de ese dígito.
El proceso se repite por cada uno de los dígitos, al final el arreglo va a estar ordenado.
*/
static class RadixSort {
    static void Main() {
        Test();
    }
    
    static void Test(){
        int[] unsortedArray = new int[]{329,457,657,839,436,720,355};
        Console.WriteLine("New Array [329,457,657,839,436,720,355]");
        Sort(unsortedArray);
        unsortedArray = new int[]{329,457,657,839,436,720,355,100000};
        Console.WriteLine("New Array [329,457,657,839,436,720,355,100000]");
        Sort(unsortedArray);
        unsortedArray = new int[]{432,12,3,0,-12,99,234000,34599,134111111};
        Console.WriteLine("New Array [432,12,3,0,-12,99,234000,34599,134111111]");
        Sort(unsortedArray);
    }
    
    static void Sort(int[] input){
        int length = input.Length;
        int max = input.Max();
        int numberDigits = GetNumberDigits(max);
        Console.WriteLine("Max value "+max+" numberDigits "+numberDigits);
        string module="10";
        for(int x=1;x<=numberDigits;x++){
            Console.WriteLine("Step # "+x);
            int modu = Convert.ToInt32(module);
            SortArray(input,modu);   
            PrintArray(input);
            module+="0";
        }

    }
    
    static void PrintArray(int[] input){
        for(int x=0;x<input.Length;x++){
            Console.WriteLine(input[x]);
        }
    }
    
    static void SortArray(int[] input,int module){
        int temp;
        for(int x=0;x<input.Length-1;x++){
            for(int y=x+1;y<input.Length;y++){
                if(input[x]%module>input[y]%module){
                    temp=input[x];
                    input[x] = input[y];
                    input[y]=temp;
                }
            }
        }
    }
    
    static int GetNumberDigits(this int n)
    {
        if (n >= 0)
        {
            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
        }
        else
        {
            if (n > -10) return 2;
            if (n > -100) return 3;
            if (n > -1000) return 4;
            if (n > -10000) return 5;
            if (n > -100000) return 6;
            if (n > -1000000) return 7;
            if (n > -10000000) return 8;
            if (n > -100000000) return 9;
            if (n > -1000000000) return 10;
            return 11;
        }
    }
}