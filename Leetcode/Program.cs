using Leetcode;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new _2_Add_Two_Numbers();

            c.AddTwoNumbers(new _2_Add_Two_Numbers.ListNode(2, new _2_Add_Two_Numbers.ListNode(4, new _2_Add_Two_Numbers.ListNode(9))),
                new _2_Add_Two_Numbers.ListNode(5, new _2_Add_Two_Numbers.ListNode(6, new _2_Add_Two_Numbers.ListNode(4, new _2_Add_Two_Numbers.ListNode(9)))));
        }
    }
}