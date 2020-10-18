using UnityEngine;
using System.Collections;

public class sunScript : MonoBehaviour
{

    [HideInInspector]
    public GameObject sun;

    [HideInInspector]
    public Light sunLight;

    public float numberOfFrames = 0;

	int initial_rotation = -5;
	int final_rotation = 205;

    float current_rotation = 0;
    float add = 0;


   void Start()
    {
	    add = (final_rotation-initial_rotation) / numberOfFrames;

        current_rotation = initial_rotation;

        sun = gameObject;
        sunLight = gameObject.GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (current_rotation <= final_rotation)
        {
	        sun.transform.localEulerAngles = new Vector3(current_rotation, 230, 0);
            current_rotation += add;
        }
        // start a new cycle
        else if (current_rotation > final_rotation)
        {
            current_rotation = initial_rotation;
            sun.transform.localEulerAngles = new Vector3(current_rotation, 0, 0);
            current_rotation += add;
        }

    }

}