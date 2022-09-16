namespace _19._Remove_Nth_Node_From_End_of_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node5 = new ListNode(5);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2);
            var node1 = new ListNode(1,node2);
            Solution solution = new Solution();
           var result= solution.RemoveNthFromEnd(node1, 2);

            var currentNode = result;
            
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.val);
                currentNode = currentNode.next;
            }
            
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
        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var indexBeforeDelElement = Count(head) - n;

            if(indexBeforeDelElement==0)
            {
                return head.next;
            }

            ListNode currentNode = head;

            int count = 1;

            while (count<indexBeforeDelElement)
            {
                currentNode = currentNode.next;
                count++;

            }

            if (currentNode.next == null)
            {
                return null;
            }
            ListNode delNode = currentNode.next;
            currentNode.next = delNode.next;

            return head;
        }

        public int Count(ListNode head)
        {
            int count = 1;
            var current = head;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
    }
}