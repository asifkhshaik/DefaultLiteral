

// See https://aka.ms/new-console-template for more information
void Display<T>(T[] values) => Console.WriteLine($"[ {string.Join(", ", values)} ]");

Display(InitializeArray<int>(3));  // output: [ 0, 0, 0 ]
Display(InitializeArray<bool>(4, default));  // output: [ False, False, False, False ]

System.Numerics.Complex fillValue = default;
Display(InitializeArray(3, fillValue));  // output: [ (0, 0), (0, 0), (0, 0) ]

T[] InitializeArray<T>(int length, T initialValue = default) 
{
    if(length < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(length));
    }

    var array = new T[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = initialValue;
    }
    return array;
}
