using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BSTIterator
    {
        private Stack<TreeNode> _queue;
        TreeNode _currentNode;

        public BSTIterator(TreeNode root)
        {
            _currentNode = root;
            _queue = new Stack<TreeNode>();
            while (_currentNode != null)
            {
                _queue.Push(_currentNode);
                _currentNode = _currentNode.Left;    
            }
        }

        public int Next()
        {
            TreeNode? res = null;

            while (res == null && (_currentNode != null || (_queue.Count > 0)))
            {
                if (_currentNode != null)
                {
                    _queue.Push(_currentNode);
                    _currentNode = _currentNode.Left;
                }
                else
                {
                    _currentNode = _queue.Pop();
                    res = _currentNode;
                    _currentNode = _currentNode.Right;
                }
            }

            return res.Value;

        }

        public bool HasNext()
        {
            return _currentNode != null || (_queue.Count > 0);
        }
    }
}
