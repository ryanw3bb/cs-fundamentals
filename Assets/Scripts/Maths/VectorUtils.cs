using UnityEngine;

public static class VectorUtils 
{
    // Dot returns a single decimal indicating the parallelness of 2 vectors
    // For normalized vectors Dot returns 1 if they point in exactly the same direction, 
    // -1 if they point in completely opposite directions and 0 if the vectors are perpendicular.
    public static float Dot(Vector3 v1, Vector3 v2)
    {
        return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
    }

    // cross returns the vector perpendicular to 2 given vectors (basically the normal to the plane)
    // it's magnitude tells us something
    public static Vector3 Cross(Vector3 v1, Vector3 v2)
    {
        return new Vector3
        (
            v1.y * v2.z - v1.z * v2.y,
            v1.z * v2.x - v1.x * v2.z,
            v1.x * v2.y - v1.y * v2.x
        );
    }

    // get the unit vector of given vector (make it have a magnitude of 1)
    // calculated using pythagoras theorum
    public static Vector3 Normalize(Vector3 v)
    {
        float magnitude = Mathf.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);

        return v / magnitude;
    }
}