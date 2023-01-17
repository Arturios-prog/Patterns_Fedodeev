using IteratorPattern;

TreeNode root = new TreeNode(6);
root.Left = new TreeNode(4, new TreeNode(3), new TreeNode(5));
root.Right = new TreeNode(7);

BSTIterator iterator = new BSTIterator(root);
while (iterator.HasNext())
{
    Console.WriteLine($"{iterator.Next()} ");
}
Console.WriteLine();

DFSIterator dfsIterator = new DFSIterator(root);

while (dfsIterator.HasNext())
{
    Console.WriteLine($"{dfsIterator.Next()} ");
}



Console.Read();