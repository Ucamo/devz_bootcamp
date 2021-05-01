/*
Semana 3 Problema #1
Implementa un stack de enteros con sus operaciones push, pop, peek y una funcion
getMin que obtendra el valor mas pequeño de la pila. Todas las operaciones
(incluyendo getMin) deben ser constantes (O(1)).
*/
public class Node{
    public int data;
    public Node prev;
        
    public Node(int data){
        this.data=data;
    }
}

public class Stack{
    public Node node;
    public int min;
    public void push(Node _pNode){
        Console.WriteLine("Push "+_pNode.data);
        if(node==null){
            node = _pNode;
            min=_pNode.data;
        }else{
            if(min>_pNode.data){
                min=_pNode.data;
            }
            _pNode.prev=node;
            node=_pNode;
        }
    }
    public void pop(){
        Console.WriteLine("pop");
        node = node.prev;
        if(node!=null){
            if(min>node.data){
                min=node.data;
            }
        }else{
            Console.WriteLine("Empty stack... min set to 0");
            min=0;
        }
    }
    public int peek(){
        Console.Write("Peek... ");
        if(node!=null){
            return node.data;
        }
        Console.Write("Empty stack ");
        return -9999;
    }
    public int getMin(){
        Console.Write("getMin ");
        return min;
    }
}

class HelloWorld {
    static void Main() {
        TestStack();
    }
    
    static void TestStack(){
        Stack stack = new Stack();
        stack.push(new Node(1));
        stack.push(new Node(2));
        stack.push(new Node(3));
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.getMin());
        stack.pop();
        stack.pop();
        stack.pop();
        
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.getMin());
        stack.push(new Node(-3));
        stack.push(new Node(99));
        stack.push(new Node(30));
        stack.push(new Node(1));
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.getMin());
        stack.push(new Node(-100));
        Console.WriteLine(stack.peek());
        Console.WriteLine(stack.getMin());
    }
}