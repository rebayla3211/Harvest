using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform StartingPoint;
    public Transform EndPoint;
    public float speed = 1.0F;
    void Start(){

    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.position = Vector3.Lerp(transform.position, EndPoint.position, Time.deltaTime*speed);
        } 
        else{
            this.transform.position = Vector3.Lerp(transform.position, StartingPoint.position, Time.deltaTime*7.0f);
        }
    }
}
