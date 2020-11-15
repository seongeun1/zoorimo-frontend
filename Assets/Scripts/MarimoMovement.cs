using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarimoMovement : MonoBehaviour
{

    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (time < 1f) 
        {
            this.transform.position = new Vector3(0, 9 - 12 * time, 0);
        }
        
        else if (time < 1.5f)
        {
            this.transform.position = new Vector3(0, -3+(8)*(time-1f), 0);
        }
        
        else if (time < 2.0f) 
        {
            this.transform.position = new Vector3(0, 1-(4)*(time-1.5f), 0);
        }
       
        else if (time < 2.5f)
        {
            this.transform.position = new Vector3(0, -1+(2)*(time-2.0f), 0);
        }     

        time += Time.deltaTime;

    }
}
