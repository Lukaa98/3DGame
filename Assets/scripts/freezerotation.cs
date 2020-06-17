using System.Collections;
using UnityEngine;

public class freezerotation : MonoBehaviour
{   
            float x = 265;
            float y = 191;
            float z = -78;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.rotation = Quaternion.Euler (x, y, z);
    }
}
