﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {

	private AudioSource pickupSoundSource;
	public static int MazeCount = 0;

	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup") {
			pickupSoundSource.Play();
			MazeCount += 1;
			SceneManager.LoadScene("Play");
		}
	}
}
