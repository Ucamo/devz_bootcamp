/*
Problema #3
Dado un índice de renglón, regresa el renglón correspondiente del triángulo de pascal.
*/
class PascalTriangle {
    static void Main() {
        TestPascal();
    }
    
    static void TestPascal(){
        int target=0;
        Console.WriteLine("Input "+target);
        GetRowByTarget(target);
        target=3;
        Console.WriteLine("Input "+target);
        GetRowByTarget(target);
        target=6;
        Console.WriteLine("Input "+target);
        GetRowByTarget(target);
        target=10;
        Console.WriteLine("Input "+target);
        GetRowByTarget(target);
    }
    
    static int[] GetRowByTarget(int target){
        int [] answer= new int[target+1];
        
        int[,] triangle = new int[target+1,target+1];
        
        for(int x=0;x<=target;x++){
            triangle[x,0]=1;
            for(int y=0;y<=target;y++){
                if(y==0){
                    triangle[x,y]=1;
                }else{
                    if(x-1>=0 && y-1>=0){
                        triangle[x,y]=triangle[x-1,y]+triangle[x-1,y-1];
                    }else{
                        if(y<=x){
                             triangle[x,y]=1;
                        }                       
                    }
                }
            }
        }
        //Print Triangle
        Console.WriteLine("Printing Triangle...");
        for(int x=0;x<=target;x++){
            for(int y=0;y<=target;y++){
                Console.Write(triangle[x,y]+",");
            }
            Console.WriteLine();
        }
        
        //Get answer
        for(int x=0;x<=target;x++){
            answer[x]=triangle[target,x];
        }
        //Print answer
        Console.WriteLine("Printing answer...");
        Console.Write("[");
        foreach(int var in answer){
            Console.Write(var+",");
        }
        Console.WriteLine("]");
        return answer;
    }
}