using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class pTwoCamCon : MonoBehaviour
{
    public GameObject pTwo;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - pTwo.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = pTwo.transform.position + offset;
    }
}
