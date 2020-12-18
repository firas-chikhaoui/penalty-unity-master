using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(-15f, Physics.gravity.y, 0);
        Vector3 campos = Camera.main.transform.position;
        campos.x = 550;
        campos.z = -50;
        Camera.main.transform.position = campos;
        campos = GameObject.Find("Cannon").transform.position;
        campos.x = 552;
        campos.z = -70;
        GameObject.Find("Cannon").transform.position = campos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
