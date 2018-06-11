using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_111 : MonoBehaviour {

	public void Simple_Scene_Launcher(){
		SceneManager.LoadScene (1);
	}

	public void VR_Scene_Launcher(){
		SceneManager.LoadScene (2);
	}
}
