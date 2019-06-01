using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform Player;
    public float Speed;

    private float minDist = 5;
    private float maxDist = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDist)
        {

            transform.position += transform.forward * Speed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= maxDist)
            {
                //throwTrash();
            }
        }
    }

    void throwTrash()
    {

    }
}
