// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// [20, -7, -2, 1, 8, 12, -20]: 1
// [-1, -8, -100, 100]: -1
// [1, -2, 7, -15, 4]: 1
// [-8, -100, -7, -1, -2]: -1
// [2, -2]: -2
// [1, 1]: 1
// null: 0
// []: 0
// [99, 102, 2, 0, 1, 3, 6]: 0
// [99, 102, 200, 1000, 300, 600, -99]: -99


int CloseNumberToZero(int[] ints)
{

    if (ints is null || ints.Length == 0)
        return 0;

    var closeToZero = ints[0];
    for (int i = 1; i < ints.Length; i++)
    {
        var n1 = ints[i];
        var n2 = closeToZero;//ints[i + 1];
        if (Math.Min(n1, n2) < 0) {
            if (Math.Abs(n1) == Math.Abs(n2))
            {
                closeToZero = Math.Abs(n2) * -1;
                continue;
            }
        }        
        closeToZero = (0 - Math.Abs(n1)) > (0 - Math.Abs(n2)) ? n1 : n2;
    }

    return closeToZero;
}


Console.WriteLine(CloseNumberToZero([20, -7, -2, 1, 8, 12, -20]));
Console.WriteLine(CloseNumberToZero([-1, -8, -100, 100]));
Console.WriteLine(CloseNumberToZero([1, -2, 7, -15, 4]));
Console.WriteLine(CloseNumberToZero([-8, -100, -7, -1, -2]));
Console.WriteLine(CloseNumberToZero([2, -2]));
Console.WriteLine(CloseNumberToZero([1, 1]));
Console.WriteLine(CloseNumberToZero(null));
Console.WriteLine(CloseNumberToZero([]));
Console.WriteLine(CloseNumberToZero([99, 102, 2, 0, 1, 3, 6]));
Console.WriteLine(CloseNumberToZero([99, 102, 200, 1000, 300, 600, -99]));