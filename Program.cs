string[] SelectionStringLength(string[] inputArray)
{
    int count = 0;
    string[] outputArray = new string[0];

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
            Array.Resize(ref outputArray, count);
            outputArray[count - 1] = inputArray[i];
        }
    }
    return outputArray;
}
