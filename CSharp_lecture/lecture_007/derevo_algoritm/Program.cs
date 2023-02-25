string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)        //вышло за пределы или нет
    {
        int left = 2 * pos;      //позиция левого поддерева
        int right = 2 * pos + 1;   //позиция правого поддерева
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // ели левое имеется и оно не пусто
        Console.WriteLine(tree[pos]);   //вывести значение
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);   //если правое имееся и не путое
    }
}

InOrderTraversal();