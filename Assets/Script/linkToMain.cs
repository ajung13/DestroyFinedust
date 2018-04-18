using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class linkToMain : MonoBehaviour {

	void OnMouseUpAsButton(){
		SceneManager.LoadScene ("Scenes/main");
	}
}
