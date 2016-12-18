using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_update : MonoBehaviour {

	private GameState gameState;

	private Text p0score;
	private Text p1score;
	private Text p2score;
	private Text p3score;
	private Text p0charge;
	private Text p1charge;
	private Text p2charge;
	private Text p3charge;

	// Use this for initialization
	void Start () {

		gameState = GetComponent<GameState>();

		GameObject p0scREF = GameObject.Find("p0score");
		p0score = p0scREF.GetComponent<Text> ();

		GameObject p1scREF = GameObject.Find("p1score");
		p1score = p1scREF.GetComponent<Text> ();

		GameObject p2scREF = GameObject.Find("p2score");
		p2score = p2scREF.GetComponent<Text> ();

		GameObject p3scREF = GameObject.Find("p3score");
		p3score = p3scREF.GetComponent<Text> ();

		GameObject p0chREF = GameObject.Find("p0chargeUI");
		p0charge = p0chREF.GetComponent<Text> ();

		GameObject p1chREF = GameObject.Find("p1chargeUI");
		p1charge = p1chREF.GetComponent<Text> ();

		GameObject p2chREF = GameObject.Find("p2chargeUI");
		p2charge = p2chREF.GetComponent<Text> ();

		GameObject p3chREF = GameObject.Find("p3chargeUI");
		p3charge = p3chREF.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		p0score.text = gameState.player0_score.ToString();
		p1score.text = gameState.player1_score.ToString();
		p2score.text = gameState.player2_score.ToString();
		p3score.text = gameState.player3_score.ToString();
		p0charge.text = "Charges: " + gameState.player0_charge.ToString();
		p1charge.text = "Charges: " + gameState.player1_charge.ToString();
		p2charge.text = "Charges: " + gameState.player2_charge.ToString();
		p3charge.text = "Charges: " + gameState.player3_charge.ToString();
	}
}
