using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    public Transform target;



    void Start ()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update ()
    {
        Vector3 playerpos = target.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}