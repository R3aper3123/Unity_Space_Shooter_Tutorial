using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;

    void start ()
    {
        Destroy(gameObject, lifetime);
    }
}
