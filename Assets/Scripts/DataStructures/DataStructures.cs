using UnityEngine;
using CS;

public class DataStructures : MonoBehaviour
{
    void Start()
    {
        Dictionary dict = new Dictionary();
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

        LinkedList linkedList = new LinkedList();
        linkedList.AddFirst("Alan Shearer");
        linkedList.AddFirst("Dwight Yorke");
        linkedList.AddFirst("Gary Lineker");
        linkedList.AddFirst("Jermaine Jenas");

        Node dwight = linkedList.Find("Dwight Yorke");
        linkedList.AddBefore(dwight, "Danny Murphy");
        linkedList.AddBefore(dwight, "Gary Neville");
        linkedList.AddAfter(dwight, "Jamie Carragher");

        Debug.Log(linkedList.ToString());

        Vector3 v1 = new Vector3(50, 50, 0);
        Vector3 v2 = new Vector3(25, 25, 0);
        Vector3 v3 = new Vector3(-40, -40, 0);
        Vector3 v4 = new Vector3(10, -10, 30);

        Debug.Log(VectorUtils.Normalize(v1));
        Debug.Log(VectorUtils.Normalize(v2));
        Debug.Log(VectorUtils.Normalize(v3));
        Debug.Log(VectorUtils.Normalize(v4));
    }
}
