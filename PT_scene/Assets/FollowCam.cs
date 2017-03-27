using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public GameObject runner1;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - runner1.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = runner1.transform.position + offset;
	}
}