using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public int health = 1;

    void Start()
    {

    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            BulletController bullet = other.gameObject.GetComponent<BulletController>();
            if (bullet != null)
            {
                Debug.Log("Collision with bullet. HP is: " + health);
                health -= bullet.damage;
                if (health <= 0)
                {
                    Die();
                }
            }
        }
    }
    private void Die()
    {
        // Play death animation, effects, etc. here



        Destroy(gameObject);
    }
}
