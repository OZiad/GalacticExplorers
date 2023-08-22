using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int damage = 1;
    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the colliding object has a specific tag
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("collided with enemy");
            // Destroy this game object (the one with the script attached)
        }
        Destroy(this.gameObject);
    }
}