using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DicionarioEstrutura
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(string key, string value)
        {
            root = InsertRec(root, key, value);
        }
        public List<string> GetInOrder()
        {
            var list = new List<string>();
            GetInOrderRec(root, list);
            return list;
        }

        private void GetInOrderRec(Node root, List<string> list)
        {
            if (root != null)
            {
                GetInOrderRec(root.Left, list);
                list.Add(root.Key + " - " + root.Value);
                GetInOrderRec(root.Right, list);
            }
        }

        public List<string> GetPreOrder()
        {
            var list = new List<string>();
            GetPreOrderRec(root, list);
            return list;
        }

        private void GetPreOrderRec(Node root, List<string> list)
        {
            if (root != null)
            {
                list.Add(root.Key + " - " + root.Value);
                GetPreOrderRec(root.Left, list);
                GetPreOrderRec(root.Right, list);
            }
        }

        public List<string> GetPostOrder()
        {
            var list = new List<string>();
            GetPostOrderRec(root, list);
            return list;
        }

        private void GetPostOrderRec(Node root, List<string> list)
        {
            if (root != null)
            {
                GetPostOrderRec(root.Left, list);
                GetPostOrderRec(root.Right, list);
                list.Add(root.Key + " - " + root.Value);
            }
        }

        private Node InsertRec(Node root, string key, string value)
        {
            if (root == null)
            {
                root = new Node(key, value);
                return root;
            }
            else if (string.Compare(key, root.Key) < 0)
            {
                root.Left = InsertRec(root.Left, key, value);
            }
            else
            {
                root.Right = InsertRec(root.Right, key, value);
            }

            return root;
        }

        public string Search(string key)
        {
            Node res = SearchRec(root, key);
            return res == null ? "Key not found" : res.Value;
        }

        private Node SearchRec(Node root, string key)
        {
            if (root == null || root.Key == key)
                return root;

            if (string.Compare(key, root.Key) < 0)
                return SearchRec(root.Left, key);

            return SearchRec(root.Right, key);
        }

        public void Delete(string key)
        {
            root = DeleteRec(root, key);
        }

        private Node DeleteRec(Node root, string key)
        {
            if (root == null) return root;

            if (string.Compare(key, root.Key) < 0)
                root.Left = DeleteRec(root.Left, key);
            else if (string.Compare(key, root.Key) > 0)
                root.Right = DeleteRec(root.Right, key);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Key = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Key);
            }
            return root;
        }

        private string MinValue(Node root)
        {
            string minv = root.Key;
            while (root.Left != null)
            {
                minv = root.Left.Key;
                root = root.Left;
            }
            return minv;
        }

        public void PrintInOrder()
        {
            PrintInOrderRec(root);
            Console.WriteLine();
        }

        private void PrintInOrderRec(Node root)
        {
            if (root != null)
            {
                PrintInOrderRec(root.Left);
                Console.Write(root.Key + " - " + root.Value + " ");
                PrintInOrderRec(root.Right);
            }
        }

        public void PrintPreOrder()
        {
            PrintPreOrderRec(root);
            Console.WriteLine();
        }

        private void PrintPreOrderRec(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Key + " - " + root.Value + " ");
                PrintPreOrderRec(root.Left);
                PrintPreOrderRec(root.Right);
            }
        }

        public void PrintPostOrder()
        {
            PrintPostOrderRec(root);
            Console.WriteLine();
        }

        private void PrintPostOrderRec(Node root)
        {
            if (root != null)
            {
                PrintPostOrderRec(root.Left);
                PrintPostOrderRec(root.Right);
                Console.Write(root.Key + " - " + root.Value + " ");
            }
        }

    }

}
