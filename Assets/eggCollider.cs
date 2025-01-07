using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggCollider : MonoBehaviour
{

    public string eggTag = "Egg";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(eggTag))
        {
            // Get or add a flag component to track if this egg was already counted
            EggCollected eggCollected = collision.gameObject.GetComponent<EggCollected>();
            if (eggCollected == null)
            {
                // If egg hasn't been counted yet, add the component as a flag and count it
                collision.gameObject.AddComponent<EggCollected>();
                ScoreManager.instance.AddEgg();
                
                Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.isKinematic = true;
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }
}
