using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Runner1;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - Runner1.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = Runner1.transform.position + offset;
	}
}