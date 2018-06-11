using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour {

	private bool GyroEnabled;
	private Gyroscope Gyro;
	private GameObject CameraContainer;
	private Quaternion rotation;
	public float SmoothingRot;

	private void Start(){

		CameraContainer = new GameObject ("Camera Container");
		CameraContainer.transform.position = transform.position;
		transform.SetParent (CameraContainer.transform);

		GyroEnabled = EnableGyro ();
	}
	private bool EnableGyro(){
	
		if (SystemInfo.supportsGyroscope) {
			Gyro = Input.gyro;
			Gyro.enabled = true;

			CameraContainer.transform.rotation = Quaternion.Euler (90f,90f, 0f);
			rotation = new Quaternion (0, 0, 1, 0);

			return true;
		}
		return false;
	}
	private void Update(){
	
		if (GyroEnabled) {
			transform.localRotation =  Gyro.attitude * rotation;
		}
	}
}
