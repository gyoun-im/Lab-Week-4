using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    string objName;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        objName = gameObject.name;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(objName + ": " + i);
        i++;
    }
}
