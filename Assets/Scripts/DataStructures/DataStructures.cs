using UnityEngine;

public class Containers : MonoBehaviour
{
    void Start()
    {
        Dict dict = new Dict();
        dict.Add("Alan", "Shearer");
        dict.Add("Dwight", "Yorke");
        dict.Add("Gary", "Lineker");
        dict.Add("Jermaine", "Jenas");

        Debug.Log(dict.Get("Alan").Value);

        dict.Add("Danny", "Murphy");

        Debug.Log(dict.Get("Alan").Value);
        Debug.Log(dict.Get("Danny").Value);

        dict.Remove("Danny");
        dict.Remove("Dwight");
        dict.Remove("Bob");

        Debug.Log(dict.Get("Gary").Value);
    }
}
