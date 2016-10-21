using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedDefender;

	private Button[] buttonArray;
	private Text costText;

	// Use this for initialization
	void Start () {
	
		costText = GetComponentInChildren<Text>();
		if (!costText) { Debug.LogWarning (name + " has no cost text"); }
		
		costText.text = defenderPrefab.GetComponent<Defender>().starCost.ToString ();
	
		buttonArray = GameObject.FindObjectsOfType<Button>();
		foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown () {
		
		foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
		
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defenderPrefab;
		//print (selectedDefender);
	}
}
