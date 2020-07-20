using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.TreeAndGraph
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    public class ZigZagLevelOrder
    {
        public TreeNode root;
        //public List<List<int>> ZigZagOrder(TreeNode root)
        //{
        //    var list = new List<int>();
        //    var result = new List<List<int>>();
        //    if (root == null)
        //        return result;
        //    Stack<TreeNode> leftToRight = new Stack<TreeNode>();
        //    Stack<TreeNode> rightToLeft = new Stack<TreeNode>();
        //    leftToRight.Push(root);
        //    while (leftToRight.Count() != 0 || rightToLeft.Count() != 0)
        //    {
        //        while (leftToRight.Count != 0)
        //        {
        //            TreeNode n = leftToRight.Pop();
        //            list.Add(n.value);
        //            if (n.left != null)
        //                rightToLeft.Push(n.left);
        //            if (n.right != null)
        //                rightToLeft.Push(n.right);
        //        }
        //        if (list.Count != 0)
        //            result.Add(new List<int>(list));
        //        list.Clear();
        //        while (rightToLeft.Count != 0)
        //        {
        //            TreeNode n = rightToLeft.Pop();
        //            list.Add(n.value);
        //            if (n.right != null)
        //                leftToRight.Push(n.right);
        //            if (n.left != null)
        //                leftToRight.Push(n.left);
        //        }
        //        if (list.Count != 0)
        //            result.Add(new List<int>(list));
        //        list.Clear();
        //    }
        //    return result;
        //}

        //public List<List<int>> ZigZagOrder(TreeNode root)
        //{
        //    var list = new List<int>();
        //    var result = new List<List<int>>();
        //    if (root == null)
        //        return result;
        //    Stack<TreeNode> currentLevel = new Stack<TreeNode>();
        //    Stack<TreeNode> nextLevel = new Stack<TreeNode>();
        //    currentLevel.Push(root);
        //    bool leftToRight = true;
        //    while (currentLevel.Count() > 0)
        //    {
        //        TreeNode n = currentLevel.Pop();
        //        list.Add(n.val);
        //        if (n != null)
        //        {
        //            if (leftToRight)
        //            {
        //                if (n.left != null)
        //                    nextLevel.Push(n.left);
        //                if (n.right != null)
        //                    nextLevel.Push(n.right);
        //            }
        //            else
        //            {
        //                if (n.right != null)
        //                    nextLevel.Push(n.right);
        //                if (n.left != null)
        //                    nextLevel.Push(n.left);
        //            }
        //            if (currentLevel.Count == 0)
        //            {
        //                leftToRight = !leftToRight;
        //                Stack<TreeNode> temp = currentLevel;
        //                currentLevel = nextLevel;
        //                nextLevel = temp;
        //                if (list.Count != 0)
        //                    result.Add(new List<int>(list));
        //                list.Clear();
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public List<List<int>> ZigZagOrder(TreeNode root)
        //{
        //    var result = new List<List<int>>();
        //    if (root == null)
        //        return result;
        //    Queue<TreeNode> queue = new Queue<TreeNode>();
        //    queue.Enqueue(root);
        //    bool leftToRight = true;
        //    while (queue.Count > 0)
        //    {
        //        int queueSize = queue.Count;
        //        var list = new List<int>();
        //        while (queueSize > 0)
        //        {
        //            TreeNode n = queue.Dequeue();
        //            if (leftToRight)
        //                list.Add(n.val);
        //            else
        //                list.Insert(0, n.val);
        //            if (n.left != null)
        //                queue.Enqueue(n.left);
        //            if (n.right != null)
        //                queue.Enqueue(n.right);
        //            queueSize--;
        //        }
        //        leftToRight = !leftToRight;
        //        result.Add(list);
        //    }
        //    return result;
        //}
        public List<List<int>> ZigZagOrder(TreeNode root)
        {
            var result = new List<List<int>>();
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool leftToRight = true;
            while (queue.Count > 0)
            {
                int queueSize = queue.Count;
                var list = new List<int>();
                for (int i = 0; i < queueSize; i++)
                {
                    TreeNode n = queue.Dequeue();
                    if (leftToRight)
                        list.Add(n.val);
                    else
                        list.Insert(0, n.val);
                    if (n.left != null)
                        queue.Enqueue(n.left);
                    if (n.right != null)
                        queue.Enqueue(n.right);
                    queueSize--;
                }
                leftToRight = !leftToRight;
                result.Add(list);
            }
            return result;
        }
    }
}
