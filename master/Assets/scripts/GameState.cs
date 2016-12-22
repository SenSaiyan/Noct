using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	private int firstCharge;
	public GameObject charge1;
	public GameObject charge2;
	public GameObject charge3;
	public GameObject charge4;
	public GameObject charge5;
	public GameObject charge6;
	public GameObject charge7;
	public GameObject charge8;

	public int player0_charge;
	public int player1_charge;
	public int player2_charge;
	public int player3_charge;
	private int chargeGoal;

	public int player0_score;
	public int player1_score;
	public int player2_score;
	public int player3_score;
	private int scoreLimit;

	public GameObject player0char;
	public GameObject player0mon;
	public GameObject player1char;
	public GameObject player1mon;
	public GameObject player2char;
	public GameObject player2mon;
	public GameObject player3char;
	public GameObject player3mon;

	public GameObject chargeExists;
	// Use this for initialization

	void Start () {
		//SpawnCharge ();
		chargeGoal = 3;
		scoreLimit = 15;
		ChargeReset ();

		player0_score = 0;
		player1_score = 0;
		player2_score = 0;
		player3_score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		SpawnCharge ();
		if (player0_score >= scoreLimit) {
			LoadP0wins();
		}
		if (player1_score >= scoreLimit) {
			LoadP1wins();
		}
		if (player2_score >= scoreLimit) {
			LoadP2wins();
		}
		if (player3_score >= scoreLimit) {
			LoadP3wins();
		}

		if (player0_charge >= chargeGoal) {
			ChargeReset ();
			Destroy (GameObject.FindWithTag("player0"));
			KillMonsters ();
			Instantiate (player0mon);
			if (!GameObject.FindWithTag ("player1")) {
				Instantiate (player1char);
			}
			if (!GameObject.FindWithTag ("player2")) {
				Instantiate (player2char);
			}
			if (!GameObject.FindWithTag ("player3")) {
				Instantiate (player3char);
			}
		}
		if (player1_charge >= chargeGoal) {
			ChargeReset ();
			Destroy (GameObject.FindWithTag("player1"));
			KillMonsters ();
			Instantiate (player1mon);
			if (!GameObject.FindWithTag ("player0")) {
				Instantiate (player0char);
			}
			if (!GameObject.FindWithTag ("player2")) {
				Instantiate (player2char);
			}
			if (!GameObject.FindWithTag ("player3")) {
				Instantiate (player3char);
			}
		}
		if (player2_charge >= chargeGoal) {
			ChargeReset ();
			Destroy (GameObject.FindWithTag("player2"));
			KillMonsters ();
			Instantiate (player2mon);
			if (!GameObject.FindWithTag ("player0")) {
				Instantiate (player0char);
			}
			if (!GameObject.FindWithTag ("player1")) {
				Instantiate (player1char);
			}
			if (!GameObject.FindWithTag ("player3")) {
				Instantiate (player3char);
			}
		}
		if (player3_charge >= chargeGoal) {
			ChargeReset ();
			Destroy (GameObject.FindWithTag("player3"));
			KillMonsters ();
			Instantiate (player3mon);
			if (!GameObject.FindWithTag ("player0")) {
				Instantiate (player0char);
			}
			if (!GameObject.FindWithTag ("player1")) {
				Instantiate (player1char);
			}
			if (!GameObject.FindWithTag ("player2")) {
				Instantiate (player2char);
			}
		}
		chargeExists = GameObject.FindWithTag("Charge");
		Debug.Log (chargeExists);
	}

	public void SpawnCharge(){
		firstCharge = Random.Range(1,9);
		if ((firstCharge == 1) && (chargeExists == null)) {
			Instantiate (charge1);
		}
		if ((firstCharge == 2) && (chargeExists == null)) {
			Instantiate (charge2);
		}
		if ((firstCharge == 3) && (chargeExists == null)) {
			Instantiate (charge3);
		}
		if ((firstCharge == 4) && (chargeExists == null)) {
			Instantiate (charge4);
		}
		if ((firstCharge == 5) && (chargeExists == null)) {
			Instantiate (charge5);
		}
		if ((firstCharge == 6) && (chargeExists == null)) {
			Instantiate (charge6);
		}
		if ((firstCharge == 7) && (chargeExists == null)) {
			Instantiate (charge7);
		}
		if ((firstCharge == 8) && (chargeExists == null)) {
			Instantiate (charge8);
		}
	}

	public void ChargeReset(){
		player0_charge = 0;
		player1_charge = 0;
		player2_charge = 0;
		player3_charge = 0;
	}

	public void KillMonsters(){
		Destroy (GameObject.FindWithTag("monster0"));
		Destroy (GameObject.FindWithTag("monster1"));
		Destroy (GameObject.FindWithTag("monster2"));
		Destroy (GameObject.FindWithTag("monster3"));
	}

	public void LoadP0wins(){
		Application.LoadLevel ("EndP1");
	}
	public void LoadP1wins(){
		Application.LoadLevel ("EndP2");
	}
	public void LoadP2wins(){
		Application.LoadLevel ("EndP3");
	}
	public void LoadP3wins(){
		Application.LoadLevel ("EndP4");
	}
}
