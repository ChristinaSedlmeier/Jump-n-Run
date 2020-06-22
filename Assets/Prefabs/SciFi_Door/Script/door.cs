using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
	public GameObject startLevelUI;
	public bool easyDoor;
	public MenuManager menuManager;

	void OnTriggerEnter ( Collider obj  ){
		thedoor= GameObject.FindWithTag("SF_Door");
		thedoor.GetComponent<Animation>().Play("open");
		startLevelUI.SetActive(true);
		menuManager.easy = easyDoor;
		//menuManager.LoadGame();
		
		

	}
		

void OnTriggerExit ( Collider obj  ){
	thedoor= GameObject.FindWithTag("SF_Door");
	thedoor.GetComponent<Animation>().Play("close");
}
}