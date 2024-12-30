// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Runtime.InteropServices;

class Program
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(3);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(0);
        l1.next.next.next = new ListNode(-4);
        l1.next.next.next.next = l1.next;

        //Console.WriteLine("method1: " + HasCycle(l1));
        Console.WriteLine("method2: " + HasCycle2(l1));
        //Console.ReadKey();
    }


    public static bool HasCycle2(ListNode head)
    {
        if(head == null || head.next == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.next;

        while(slow != null || fast.next != null)
        {
            if(slow == fast)
            {
                return true;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
}