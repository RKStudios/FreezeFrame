using UnityEngine;
using System.Collections;

public class MenuPopup : MonoBehaviour {

	public GUISkin skin;
	private bool showMenuScreen = false;
	public int menuScreenWidth, menuScreenHeight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			showMenuScreen = true;
		}
	}

	void OnGUI() {
		GUI.skin = skin;

		if (showMenuScreen) {
			Rect menuScreenRect = new Rect(Screen.width/2 - (menuScreenWidth/2), Screen.height/2 - (menuScreenHeight/2), menuScreenWidth, menuScreenHeight);
			GUI.Box (menuScreenRect, "Paused");
			Time.timeScale=0f;
			if (GUI.Button(new Rect(Screen.width/2 - (menuScreenWidth/4) + 10, Screen.height/2 - 60, 150, 40), "Resume")){
				showMenuScreen = false;
				Time.timeScale=1f;
			}
			if (GUI.Button(new Rect(Screen.width/2 - (menuScreenWidth/4) + 10, Screen.height/2 + 30, 150, 40), "Main Menu")){
				showMenuScreen = false;
				Application.LoadLevel ("MainMenu");
				Time.timeScale=1f;
			}
	}
}
}
