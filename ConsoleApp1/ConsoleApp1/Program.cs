/* напишите программу ,которая из имеющегося массива строк формирует массив строк,
 * длинна которых меньше или равна 3 символа. Первоночальный массив можно ввести с клавиатуры , либо задать на старте 
 * выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 **/


string[] FindLessThanThree(string[] input, int n)
{
    string[] output = new string[CountLessThanThree(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThanThree(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] infoinput()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] array = infoinput();
string[] result = FindLessThanThree(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

