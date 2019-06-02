using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringGun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    //private 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fire()
    {
        Instantiate(bullet, barrel.GetComponent<Transform>());
    }


}
