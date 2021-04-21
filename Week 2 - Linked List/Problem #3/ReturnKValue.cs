/*
Problema #3
Implementa un algoritmo que encuentre nodo k lugares antes del último nodo.
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

class ReturnKValue {
    static void Main() {
        Tests();
    }
    
    static void Tests(){
        Console.WriteLine("IN: 2 -> 3 -> 1 -> 4 -> 9 -> 10 -> 11. k = 2");
        //Out: 9
        MyLinkedList list = new MyLinkedList(2);
        int k=2;
        list.head.next = new MyLinkedList.Node(3);
        list.head.next.next = new MyLinkedList.Node(1);
        list.head.next.next.next = new MyLinkedList.Node(4);
        list.head.next.next.next.next = new MyLinkedList.Node(9);
        list.head.next.next.next.next.next = new MyLinkedList.Node(10);
        list.head.next.next.next.next.next.next = new MyLinkedList.Node(11);
        Console.WriteLine(GetValue(list,k));
        
        Console.WriteLine("IN: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> 10. k = 9");
        //Out: 1
        list = new MyLinkedList(1);
        k=9;
        list.head.next = new MyLinkedList.Node(2);
        list.head.next.next = new MyLinkedList.Node(3);
        list.head.next.next.next = new MyLinkedList.Node(4);
        list.head.next.next.next.next = new MyLinkedList.Node(5);
        list.head.next.next.next.next.next = new MyLinkedList.Node(6);
        list.head.next.next.next.next.next.next = new MyLinkedList.Node(7);
        list.head.next.next.next.next.next.next.next = new MyLinkedList.Node(8);
        list.head.next.next.next.next.next.next.next.next = new MyLinkedList.Node(9);
        list.head.next.next.next.next.next.next.next.next.next = new MyLinkedList.Node(10);
        Console.WriteLine(GetValue(list,k));
        
    }
    
    static int GetValue(MyLinkedList linList,int k){
        Dictionary<int,int> map = new Dictionary<int,int>();
        MyLinkedList.Node node = linList.head;
        int counter=0;
        if(node.next==null){
            return node.data;
        }
        while(node!=null){            
            map[counter]=node.data;           
            node=node.next; 
            if(node!=null){
                counter++; 
            }
        }
        int index = counter-k;
        return map[index];
        
    }
    
}

