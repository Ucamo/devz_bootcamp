/*
Problema 4
Dado un arreglo de intervalos, escribe un programa que junte los arreglos que se empalman y regrese los intervalos resultantes que no se empalman.
Por ejemplo:
Input: [[1,3],[2,8],[9,10],[10,12]]
Output: [[1,8],[9,12]]
Nota que [9,10] y [10,12] se consideran empalmados
*/

class Overlay {
    static void Main() {
        Test();
    }
    
    static void Test(){
        int[][] input = new int[][]{new int[]{1,3}, new int[]{2,8}, new int[]{9,10}, new int[]{10,12}};
        Console.WriteLine("Input: [[1,3],[2,8],[9,10],[10,12]]");
        Overlay(input);
        input = new int[][]{new int[]{1,5}, new int[]{4,6}, new int[]{8,15}, new int[]{16,17}};
        Console.WriteLine("Input: [[1,5], [4,6], [8,15], [16,17]]");
        Overlay(input);
    }
    
    static void Overlay(int[][]input){
        
        Dictionary<int,int> range = new Dictionary<int,int>();
        Dictionary<int[],int[]> overlay = new Dictionary<int[],int[]>();
        Dictionary<int[],int[]> dontOverlay = new Dictionary<int[],int[]>();
        for(int x=0; x<input.Length-1;x++){
            int min = input[x][0];
            int max = input[x][1];
            range = new Dictionary<int,int>();
            for(int z=min;z<=max;z++){
                if(!range.ContainsKey(z)){
                    range.Add(z,z);
                }
            }
            for(int y=x+1;y<input.Length;y++){                
                int minI = input[y][0];
                int maxI = input[y][1];
                for( int w =minI;w<=maxI;w++){
                    if(range.ContainsKey(w)){
                        if(!overlay.ContainsKey(new int[]{min,maxI})){
                            overlay.Add(new int[]{min,maxI},new int[]{min,maxI});
                        }
                        break;
                    }
                }
                
            }
        }
        Console.WriteLine("Overlay");
        List<int> keys = new List<int>();
        foreach(KeyValuePair<int[],int[]> elem in overlay){
            Console.WriteLine(elem.Value[0]+","+elem.Value[1]);
            keys.Add(elem.Value[0]);
            keys.Add(elem.Value[1]);
        }
        
        foreach(int[] elem in input){
            int min=elem[0];
            int max =elem[1];
            if(!keys.Contains(min) && !keys.Contains(max)){
                dontOverlay.Add(elem,elem);
            }
        }
        if(dontOverlay.Count>0){
            Console.WriteLine("Don't Overlay");
            foreach(KeyValuePair<int[],int[]> elem in dontOverlay){
                Console.WriteLine(elem.Value[0]+","+elem.Value[1]);
            }
        }

    }
}