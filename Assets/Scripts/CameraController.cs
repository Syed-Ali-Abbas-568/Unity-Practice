using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

public Camera back;
  public  Camera pov;
public KeyCode key;
    void Start()
    {
       back.enabled=true;
       pov.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            back.enabled=!back.enabled;
            pov.enabled=!pov.enabled;
    
        }
    }
}
