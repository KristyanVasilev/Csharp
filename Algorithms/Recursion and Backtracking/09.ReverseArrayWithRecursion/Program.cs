
var array = Console.ReadLine().Split();

ReverseArray(array, 0);
Console.WriteLine(string.Join(" ", array));

void ReverseArray(string[] array, int index)
{
    var reversedArr = new string[array.Length];

    if (index == array.Length / 2)
    {
        return;
    }

    var temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
}