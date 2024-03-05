using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAttack : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private float speed = 1.0f;
    public float damage = 3;

    public void Init(Vector2 dir)
    {
        rb.velocity = dir * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("enemy");
        if (other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Health -= damage;
                Destroy(gameObject, 3f);
            }
        }
    }
}

