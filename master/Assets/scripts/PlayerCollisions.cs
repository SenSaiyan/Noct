using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

	public GameState gameState;
	public AudioSource audio;
	public AudioSource audio2;
	public AudioClip clip;
	public AudioClip clip2;

	private PlayerMove msBoost;


	// Use this for initialization
	void Start () {
		GameObject worldRef = GameObject.Find("GameState");
		gameState = worldRef.GetComponent<GameState>();

		GameObject clip = GameObject.Find("charge (1)");
		audio = clip.GetComponent<AudioSource>();

		GameObject clip2 = GameObject.Find("monstercharge (1)");
		audio2 = clip2.GetComponent<AudioSource>();

		msBoost = gameObject.GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Charge" && gameObject.tag == "player0")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio.Play ();
			gameState.player0_charge += 1;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "player1")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio.Play ();
			gameState.player1_charge += 1;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "player2")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio.Play ();
			gameState.player2_charge += 1;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "player3")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio.Play ();
			gameState.player3_charge += 1;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "monster0")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio2.Play ();
			msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/5;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "monster1")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio2.Play ();
			msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/5;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "monster2")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio2.Play ();
			msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/5;
		}
		if(other.gameObject.tag == "Charge" && gameObject.tag == "monster3")
		{
			gameState.SpawnCharge();
			Destroy(other.gameObject);
			audio2.Play ();
			msBoost.moveSpeed = msBoost.moveSpeed + msBoost.moveSpeed/5;
		}
			
	}
		
	
}
