using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject[] ObjsToRotate;

    public GameObject ControlWheel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in ObjsToRotate)
        {
            obj.transform.localScale = ControlWheel.transform.localScale;
        }
    }
}
