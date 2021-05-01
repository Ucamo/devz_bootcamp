/*
Semana 3 Problema #3
Crea una función que regrese el mínimo número de paréntesis que hay que agregar
para que los paréntesis sean válidos.
In: “())”
Out: 1
Porque agregando uno al inicio se satisface la condición: “(())”
In: “()))((”
Out: 4
Porque agregando 2 al inicio y 2 al final se satisface la condición: “((()))(())”
*/

public class Solution {
    public int MinAddToMakeValid(string S) {
        Stack<char> left = new Stack<char>();
        Stack<char> right = new Stack<char>();
        foreach(char ch in S){
            if(ch=='('){
                left.Push(ch);
            }else{
                right.Push(ch);
            }

            if(left.Count>0){
                if(ch==')' && left.Peek()=='('){
                    left.Pop();
                    right.Pop();
                }
            }
        }
        int totalLeft=left.Count;
        int totalRight = right.Count;
        return totalLeft+totalRight;
    }
}