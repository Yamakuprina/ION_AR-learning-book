using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamFollow : MonoBehaviour
{
	public Transform target;      
	public float smoothing;
	public float smoothingRot;


	void FixedUpdate ()
	{
		if (GameObject.Find("UI").GetComponent<UI_Contr>().TargetExists == false) { 

			Vector3 targetPos = target.transform.position;
			transform.position = Vector3.Lerp (transform.position, targetPos, smoothing * Time.deltaTime);


			Quaternion targetRot = target.transform.rotation;
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRot, smoothingRot * Time.deltaTime);


		} 

	}
}