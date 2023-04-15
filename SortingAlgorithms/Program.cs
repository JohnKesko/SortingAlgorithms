namespace SortingAlgorithms;

public static class Sort
{
    public static void BubbleSort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            for (var j = 0; j < numbers.Length - 1; j++)
            {
                // ReSharper disable once InvertIf
                if (numbers[j] > numbers[j + 1])
                {
                    // ReSharper disable once SwapViaDeconstruction
                    var tempNumber = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tempNumber;
                }
            }
        }
    }

    public static void SelectionSort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            var min = i;
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }

            // ReSharper disable once SwapViaDeconstruction
            var tempNumber = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = tempNumber;
        }
    }

    public static void InsertionSort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            var min = i;
            for (var j = i + 1; j > 0; j--)
            {
                // ReSharper disable once InvertIf
                if (numbers[j - 1] > numbers[j])
                {
                    // ReSharper disable once SwapViaDeconstruction
                    var tempNumber = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = tempNumber;
                }
            }
        }
    }
}