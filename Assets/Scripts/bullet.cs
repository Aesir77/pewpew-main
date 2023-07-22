using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * bulletspeed * Time.deltaTime);
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (collision.gameObject.tag == "Zombie")
                Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }



    }
    
}
