string[] str_le_3(string[] arr)
{
    var array = Array.Empty<string>();
    for (int i = 0, size = 0; i < arr.Length; i++)
        if (arr[i].Length > 3) continue;
        else
        {
            size += 1;
            Array.Resize(ref array, size );
            array[size-1]=arr[i];
        }
    return array;
}


string[] arrayOfString1 = { "hello", "2", "world", ":-)"};
string[] arrayOfString2 = { "1234", "1567", "-2", "computer science" };
string[] arrayOfString3 = { "Russia", "Denmark", "Kazan"};

var result1 = str_le_3(arrayOfString1);
var result2 = str_le_3(arrayOfString2);
var result3 = str_le_3(arrayOfString3);

Console.Write("[{0}] -> ", string.Join(", ", arrayOfString1));
Console.WriteLine("[{0}]", string.Join(", ", result1));

Console.Write("[{0}] -> ", string.Join(", ", arrayOfString2));
Console.WriteLine("[{0}]", string.Join(", ", result2));

Console.Write("[{0}] -> ", string.Join(", ", arrayOfString3));
Console.WriteLine("[{0}]", string.Join(", ", result3));
