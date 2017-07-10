using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
	public void OnStartButtonClicked ()
	{
		Application.LoadLevel ("Main");
	}
}
