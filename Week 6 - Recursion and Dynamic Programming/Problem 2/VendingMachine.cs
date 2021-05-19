/*
Has decidido adentrarte al mundo del emprendimiento inventando una máquina vendedora de comida saludable. Ya tienes todo funcionando, solamente necesitas terminar el algoritmo que devuelve el cambio al cliente.
Imagina que tu máquina no devuelve centavos. Imagina también que tu máquina tiene un número ilimitado de monedas. Las monedas que puede devolver tu máquina son $1, $2, $5, $10.
Dado el cambio que tu máquina tiene que devolverle al cliente, regresa el mínimo número de monedas que tu máquina tiene que devolver para completar el cambio.
Por ejemplo:
N = 6, resultado = 2 (5 y 1). 	N = 8, resultado = 3 (5, 2 y 1)
Follow up: Resuelve para un dado set de monedas. Es decir, las entradas serían el cambio a devolver y un set de monedas disponibles.
*/
class VendingMachine {
    static void Main() {
        Test();
    }
    
    static void Test(){
        Console.WriteLine("Coins: 1,2,5,10");
        int[] coins = new int[]{1,2,5,10};
        GetChange(6,coins);
        GetChange(8,coins);
        GetChange(10,coins);
        Console.WriteLine("New coins 1,2,3,20,50,100");
        coins = new int[]{1,2,3,20,50,100};
         GetChange(6,coins);
         GetChange(130,coins);
         GetChange(270,coins);
    }
    
    static void GetChange(int change, int[] coins){
        //Sort coins
        Array.Sort(coins);
        List<int> minChange = new List<int>();
        int pendingChange = change;
        CheckPending(pendingChange,coins,minChange, coins.Length-1);
        //Print result
        Console.WriteLine("N = "+change);
        Console.Write(minChange.Count+" (");
        foreach(int val in minChange){
            Console.Write(val+",");
        }
        Console.Write(")");
        Console.WriteLine();        
    }
    
    static void CheckPending(int pending, int[] coins, List<int>minChange, int counter){
        if(pending<=0){
            return;
        }
        if(pending >= coins[counter]){
            minChange.Add(coins[counter]);
            pending-= coins[counter];
        }else{
            counter--;
        }
        CheckPending(pending,coins,minChange,counter);
    }
}