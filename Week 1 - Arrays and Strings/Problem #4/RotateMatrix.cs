/*
Problema #4
Dada una matriz NxN, escribe un programa que rote la matriz 90° en senido horario.
¿Puedes hacerlo sin utilizar otra matriz o vectores?
*/
class RotateMatrix {
    static void Main() {
        TestRotate();
    }
    
    static void TestRotate(){
        int[,] matrix = new int[3,3] {
        {0,1,2},
        {3,4,5},
        {6,7,8,}};
        
        Console.WriteLine("Original...");
        PrintMatrix(matrix,3);
        Console.WriteLine("Rotated...");
        Rotate(matrix,3);
        
        matrix = new int[5,5] {
        {0,1,2,3,4},
        {5,6,7,8,9},
        {10,11,12,13,14},
        {15,16,17,18,19},
        {20,21,22,23,24}};
        
        Console.WriteLine("Original...");
        PrintMatrix(matrix,5);
        Console.WriteLine("Rotated...");
        Rotate(matrix,5);
        
    }
    
    static void PrintMatrix(int[,] matrix, int n){
        //Print matrix
        for(int x=0;x<n;x++){
            for(int y=0;y<n;y++){
               Console.Write(matrix[x,y]+",");
            }
            Console.WriteLine();
        }
    }
    
    static void Rotate(int[,] matrix,int n){
        int[,] move= new int[matrix.Length/2,matrix.Length/2];
        Array.Copy(matrix,move,matrix.Length);
        
        for(int x=0;x<n;x++){
            for(int y=n-1;y>=0;y--){
                int cv = matrix[x,y];
                move[y,(n-1)-x]=cv;
            }
        }     
        PrintMatrix(move,n);
    }
}