// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace ConsoleApp1
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);

            var res = MiddleNode(listNode);
            Console.Write("method1: ");
            while (res != null)
            {
                Console.Write(res.val + ", ");
                res = res.next;
            }

            Console.WriteLine("");
            Console.Write("method2: ");
            ListNode listNode2 = new ListNode(1);
            listNode2.next = new ListNode(2);
            listNode2.next.next = new ListNode(3);
            listNode2.next.next.next = new ListNode(4);

            var res2 = MiddleNode2(listNode2);
            while (res2 != null)
            {
                Console.Write(res2.val + ", ");
                res2 = res2.next;
            }
            Console.WriteLine("");
        }


        public static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        public static ListNode MiddleNode2(ListNode head)
        {
            int n = 0;
            ListNode cur = head;
            while(cur != null)
            {
                n++;
                cur = cur.next;
            }

            int k = 0;
            cur = head;
            while(k < n / 2)
            {
                k++;
                cur = cur.next;
            }

            return cur;
        }
    }
}

