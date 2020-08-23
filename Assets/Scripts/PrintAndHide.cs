using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    string objName;
    int i;
    public Renderer rend;
    string objTag;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        objName = gameObject.name;
        i = 0;
        objTag = gameObject.tag;
        random = rnd.Next(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 100 && objTag.Equals("Red"))
        {
            gameObject.SetActive(false);
        }
        if (i == random && objTag.Equals("Blue"))
        {
            rend.enabled = false;
        }


        Debug.Log(objName + ": " + i);
        i++;

        
    }
}
