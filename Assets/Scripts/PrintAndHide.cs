using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 3;
    public Renderer rend;
    public int disableval;
    void Start()
    {
        disableval = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (tag == "Blue" && i == disableval)
        {
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
        i++;
        Debug.Log(gameObject.name + ":" + i);

    }
}
