using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private int _damage;
    private Vector3 _position;

    void Update()
    {
        _position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _position.z = 0;
        transform.position = _position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(_damage);
        }
        
        BigGolem golem = other.GetComponent<BigGolem>();
        if (golem != null)
        {
            golem.TakeDamage(_damage);
        }

        Spartan spartan = other.GetComponent<Spartan>();
        if (spartan != null)
        {
            spartan.TakeDamage(_damage);
        }

        Pot pot = other.GetComponent<Pot>();
        if (pot != null)
        {
            pot.TakeDamage(_damage);
        }
    }
}
