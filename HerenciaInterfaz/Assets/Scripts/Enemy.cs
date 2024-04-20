using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    
    public void TakeDamage(int delta)
    {
        _health -= delta;
        if (_health < 0)
        {
            Destroy(gameObject);
        }
    }
}