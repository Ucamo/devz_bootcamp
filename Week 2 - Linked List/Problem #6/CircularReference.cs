/*
Problema #6
Dado un singly linked list, escribe un programa que detecte si un linked list tiene una referencia circular
*/
public class MyLinkedList{
    public Node head;
    
    public MyLinkedList(int data){
        head = new Node(data);
    }
    
    public class Node{
        public int data;
        public Node next;
        
        public Node(int data){
            this.data=data;
        }
    }
}

class CircularReference {
    static void Main() {
        Tests();
    }
    
    static void Tests(){
        Console.WriteLine("IN: 6 -> 8 -> 0 -> 4 -> 7 -> 2 -> 5 -> 3 -> 10 -> 0");
        //Out:  true. El nodo 10 apunta al nodo 0, lo que crea un loop.
        MyLinkedList list = new MyLinkedList(6);
        list.head.next = new MyLinkedList.Node(8);
        list.head.next.next = new MyLinkedList.Node(0);
        list.head.next.next.next = new MyLinkedList.Node(4);
        list.head.next.next.next.next = new MyLinkedList.Node(7);
        list.head.next.next.next.next.next = new MyLinkedList.Node(2);
        list.head.next.next.next.next.next.next = new MyLinkedList.Node(5);
        list.head.next.next.next.next.next.next.next = new MyLinkedList.Node(3);
        list.head.next.next.next.next.next.next.next.next = new MyLinkedList.Node(10);
        list.head.next.next.next.next.next.next.next.next.next = list.head.next.next;
        Console.WriteLine("OUT: "+IsCircularList(list));
        Console.WriteLine("IN: 6 -> 8 -> 0 -> 4 -> 7 -> 2");
        //Out: false
        list = new MyLinkedList(6);
        list.head.next = new MyLinkedList.Node(8);
        list.head.next.next = new MyLinkedList.Node(0);
        list.head.next.next.next = new MyLinkedList.Node(4);
        list.head.next.next.next.next = new MyLinkedList.Node(7);
        list.head.next.next.next.next.next = new MyLinkedList.Node(2);
        Console.WriteLine("OUT: "+IsCircularList(list));
        
    }    
    
    static bool IsCircularList(MyLinkedList linList){
        MyLinkedList.Node node = linList.head;
        if(node.next==null){
            return false;
        }
        HashSet<int> mySet = new HashSet<int>();
        while(node!=null){
            if(!mySet.Contains(node.data)){
                mySet.Add(node.data);
            }else{                
                return true;
            }
            node=node.next;
        }        
        return false;
    }    
}

