using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Camera cam;
    public int camsize = 100;

    void Start()
    {
        cam.orthographicSize = camsize;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
