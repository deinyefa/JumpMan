using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Canvas restartButton;
	private GameObject player;

	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (restartButton == null)
			Debug.Log ("Can't find Restart_HUD!");
	}

	void Start () {
		restartButton.enabled = !restartButton.enabled;
	}

	void Update () {
		if (!player) {
			restartButton.enabled = true;
		}
	}

	public void RestartGame () {
		SceneManager.LoadScene ("Game");
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			Destroy (other.gameObject);
		}
	}
}
