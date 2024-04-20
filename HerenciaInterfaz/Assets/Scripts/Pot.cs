using UnityEngine;

public class Pot : MonoBehaviour
{
    public void TakeDamage(int delta)
    {
        Destroy(gameObject);
    }
}
