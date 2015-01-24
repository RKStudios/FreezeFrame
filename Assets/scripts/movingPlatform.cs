using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour {

	public Transform destination;
	public Transform origin;
	public Transform platformObject;

	public float speed;
	public bool moveToOrigin = false;

	void FixedUpdate()
	{
		if (platformObject.position == destination.position)
		{
			moveToOrigin = true;
		}
		if (platformObject.position == origin.position)
		{
			moveToOrigin = false;
		}
		if (moveToOrigin)
		{
			platformObject.position = Vector3.MoveTowards(platformObject.position, origin.position, speed);
		}
		else
		{
			platformObject.position = Vector3.MoveTowards(platformObject.position, destination.position, speed);
		}
	}
}
