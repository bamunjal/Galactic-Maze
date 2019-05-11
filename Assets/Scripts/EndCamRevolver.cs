using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCamRevolver : MonoBehaviour
{    
    public float speed;
    void Update()
    {
        Transform target= GameObject.FindGameObjectWithTag("Maze").transform;
        this.transform.Translate(Vector3.right * (Time.deltaTime * speed));
        this.transform.Translate(Vector3.up * (Time.deltaTime ));
        this.transform.LookAt(target);
    }
}
