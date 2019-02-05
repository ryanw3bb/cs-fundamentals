using UnityEngine;

public class SortAlgorithms : MonoBehaviour 
{
	private void Start() 
    {
        int[] arr = { 12, 24, 5, 15, 483, 34, 11, 0, 5, 12, 54 };

        Debug.Log(string.Join(", ", arr));

        BubbleSort.SortArray(arr);

        Debug.Log(string.Join(", ", arr));
    }
}