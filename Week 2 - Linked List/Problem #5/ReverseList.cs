/*
Problema #5
Dado un singly linked list, escribe un programa que invierta la dirección de dicha linked list (reverse).
Puedes hacerlo sin usar ninguna estructura de datos como apoyo?
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

class ReverseList {
    static void Main() {
        Tests();
    }
    
    static void Tests(){
        Console.WriteLine("IN: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9 -> 10");
        //Out:  10 → 9 → 8 → 7 → 6 → 5 → 4 → 3 → 2 → 1
        MyLinkedList list = new MyLinkedList(1);
        list.head.next = new MyLinkedList.Node(2);
        list.head.next.next = new MyLinkedList.Node(3);
        list.head.next.next.next = new MyLinkedList.Node(4);
        list.head.next.next.next.next = new MyLinkedList.Node(5);
        list.head.next.next.next.next.next = new MyLinkedList.Node(6);
        list.head.next.next.next.next.next.next = new MyLinkedList.Node(7);
        list.head.next.next.next.next.next.next.next = new MyLinkedList.Node(8);
        list.head.next.next.next.next.next.next.next.next = new MyLinkedList.Node(9);
        list.head.next.next.next.next.next.next.next.next.next = new MyLinkedList.Node(10);
        Console.WriteLine("OUT: ");
        PrintList(Reverse(list));
        //Test again with reversed list
        Console.WriteLine("IN: ");
        PrintList(list);
        Console.WriteLine("OUT: ");
        PrintList(Reverse(list));
        
    }
    
    static void PrintList(MyLinkedList linList){
        MyLinkedList.Node node = linList.head;
        while(node!=null){
            Console.Write(node.data+" -> ");
            node = node.next;
        }
        Console.WriteLine("");
    }
    
    static MyLinkedList Reverse(MyLinkedList linList){
        MyLinkedList.Node node = linList.head;
        if(node.next==null){
            return linList;
        }
        MyLinkedList.Node prev = null;
        MyLinkedList.Node next = node.next;
        while(node!=null){  
           //Save next value
           next = node.next;
           //Next value is now previous node
           node.next=prev;
           //Previous node is now current node
           prev=node;
           //current node is the next node to keep iterating
            if(next!=null){
                node=next;
            }else{
                break; //you finish up the list
            }           
        }        
        linList.head=node;        
        return linList;        
    }    
}

