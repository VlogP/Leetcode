using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _2_Add_Two_Numbers
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l1Node = l1;
            var l2Node = l2;
            ListNode newList = null;
            ListNode pointerToBeginning = null;
            var stack = new Stack<int>();
            var stack2 = new Stack<int>();

            while (l2Node != null)
            {
                stack.Push(l2Node.val);
                l2Node = l2Node.next;
            }

            while (l1Node != null)
            {
                stack2.Push(l1Node.val);
                l1Node = l1Node.next;
            }

            var stackCount = stack.Count;
            var value1 = 0;

            for(var index = 0; index < stackCount; index++)
            {
                value1 += (int)Math.Pow(10, stackCount - index - 1) * stack.Pop();
            }

            var stack2Count = stack2.Count;
            var value2 = 0;

            for (var index = 0; index < stack2Count; index++)
            {
                value2 += (int)Math.Pow(10, stack2Count - index - 1) * stack2.Pop();
            }

            var resultValue = (value2 + value1).ToString().Reverse();

            var mainIndex = 0;

            while (mainIndex < resultValue.Count())
            {
                if (mainIndex == 0)
                {
                    newList = new ListNode(int.Parse(resultValue.ElementAt(mainIndex).ToString()));
                    pointerToBeginning = newList;
                }
                else
                {                   
                    newList.next = new ListNode(int.Parse(resultValue.ElementAt(mainIndex).ToString()));
                    newList = newList.next;
                }

                mainIndex++;
            }

            return pointerToBeginning;
        }
    }
}
