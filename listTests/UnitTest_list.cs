using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace listTests
{
    [TestClass]
    public class UnitTest_list
    {
        [TestMethod]
        public void ReturnListNodeAsListTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5, 8 };
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }

        [TestMethod]
        public void AddElementTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int value = 13;
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5, 8, 13 };
            test_listNode = test_listNode.Add(value);
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }

        [TestMethod]
        public void RemoveElementsByValueTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 5, 2, 3, 5, 8, 5 });
            int value = 5;
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 8 };
            test_listNode = test_listNode.Delete(value);
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }


        [TestMethod]
        public void RemoveElementsByPositionTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8, 5 });
            int pos = 5;
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5, 8 };
            test_listNode = test_listNode.Remove(pos);
            test_listNode.PrintListNode();
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }

        [TestMethod]
        public void InsertElementTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 8 });
            int value = 5; int start_pos = 2;
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5, 8 };
            test_listNode = test_listNode.Insert(value, start_pos);
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }

        [TestMethod]
        public void SearchValbyPosTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int pos = 2; int expected_result = 3;
            int res = test_listNode.SearchValueByPosition(pos);
            Assert.AreEqual(res, expected_result);

        }

        [TestMethod]
        public void ValInListNodeTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int val = 8; bool expected_result = true;
            bool res = test_listNode.IsValueInListNode(val);
            Assert.AreEqual(res, expected_result);
        }

        [TestMethod]
        public void ValNotInListNodeTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int val = 7; bool expected_result = false;
            bool res = test_listNode.IsValueInListNode(val);
            Assert.AreEqual(res, expected_result);
        }


        [TestMethod]
        public void GetMinTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int expected_result = 1;
            int res = test_listNode.GetMin();
            Assert.AreEqual(res, expected_result);
        }


        [TestMethod]
        public void GetMaxTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5, 8 });
            int expected_result = 8;
            int res = test_listNode.GetMax();
            Assert.AreEqual(res, expected_result);
        }


        [TestMethod]
        public void MergeListsTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() { 1, 2, 3, 5 });
            ListNode merge_listNode = new ListNode().ReturnListAsNode(new List<int>() { 8, 13, 21, 34 });
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5, 8, 13, 21, 34 };
            test_listNode = test_listNode.MergeTwoLists(merge_listNode);
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }

        [TestMethod]
        public void SortListTest()
        {
            ListNode test_listNode = new ListNode().ReturnListAsNode(new List<int>() {5, 1, 3, 2});
            List<int> expected_result_list = new List<int>() { 1, 2, 3, 5 };
            test_listNode = test_listNode.SortList();
            CollectionAssert.AreEqual(test_listNode.ReturnListNodeAsList(), expected_result_list);
        }
    }
}
