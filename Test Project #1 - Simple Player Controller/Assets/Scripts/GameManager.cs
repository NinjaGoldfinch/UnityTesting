using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Camera cam;
    
    void Start()
    {
        cam.pixelRect = new Rect(0,0,1000,1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
