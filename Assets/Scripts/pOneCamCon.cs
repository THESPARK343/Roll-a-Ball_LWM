using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pOneCamCon : MonoBehaviour
{

    public GameObject pOne;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - pOne.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void LateUpdate()
    {
     transform.position = pOne.transform.position + offset;
    }
}
