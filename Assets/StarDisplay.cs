using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private Text starText;
	private int numberOfStars = 100;

	// Use this for initialization
	void Start () {
		starText = GetComponent<Text>();
		starText.text = numberOfStars.ToString ();
	}

	private void UpdateDisplay ()
	{
		starText.text = numberOfStars.ToString ();
	}
	
	public void AddStars (int amount) {
		numberOfStars += amount;
		UpdateDisplay ();
	}  
	
	public void UseStars (int amount) {
		numberOfStars -= amount;
		UpdateDisplay ();
	}
}
