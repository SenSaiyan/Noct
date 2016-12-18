using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public AudioSource audio;
	public int deaths;
	private PlayerMove msBoost;

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

		msBoost = gameObject.GetComponent<PlayerMove>();
	}

	// Update is called once per frame
	void Update () {
//			Instantiate (spriteFab1);
//			Instantiate (spriteFab2);
//			Instantiate (spriteFab3);
//			deaths = 0;
		}

	void OnTriggerEnter(Collider other) {
		if (gameObject.tag == "monster0") {
			if(other.gameObject.tag == "player0")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player0char);
				gameState.player0_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
			}
			if(other.gameObject.tag == "player1")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player1char);
				gameState.player0_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
			}
			if(other.gameObject.tag == "player2")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player2char);
				gameState.player0_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
			}
			if(other.gameObject.tag == "player3")
			{
				Destroy(other.gameObject);
				audio.Play ();
				Instantiate (gameState.player3char);
				gameState.player0_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
			}
		}

		if (gameObject.tag == "monster1") {
			if (other.gameObject.tag == "player0") {
				Destroy (other.gameObject);
				audio.Play ();
				Instantiate (gameState.player0char);
				gameState.player1_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed / 20;
			}
			if (other.gameObject.tag == "player1") {
				Destroy (other.gameObject);
				audio.Play ();
				Instantiate (gameState.player1char);
				gameState.player1_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed / 20;
			}
			if (other.gameObject.tag == "player2") {
				Destroy (other.gameObject);
				audio.Play ();
				Instantiate (gameState.player2char);
				gameState.player1_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed / 20;
			}
			if (other.gameObject.tag == "player3") {
				Destroy (other.gameObject);
				audio.Play ();
				Instantiate (gameState.player3char);
				gameState.player1_score += 1;
				msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed / 20;
			}
		}

		if (gameObject.tag == "monster2") {
				if(other.gameObject.tag == "player0")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player0char);
					gameState.player2_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player1")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player1char);
					gameState.player2_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player2")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player2char);
					gameState.player2_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player3")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player3char);
					gameState.player2_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
			}

			if (gameObject.tag == "monster3") {
				if(other.gameObject.tag == "player0")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player0char);
					gameState.player3_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player1")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player1char);
					gameState.player3_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player2")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player2char);
					gameState.player3_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
				if(other.gameObject.tag == "player3")
				{
					Destroy(other.gameObject);
					audio.Play ();
					Instantiate (gameState.player3char);
					gameState.player3_score += 1;
					msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/20;
				}
			}
		}
	}

