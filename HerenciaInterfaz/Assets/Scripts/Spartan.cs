using UnityEngine;

public class Spartan : MonoBehaviour
{
    [SerializeField] private int _damageBlocker;
    [SerializeField] private int _health;
    
    public void TakeDamage(int delta)
    {
        if (_damageBlocker > delta)
        {
            return;
        }
        _health -= delta;
        if (_health < 0)
        {
            Destroy(gameObject);
        }
    }
}