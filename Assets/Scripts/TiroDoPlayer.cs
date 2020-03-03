using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoPlayer : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Transform bulletExit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootAt();
        }
    }

    void shootAt()
    {
        Rigidbody2D bulletRgbd = Instantiate(bullet, bulletExit.position, bulletExit.rotation);        

        bulletRgbd.velocity = transform.right * 8f;        
    }
}
