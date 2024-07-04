namespace LeetcodeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public ListNode MergeNodes(ListNode head)
        {
            ListNode nextSum = head.next;
            ListNode modify = nextSum;

            while (nextSum != null)
            {
                int sum = 0;
                while (nextSum.val != 0)
                {
                    sum += nextSum.val;
                    nextSum = nextSum.next;
                }
                modify.val = sum;
                nextSum = nextSum.next;
                modify.next = nextSum;
                modify = modify.next;
            }
            return head.next;

        }

    }
    
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
}