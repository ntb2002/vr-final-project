using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public int Health = 10;
    public string BulletTag = "Bullet";

    
    void Update()
    {
        
        if (Health <= 0)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag(BulletTag))
        {
            Health -= 1;
        }
    }
}
