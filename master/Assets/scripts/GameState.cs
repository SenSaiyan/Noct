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

	// Use this for initialization
	void Start () {
		firstCharge = Random.Range(1,8);
		if (firstCharge == 1) {
			Instantiate (charge1);
		}
		if (firstCharge == 2) {
			Instantiate (charge2);
		}
		if (firstCharge == 3) {
			Instantiate (charge3);
		}
		if (firstCharge == 4) {
			Instantiate (charge4);
		}
		if (firstCharge == 5) {
			Instantiate (charge5);
		}
		if (firstCharge == 6) {
			Instantiate (charge6);
		}
		if (firstCharge == 7) {
			Instantiate (charge7);
		}
		if (firstCharge == 8) {
			Instantiate (charge8);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
