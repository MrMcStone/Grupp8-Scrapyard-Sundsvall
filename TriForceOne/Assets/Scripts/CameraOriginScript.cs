using UnityEngine;
using System.Collections;

public class CameraOriginScript : MonoBehaviour
{

	float xVelocity = 0;
	float zVelocity = 0;

	public float xClamp;
	public float zClamp;

	public float xTarget;
	public float zTarget;

	float posX;
	float posZ;

	Vector3 posVec;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Vertical movement
		if (Input.GetKey(KeyCode.W))
			zTarget = 0.1f;

		else if (Input.GetKey(KeyCode.S))
			zTarget = -0.1f;

		else
			zTarget = 0;

		//Horizontal movement

		if (Input.GetKey(KeyCode.A))
			xTarget = -0.1f;

		else if (Input.GetKey(KeyCode.D))
			xTarget = 0.1f;

		else
			xTarget = 0;

		zVelocity = Mathf.Lerp(zVelocity, zTarget, Time.deltaTime * 3);
		xVelocity = Mathf.Lerp(xVelocity, xTarget, Time.deltaTime * 3);

		posX += xVelocity;
		posZ += zVelocity;

		posX = Mathf.Clamp(posX, -xClamp, xClamp);
		posZ = Mathf.Clamp(posZ, -zClamp, zClamp);

		posVec.x = posX;
		posVec.z = posZ;

		transform.position = posVec;
	}
}
