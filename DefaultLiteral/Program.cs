
void Display<T>(T[] values) => Console.WriteLine($"[{string.Join(",", values)}]");

Display(InitializeArray<int>(3));
Display(InitializeArray<bool>(3, false));
System.Numerics.Complex fillValue = default;
Display(InitializeArray(3, fillValue));


T[] InitializeArray<T>(int length, T initialValue = default)
{
    if(length < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(length));
    }
    var array = new T[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = initialValue;
    }
   

    return array;

}
