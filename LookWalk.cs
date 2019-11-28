using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour
{
	public Transform vrCam;
	public float tAngle=19.0f;
	public float speed=5.0f;
	public bool walk;

	private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
     
		cc = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
		if (vrCam.eulerAngles.x >= tAngle && vrCam.eulerAngles.x <= 90.0f) {
			walk = true;
		} else {
			walk = false;
		}

		if (walk) {
			Vector3 forward = vrCam.TransformDirection (Vector3.forward);
				cc.SimpleMove (speed * forward);
		}
        
    }
}
