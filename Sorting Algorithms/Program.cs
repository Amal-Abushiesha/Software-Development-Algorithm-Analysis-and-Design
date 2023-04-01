using SortingAlgorithms;

void display(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    ps("\n");
}
void ps(string str)
{
    Console.WriteLine(str);
}
void reset(int [] arr)
{

    int [] temp = { 3, 4, 6, 2 };
    for(int i = 0; i < temp.Length; i++)
    {
        arr[i] = temp[i];
    }
}
int [] arr = { 3, 4, 6, 2 };

ps("Original Array:");
display(arr);

ps("Using Selection sort:");
SelectionSort.selectionSort(arr);
display(arr);

ps("Original Array:");
reset(arr);
display(arr);

ps("Using Bubble sort:");
BubbleSort.bubbleSort(arr);
display(arr);

ps("Original Array:");
reset(arr);
display(arr);

ps("Using Merge sort:");
MergeSort.mergeSort(arr, 0, arr.Length - 1);
display(arr);
ps("FINALLY DONE WTH!!!");