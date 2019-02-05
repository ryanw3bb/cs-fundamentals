// Quick sort algorithm 
//
// Internal algorithm to put an unsorted number array into ascending order
// 
// Time complexity:
// best: Ω(n log(n))
// average: Θ(n log(n))
// worst: O(n^2)
//
// Uses a pivot (normally the first entry) and checks values of the first (left)
// and last (right) array entries, moving inwards until arr[left] > pivot and arr[right] < pivot.
//
// at this point it tries to swap the current numbers over, to see if that enables the sorting to continue.
//
// if it doesn't, the array is split into 2 at the position of right, and the sort function is called again 
// (recursively) with the 2 array sections.

public static class QuickSort 
{
    public static void SortArray(int[] arr)
    {
        SortArray(arr, 0, arr.Length - 1);
    }

    private static void SortArray(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int partitionIndex = Partition(arr, left, right);

            // sort left side
            if(partitionIndex > 1)
            {
                SortArray(arr, left, partitionIndex - 1);
            }

            // sort right side
            if(partitionIndex + 1 < right)
            {
                SortArray(arr, partitionIndex + 1, right);
            }
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];

        while(true)
        {
            while(arr[left] < pivot)
            {
                left++;
            }

            while(arr[right] > pivot)
            {
                right--;
            }

            if(left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                if(arr[left] == arr[right]) { left++; }
            }
            else
            {
                return right;
            }
        }
    }
}