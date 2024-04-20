using UnityEngine;

public class BigGolem : MonoBehaviour
{
    [SerializeField] private Enemy _smallGolem;
    [SerializeField] private int _health;
    
    public void TakeDamage(int delta)
    {
        _health -= delta;
        if (_health < 0)
        {
            Instantiate(_smallGolem, transform.position + Vector3.left, Quaternion.identity);
            Instantiate(_smallGolem, transform.position - Vector3.left, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}