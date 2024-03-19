using System;
using System.Collections.Generic;

public class ListNode
{
     public int val;
     public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
     {
        this.val = val;
        this.next = next;
     }


    ~ListNode()
    {
    }

    public ListNode Add(int value)
    {
        ListNode dummyHead = this;
        while (dummyHead.next != null)
        {
            dummyHead = dummyHead.next;
        }
        dummyHead.next = new ListNode(value);
        return this;
    }

    public ListNode Delete(int value) // delete all ListNode with val = value
    {
        ListNode dummyHead = new ListNode(-1);
        dummyHead.next = this;
        ListNode current = dummyHead;
        while (current.next != null && current != null)
        {
            if (current.next.val == value)
                current.next = current.next.next;
            else
                current = current.next;

        }
        return dummyHead.next;
    }


    public ListNode Remove(int pos) // remove ListNode by key, pos считается с 0
    {
        ListNode dummyHead = new ListNode(-1);
        dummyHead.next = this;
        ListNode current = dummyHead;
        for (int i = 0; i < pos; i++)
        {
            current = current.next;
        }
        current.next = current.next.next;
        return dummyHead.next;
    }

    public ListNode Insert(int value, int start_pos) //start_pos считается с 0
    {
        ListNode dummyHead = new ListNode(-1);
        dummyHead.next = this;
        ListNode current = dummyHead;
        for (int i = -1; i < start_pos; i++)
        {
            current = current.next;
        }
        ListNode newNode = new ListNode(value);
        newNode.next = current.next;
        current.next = newNode;
        return dummyHead.next;
    }

    public int SearchValueByPosition(int pos) //pos считается с 0 
    {
        ListNode dummyHead = new ListNode(-1);
        int i = -1;
        dummyHead.next = this;
        ListNode current = dummyHead;
        while (i != pos)
        {
            i++;
            current = current.next;
        }
        return current.val;
    }

    public bool IsValueInListNode(int val)
    {
        ListNode dummyHead = this;
        while (dummyHead != null)
        {
            if (dummyHead.val == val)
                return true;
            dummyHead = dummyHead.next;        
        }
        return false;
    }

    public ListNode MergeTwoLists(ListNode list2)
    {
        ListNode dummyHead = new ListNode(-1);
        ListNode list1 = this;
        ListNode current = dummyHead;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if (list1 != null)
        {
            current.next = list1;
        }
        else
        {
            current.next = list2;
        }

        return dummyHead.next;

    }


    public void PrintListNode()
    {
        ListNode dummyHead = this;
        while (dummyHead != null)
        {
            Console.Write(String.Format("{0} ", dummyHead.val));
            dummyHead = dummyHead.next;
        }
    }

    public int GetMax()
    {
        int max = Int32.MinValue;
        ListNode dummyHead = this;
        while (dummyHead != null)
        {
            if (dummyHead.val > max)
                max = dummyHead.val;
            dummyHead = dummyHead.next;
        }
        return max;
    }


    public int GetMin()
    {
        int min = Int32.MaxValue;
        ListNode dummyHead = this;
        while (dummyHead != null)
        {
            if (dummyHead.val < min)
                min = dummyHead.val;
            dummyHead = dummyHead.next;
        }
        return min;
    }


    public ListNode SortList()
    {
        ListNode dummyHead = new ListNode();
        ListNode head = this;
        ListNode dummydummyHead = dummyHead;
        List<int> list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            dummydummyHead.next = new ListNode(list[i]);
            dummydummyHead = dummydummyHead.next;
        }
        return dummyHead.next;
    }


    public List<int> ReturnListNodeAsList()
    {
        ListNode dummy = this;
        List<int> result_list = new List<int>();
        while (dummy != null)
        {
            result_list.Add(dummy.val);
            dummy = dummy.next;
        }
        return result_list;
    }


    public ListNode ReturnListAsNode(List<int> input_list)
    {
        ListNode list = new ListNode();
        ListNode previous_node = null;
        for (int i = input_list.Count - 1; i>= 0; i--)
        {
            list = new ListNode(input_list[i]);
            list.next = previous_node;
            previous_node = list;
        }
        return list;
    }
}



namespace list
{

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
