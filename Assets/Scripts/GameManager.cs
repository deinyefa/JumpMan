using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private GameObject restartCanvans;

	void Awake () {
		restartCanvans = GameObject.FindGameObjectWithTag ("Restart Canvas");
		if (restartCanvans == null)
			Debug.Log ("Can't find Restart_HUD!");
	}

	void Start () {
		//restartCanvans.SetActive (false);
	}

	public void RestartGame () {
		SceneManager.LoadScene ("Game");
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			restartCanvans.SetActive (true);
		}
	}
}
