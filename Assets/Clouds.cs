using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
   // public float speed = .1f;
   // Vector3 loc;

    //float radius = 30f;


   // private float angle = 1;

    public float angularSpeed = .01f;
    public float circleRad = 15f;
    public float currentAngle = 0;

    private Vector3 fixedPoint;

    void Start()
    {
        currentAngle = currentAngle * (Mathf.PI / 180);


        fixedPoint = transform.position;
        fixedPoint = new Vector3(0, fixedPoint.y, 0);
       // Debug.Log("pos is " + fixedPoint);
        Update();
        fixedPoint = new Vector3(0, 0.3f, 0);

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("pos is " + fixedPoint);
        currentAngle += angularSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(Mathf.Sin(currentAngle), fixedPoint.y, Mathf.Cos(currentAngle)) * circleRad;
        transform.position = fixedPoint + offset;
    }


}
