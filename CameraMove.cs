using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    private GameObject targetObj;
    private Vector3 targetPos;

    void Start ()
    {
        targetObj = GameObject.FindGameObjectWithTag("Player");
        targetPos = targetObj.transform.position;
    }

    void Update ()
    {
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        if (Input.GetMouseButton(1))
        {
            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");

            transform.RotateAround(targetPos, Vector3.down, mouseInputX * Time.deltaTime * 100);
            transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 100);
        }
    }
}
