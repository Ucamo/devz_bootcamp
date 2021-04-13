/*
Problema #2
Dado un arreglo de números y un valor deseado, regresa los índices de los dos números en el arreglo que sumen ese valor.
Puedes asumir que siempre hay una sola solución. 
No puedes usar el mismo elemento dos veces.
In:      nums=[2, 7, 1, 5], target = 9
Out: [0,1]
In:      nums = [3, -1, 0, 1], target=0
Out:  [1, 3]
*/

public class TwoSum {
    public int[] TwoSum(int[] nums, int target) {
        int[] sum = new int[2];
        
        if(nums.Length==0){
            return sum;
        }
        
        for(int x=0; x<nums.Length;x++){
            for(int y=0;y<nums.Length;y++){
                if(x!=y){
                    if(nums[x]+nums[y]==target){
                        sum[0]=x;
                        sum[1]=y;
                        return sum;
                    }
                }
            }
        }
        return sum;
    }
}