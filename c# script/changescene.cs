using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class changescene : MonoBehaviour
{
	public void changetoscene(string scenetochangeto){
		Application.LoadLevel (scenetochangeto);

	}
}


