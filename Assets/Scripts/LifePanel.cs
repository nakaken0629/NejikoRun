using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
	public GameObject[] icons;

	// ライフに応じてスプライトを出し分ける
	public void UpdateLife (int life)
	{
		for (int i = 0; i < 3; i++) {
			if (i < life) {
				icons [i].SetActive (true);
			} else {
				icons [i].SetActive (false);
			}
		}
	}
}
