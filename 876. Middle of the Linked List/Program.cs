namespace _876._Middle_of_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var node10 = new ListNode(18);
            var node9 = new ListNode(13,node10);
            var node8 = new ListNode(21,node9);
            var node7 = new ListNode(11,node8);
            var node6 = new ListNode(86,node7);
            var node5 = new ListNode(96,node6);
            var node4 = new ListNode(77,node5);
            var node3 = new ListNode(26,node4);
            var node2 = new ListNode(66,node3);
            var node1 = new ListNode(65,node2);
            Solution solution = new Solution();
            Console.WriteLine(solution.MiddleNode(node1).val);
        }
    }
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            int countNodes = 1;
            var currentNode = head;
            while (currentNode != null)
            {
                currentNode = currentNode.next;
                countNodes++;
            }

            
            var index = (int)Math.Ceiling(((double)countNodes ) / 2);

            countNodes = 1;
            currentNode = head;
            while (countNodes<index)
            {
                currentNode = currentNode.next;
                countNodes++;
            }
            return currentNode;
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

}