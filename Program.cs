// The function filtered array to select the strings with length less than 4
string[] SelectionStringLength(string[] inputArray)
{
    int count = 0;
    string[] outputArray = new string[0];
    int lengthStop = 4;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < lengthStop)
        {
            count++;
            Array.Resize(ref outputArray, count);
            outputArray[count - 1] = inputArray[i];
        }
    }
    return outputArray;
}

// The method prints an array
void PrintArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }
    Console.WriteLine();
}

// The user code to check the function
string[] array = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };
PrintArray(
    SelectionStringLength(array));
