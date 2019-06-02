using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTime : MonoBehaviour
{
    // Start is called before the first frame update
    public int timer;
    public GameObject barrel;
    public float shotforce;

    void Start()
    {
        this.gameObject.GetComponent<Transform>().position = barrel.GetComponent<Transform>().position;
        this.gameObject.GetComponent<Transform>().rotation = barrel.GetComponent<Transform>().rotation;
        this.gameObject.GetComponent<Rigidbody>().AddForce(shotforce * Vector3.right);
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
