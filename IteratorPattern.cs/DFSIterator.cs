using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorPattern.TreeNode;

namespace IteratorPattern
{
    public class DFSIterator
    {
        private Queue<TreeNode> _queue = new Queue<TreeNode>(); // создать новую очередь

        public DFSIterator(TreeNode root)
        {
            _queue.Enqueue(root);
        }

        public int Next()
        {
            TreeNode res;
            res = _queue.Dequeue();

            if (res.Left != null)
                _queue.Enqueue(res.Left);

            if (res.Right != null)
                _queue.Enqueue(res.Right);

            return res.Value;
        }

        public bool HasNext()
        {
            return _queue.Count > 0;
        }
    }
}
