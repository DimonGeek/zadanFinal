string[] array1 = new string[5] {"156", "-2", "Denmark", "Russia", "res"};
string[] array2 = new string[array1.Length];
int count = 0;
for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();