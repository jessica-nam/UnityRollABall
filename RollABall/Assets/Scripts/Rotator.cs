using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	void Update () 
	{
        // rotate in relation to itself
		//transform.Rotate (0f, 1 * 0.5f, 0f, Space.Self);
        transform.Rotate (new Vector3 (0f, 200f, 0f) * Time.deltaTime);
	}
}	