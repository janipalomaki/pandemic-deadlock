using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code will remove the infotext at the beginning of the game after 10 seconds

public class info : MonoBehaviour
{
    private GameObject text = null;

    // Start is called before the first frame update
    void Start()
    {

        this.text = GameObject.Find("info");
        Destroy(this.text, 10f);

    }
}

