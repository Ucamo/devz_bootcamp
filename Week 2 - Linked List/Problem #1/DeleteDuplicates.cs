/*
Problema #1
Escribe un programa borre elementos duplicados de un Linked List.
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

class DeleteDuplicates {
    static void Main() {
        TestDeleteDuplicates();
    }
    
    static void TestDeleteDuplicates(){
        Console.WriteLine("IN: 4 -> 5 -> 9 -> 0 -> 5 -> 1 -> 2");
        //Out: 4 →5 →9 →0 →1 →2
        MyLinkedList list = new MyLinkedList(4);
        list.head.next = new MyLinkedList.Node(5);
        list.head.next.next = new MyLinkedList.Node(9);
        list.head.next.next.next = new MyLinkedList.Node(0);
        list.head.next.next.next.next = new MyLinkedList.Node(5);
        list.head.next.next.next.next.next = new MyLinkedList.Node(1);
        list.head.next.next.next.next.next.next = new MyLinkedList.Node(2);
        Delete(list);
        Console.WriteLine("IN: 1 -> 2 -> 3 -> 3 -> 2 -> 1");
        list = new MyLinkedList(1);
        list.head.next = new MyLinkedList.Node(2);
        list.head.next.next = new MyLinkedList.Node(3);
        list.head.next.next.next = new MyLinkedList.Node(3);
        list.head.next.next.next.next = new MyLinkedList.Node(2);
        list.head.next.next.next.next.next = new MyLinkedList.Node(1);
        Delete(list);
    }
    
    static void Delete(MyLinkedList linList){
        HashSet<int> dup = new HashSet<int>();
        MyLinkedList.Node node = linList.head;
        MyLinkedList.Node previous = null;
        MyLinkedList.Node Initial = null;
        while(node!=null){
            if(previous==null){
                Initial=node;
            }
            if(!dup.Contains(node.data)){
                dup.Add(node.data);
                previous=node;
            }else{
                previous.next = node.next;
            }
            node=node.next;        
        }
        linList.head=Initial;
        Console.Write("Out: ");
        PrintList(linList.head);
        Console.WriteLine("");
    }
    
    static void PrintList(MyLinkedList.Node head){
        if(head!=null){
            Console.Write(head.data+" ->  ");
        }
        if(head!=null){
            if(head.next!=null){
                PrintList(head.next);
            }
        }
    }
}

