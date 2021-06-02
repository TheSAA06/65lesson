using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    float vert;
    float horiz;
    Transform cube_tr;
    Rigidbody cube_rb;
    public GameObject sphere;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
        cube_rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        vert = Input.GetAxis("Vertical") * 10f;
        horiz = Input.GetAxis("Horizontal") * 1f;
        cube_rb.AddForce(cube_tr.forward * vert);
        cube_tr.Rotate(0,horiz,0);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(sphere.gameObject);
            print("сфера сломана");
        }
    }
}
