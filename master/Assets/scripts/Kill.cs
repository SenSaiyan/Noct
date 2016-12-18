using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public AudioSource audio;
	public int deaths;

	public GameState gameState;

//	public GameObject spriteFab0;
//	public GameObject spriteFab1;
//	public GameObject spriteFab2;
//	public GameObject spriteFab3;

	// Use this for initialization
	void Start () {
		GameObject worldRef = GameObject.Find("GameState");
		gameState = worldRef.GetComponent<GameState>();

		GameObject clip = GameObject.Find("elimination (1)");
		audio = clip.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
//			Instantiate (spriteFab1);
//			Instantiate (spriteFab2);
//			Instantiate (spriteFab3);
//			deaths = 0;
		}

	void OnTriggerEnter(Collider other) {
		//if (gameObject.tag == "monster0") {
			if(other.gameObject.tag == "player0")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player0char);
			}
			if(other.gameObject.tag == "player1")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player1char);
			}
			if(other.gameObject.tag == "player2")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player2char);
			}
			if(other.gameObject.tag == "player3")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player3char);
			}
		//}
	}
}
