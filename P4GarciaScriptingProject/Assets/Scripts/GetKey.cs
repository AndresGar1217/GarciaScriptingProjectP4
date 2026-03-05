using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input GetKeyUp(KeyCode.Space);

        if (down)
        {
            Debug.Log("Get Key Down is: " + down);
        }
        else if (held)
        {
            Debug.Log("Key hells is: " + down);
        }
      
    }
}
