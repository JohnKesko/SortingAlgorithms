#### A super tiny static class library for the most common sorting algorithms.

- Bubblesort
- Selectionsort
- Insertionsort

More algos to come... 


How to use:

Clone the repo and add it as a reference to your project.

```
using SortingAlgorithms;

var random = new Random();
var numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 100);
}

Console.Write($"Unsorted numbers: ");
foreach (var number in numbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();

Console.Write($"Sorted numbers: ");
Sort.BubbleSort(numbers);
foreach (var number in numbers)
{
    Console.Write(number + " ");
}
```

Output:
```
Unsorted numbers: 9 21 25 7 63 68 52 41 13 30 
Sorted numbers: 7 9 13 21 25 30 41 52 63 68 
```
