using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Components
    Transform transform;


    public GameObject target;

    public void Awake()
    {
        transform = GetComponent<Transform>();
    }

    public void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
}
