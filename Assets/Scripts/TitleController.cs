using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
	public void OnStartButtonClicked ()
	{
//		Application.LoadLevel ("Main");
		SceneManager.LoadScene ("Main");
	}
}
