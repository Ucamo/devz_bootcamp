/*
Dada una lista de números enteros no negativos, divide la lista en dos partes de tal manera que el promedio de ambas partes sea igual.
Regresa ambas partes, o una lista vacía si no es posible dividir el arreglo.
El primer elemento del arreglo debe tener un número de elementos menor o igual al segundo elemento del arreglo.
Si existen múltiples soluciones, regresa la solución donde el primer elemento del arreglo sea mínimo.
Input: [1, 7, 15, 29, 11, 9] Output: [[9, 15], [1, 7, 11, 29]]

*/
class Promedios {
    static void Main() {
        TestAverages();
    }
    
    static void TestAverages(){
        Console.WriteLine("Input: [1, 7, 15, 29, 11, 9] ");
        int[] input = new int[]{1,7,15,29,11,9};
        CalculateAverage(input);
        Console.WriteLine("Input: [1, 2, 3, 4, 5, 6] ");
        input = new int[]{1,2,3,4,5,6};
        CalculateAverage(input);
    }
    
    static void CalculateAverage(int[] input){
        int n=input.Length;
        if(n<=0){
            return;
        }
        int sum = Sum(input.ToList());
        Console.WriteLine("n "+n+" sum "+sum);
        int s1=0;
        int n1=0;
        foreach(int num in input){
            if((sum*num)%n==0){
                n1=num;
                s1=(sum*num)/n;
                break;
            }
        }
        Console.WriteLine("s1 "+s1+" n1 "+n1);        
        //Check combinations
        //Goal is s and n
        //Is S posible adding up n elements?
        //Question: In this case, duplicate s and n ???????
        if(!IsPosible(input,s1,n1)){
            s1=s1*2;
            n1=n1*2;
            if(IsPosible(input,s1,n1)){
                Console.WriteLine("s1 "+s1+" n1 "+n1);
                //Choose elements of input.
                List<int> firstList=GetFirstElements(input,s1,n1);
                Console.WriteLine("First list");
                PrintList(firstList);
                //Remove elements from first list from input
                List<int> secondList = new List<int>();
                foreach(int num in input){
                    if(!firstList.Contains(num)){
                        secondList.Add(num);
                    }
                }
                Console.WriteLine("Second list");
                PrintList(secondList);
                
            }
        }else{
            Console.WriteLine("s1 "+s1+" n1 "+n1);
                //Choose elements of input.
                List<int> firstList=GetFirstElements(input,s1,n1);
                Console.WriteLine("First list");
                PrintList(firstList);
                //Remove elements from first list from input
                List<int> secondList = new List<int>();
                foreach(int num in input){
                    if(!firstList.Contains(num)){
                        secondList.Add(num);
                    }
                }
                Console.WriteLine("Second list");
                PrintList(secondList);
        }
    }
    
    static void PrintList(List<int> list){
        foreach(int num in list){
            Console.Write(num+",");
        }
        Console.WriteLine();
    }
    
    static List<int> GetFirstElements(int [] input, int s, int n){
        List<int> list = new List<int>();
        bool clearList=true;
            for(int i=0;i<n;i++){
                    int s1=0;
                    for(int z=0;z<input.Length;z++){
                        if(!clearList){
                            break;
                        }
                        s1=input[z];
                        list.Add(input[z]);
                        for(int y=0;y<input.Length;y++){
                            if(s1+input[y]==s){
                                list.Add(input[y]);
                                clearList=false;
                                break;
                            }
                        }
                        if(clearList){
                            list = new List<int>();
                        }
                    }
            }
        return list;
    }
    
    static bool IsPosible(int[] input,int s, int n){
        bool isPosible=false;
        for(int x=0;x<input.Length;x++){
            if(n==1){
                if(input[x]==s){
                    isPosible=true;
                }
            }else{
                for(int i=0;i<n;i++){
                    int s1=0;
                    for(int z=0;z<input.Length;z++){
                        s1+=input[z];
                        for(int y=0;y<input.Length;y++){
                            if(s1+input[y]==s){
                                isPosible=true;
                            }
                        }
                    }
                }
            }

        }
        return isPosible;
    }
    
    static int Sum(List<int> input){
        int total=0;
        foreach(int num in input){
            total+=num;
        }
        return total;
    }
    
    
    static int Average(List<int> input){
        int total=input.Count;
        if(total<=0){
            return total;
        }
        int counter=0;
        foreach(int num in input){
            counter+=num;
        }
        Console.WriteLine("Average "+counter/total);
        return counter/total;
        
    }
    
    
    
    
    
}