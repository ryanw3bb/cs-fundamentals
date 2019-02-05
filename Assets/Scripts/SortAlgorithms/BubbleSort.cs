// Bubble sort algorithm
//
// Puts an unsorted number array into ascending order
//
// Time complexity:
// best: Ω(n) OR Ω(n^2)
// average: Θ(n^2)
// worst: O(n^2)
//
// The simplest sort, loops through the numbers in a list and if they are greater than
// the next number, swap the numbers over. Then compare against the next. etc.
//
// the best value for time complexity Ω(n) is based on there being a break out of the
// loop if the array is already ordered. The complexity is O(n^2) without this.

public static class BubbleSort 
{
    public static void SortArray(int[] arr)
    {
        int n = arr.Length;

        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
