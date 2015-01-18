using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float cameraSpeed =0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(-Vector3.forward * cameraSpeed);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.forward * cameraSpeed);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(-Vector3.up * cameraSpeed);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * cameraSpeed);
		}
	}
}
