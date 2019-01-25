using System;
using System.Collections.Generic;
using UnityEngine;

public class SearchAlgorithms : MonoBehaviour 
{
    private const int MS_IN_SEC = 1000;

    private List<SearchTestCase> testCases = new List<SearchTestCase>();

    private void Start()
    {
        testCases.Add(new SearchTestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 8));
        testCases.Add(new SearchTestCase(new int[] { 3, 3, 3 }, 3));
        testCases.Add(new SearchTestCase(new int[] { 1 }, 1));

        double ms = 0;
        float time = Time.realtimeSinceStartup;

        // linear search
        foreach(SearchTestCase testCase in testCases)
        {
            int[] result = LinearSearch.SearchArray(testCase.SortedArray, testCase.Target);
            Debug.Log(string.Format("{0}:{1}", result[0], result[1]));
        }

        ms = Math.Round((Time.realtimeSinceStartup - time) * MS_IN_SEC, 2);
        Debug.Log(string.Format("Linear: {0}ms", ms));
        time = Time.realtimeSinceStartup;

        // binary search
        foreach(SearchTestCase testCase in testCases)
        {
            int[] result = BinarySearch.SearchArray(testCase.SortedArray, testCase.Target);
            Debug.Log(string.Format("{0}:{1}", result[0], result[1]));
        }

        ms = Math.Round((Time.realtimeSinceStartup - time) * MS_IN_SEC, 2);
        Debug.Log(string.Format("Binary: {0}ms", ms));
        time = Time.realtimeSinceStartup;
    }
}

public class SearchTestCase
{
    public int[] SortedArray;
    public int Target;

    public SearchTestCase(int[] sortedArray, int target)
    {
        SortedArray = sortedArray;
        Target = target;
    }
}