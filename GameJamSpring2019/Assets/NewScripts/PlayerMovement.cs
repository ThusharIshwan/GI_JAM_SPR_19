using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos.position = new Vector3(pos.position.x + (Input.GetAxis("Horizontal")* speed), pos.position.y, pos.position.z + (Input.GetAxis("Vertical") * speed));
    }
}
