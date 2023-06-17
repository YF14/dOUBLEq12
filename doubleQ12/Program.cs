//Q1

//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    { int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:",++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//       int nodes=Convert.ToInt32( Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:",i+1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    }
//}


//--------------------------------------------------------------------------------------
////Q2
//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentTail = tail;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentTail != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentTail.data);
//            currentTail = currentTail.prev;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q3
//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//             input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.Write("enter input:");
//         input = Convert.ToInt32(Console.ReadLine());
//        newlist.AddFirst(input);

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q4
//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.Write("enter input:");
//        input = Convert.ToInt32(Console.ReadLine());
//        newlist.AddLast(input);

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q5
//using System;
//using System.Net.Http.Headers;

//namespace ConsoleApp8;
//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public static int count = 0;
//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        count++;
//    }
//    public void AddByPosition(int value, int position)
//    {
//        int currentPostion = 0;
//        Node newNode = new Node(value);
//        Node currentHead = head;
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else if (position == 1)
//        {

//            head.prev = newNode;
//            newNode.next = head;
//            head = newNode;

//        }
//        else if (position == count)
//        {

//            tail.next = newNode;
//            newNode.prev = tail;
//            newNode.next = null;
//            tail = newNode;

//        }
//        else
//        {
//            while (currentHead != null)
//            {
//                if (currentPostion + 2 == position)
//                {
//                    newNode.next = currentHead.next;
//                    currentHead.next.prev = newNode;
//                    currentHead.next = newNode;
//                    newNode.prev = currentHead;
//                    break;
//                }
//                currentPostion++;
//                currentHead = currentHead.next;
//            }


//        }
//        count++;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        count++;
//    }
//    public void Display()
//    {
//        int countDisplay = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++countDisplay);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//    start:
//        Console.WriteLine("Input the number of nodes (3 or more ):");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        if (nodes < 3)
//        {
//            Console.WriteLine("enter 3 or more");
//            goto start;
//        }
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    start1:
//        Console.Write(" Input the position ( 1 to {0} ) to insert a new node:", DoubleLinkedList.count);
//        int position = Convert.ToInt32(Console.ReadLine());
//        if (position < 1 || position > DoubleLinkedList.count)
//        {
//            goto start1;
//        }
//        Console.Write(" enter input");
//        input = Convert.ToInt32(Console.ReadLine());

//        newlist.AddByPosition(input, position);

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q6
//using System;

//namespace ConsoleApp8;
//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public static int count = 0;
//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        count++;
//    }
//    public void AddMiddle(int value, double position)
//    {

//        int currentPostion = 0;
//        Node newNode = new Node(value);
//        Node currentHead = head;
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            while (currentHead != null)
//            {
//                if (currentPostion == position - 2)
//                {
//                    newNode.next = currentHead.next;
//                    currentHead.next.prev = newNode;
//                    currentHead.next = newNode;
//                    newNode.prev = currentHead;
//                    break;
//                }
//                currentPostion++;
//                currentHead = currentHead.next;
//            }


//        }
//        count++;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        count++;
//    }
//    public void Display()
//    {
//        int countDisplay = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++countDisplay);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {

//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        start:
//        Console.WriteLine("Input the number of nodes (3 or more ):");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        if (nodes < 3)
//        {
//            Console.WriteLine("enter 3 or more");
//            goto start;
//        }
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.Write(" Input the position ( 2 to {0} ) to insert a new node:", DoubleLinkedList.count - 1);
//        double position = Math.Round(.25 + DoubleLinkedList.count / 2.0);
//        Console.Write(position + "\n");
//        Console.WriteLine(" Input the number ");

//        input = Convert.ToInt32(Console.ReadLine());
//        newlist.AddMiddle(input, position);

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q7
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public static int count = 0;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        count++;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;
//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        count++;
//    }
//    public void delete()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("empty");

//            --count;
//        }
//        else if (count == 1) {
//            head = null;
//        }else
//        {
//            head = head.next;
//            head.prev = null;
//            --count;
//        }

//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.WriteLine(" After deletion the new list are:");
//        newlist.delete();

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q8
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public int count =0;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        ++count;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        ++count;

//    }
//    public void delete()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("empty");

//        }
//        else if (count == 1)
//        {
//         head = null;
//        }else
//        {
//         tail = tail.prev;
//         tail.next = null;
//        }
//        --count;
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.WriteLine(" After deletion the new list are:");
//        newlist.delete();

//        newlist.Display();
//    }
//}
//--------------------------------------------------------------------------------------

//Q9

//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public static int count = 0;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        ++count;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        ++count;

//    }
//    public void delete(int position)
//    {
//        int currentPostion = 2;
//        Node currentHead = head;
//        if (head == null)
//        {
//            Console.WriteLine("empty");

//        }
//        else if (position==1 &&count>1)
//        {head = head.next;
//        }

//        else if (position == 1 && count == 1)
//        {
//            head = null;
//        }
//        else if (count == position)
//        {
//            tail = tail.prev;
//            tail.next = null;

//        }
//        else
//        {
//            while (currentHead != null)
//            {
//                if (currentPostion  == position)
//                {
//                    currentHead.next = currentHead.next.next;
//                    currentHead.next.next.prev = currentHead;
//                }
//                currentPostion++;
//                currentHead = currentHead.next;
//            }
//        }
//        --count;
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//             input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    start1:
//        Console.Write(" Input the position ( 1 to {0} ) to insert a new node:", DoubleLinkedList.count);
//        int position = Convert.ToInt32(Console.ReadLine());
//        if (position < 1 || position > DoubleLinkedList.count)
//        {
//            goto start1;
//        }

//        Console.WriteLine(" After deletion the new list are:");
//        newlist.delete(position);

//        newlist.Display();
//    }
//}




//Q10
//using System;

//namespace ConsoleApp8;
//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public static int count = 0;
//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        count++;
//    }
//    public void AddMiddle(int value, double position)
//    {

//        int currentPostion = 0;
//        Node newNode = new Node(value);
//        Node currentHead = head;
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            while (currentHead != null)
//            {
//                if (currentPostion == position - 2)
//                {
//                    newNode.next = currentHead.next;
//                    currentHead.next.prev = newNode;
//                    currentHead.next = newNode;
//                    newNode.prev = currentHead;
//                    break;
//                }
//                currentPostion++;
//                currentHead = currentHead.next;
//            }


//        }
//        count++;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        count++;
//    }
//    public void Display()
//    {
//        int countDisplay = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++countDisplay);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {

//        int input;
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        start:
//        Console.WriteLine("Input the number of nodes (3 or more ):");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        if (nodes < 3)
//        {
//            Console.WriteLine("enter 3 or more");
//            goto start;
//        }
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.Write(" Input the position ( 2 to {0} ) to insert a new node:", DoubleLinkedList.count - 1);
//        double position = Math.Round(.25 + DoubleLinkedList.count / 2.0);
//        Console.Write(position + "\n");
//        Console.WriteLine(" Input the number ");

//        input = Convert.ToInt32(Console.ReadLine());
//        newlist.AddMiddle(input, position);

//        newlist.Display();
//    }
//}
////Q11
//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);
//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    {
//        int count = 0;
//        int? bigger= head.data;

//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            if (currentHead.data > bigger)
//            {
//                bigger = currentHead.data;
//            }
//            currentHead = currentHead.next;
//        }
//        Console.WriteLine("The biggest number is {0} :", bigger);

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {

//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    }
//}
//Q12

//using System;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);
//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.Write("The doubly linked list in string format: ");

//        while (currentHead != null)
//        {
//            Console.Write((currentHead.data).ToString() + " ");
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();
//    }
//}