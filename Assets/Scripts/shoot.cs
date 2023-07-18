using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject BulletPreFab;
    public Transform Bulletspawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pew"))
        {
            Instantiate(BulletPreFab, Bulletspawn.position, Quaternion.identity);
        }
    }
}
