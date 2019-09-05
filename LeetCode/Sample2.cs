using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Sample2
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int curStartIndex = 0;
            int curLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int charIndex = s.IndexOf(s[i], curStartIndex, curLength);
                if (charIndex != -1)
                {
                    curLength = curLength - (charIndex - curStartIndex);
                    curStartIndex = charIndex + 1;
                }
                else
                {
                    curLength++;
                }
                if (curLength > maxLength)
                {
                    maxLength = curLength;
                    //Console.WriteLine(s.Substring(curStartIndex,curLength));
                }
            }
            return maxLength;
        }
    }
}
