using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    string objName;
    int i;
    public Renderer rend;

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
