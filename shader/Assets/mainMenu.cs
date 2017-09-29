using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public string level;

	public void NewGame(){
		Application.LoadLevel(level);

	}

	public void Quit(){
		Application.Quit ();

	}
}


