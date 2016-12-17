using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {
	private bool cp0;
	private bool cp1;
	private bool cp2;
	private bool cp3;
	private bool cp4;
	public int happen;

	//places
	public int channelSpeed;
	public int channelLimit;
	public bool plate_1_on;
	public bool plate_2_on;
	public bool plate_3_on;
	public bool plate_4_on;
	public int plate_1_channel;
	public int plate_2_channel;
	public int plate_3_channel;
	public int plate_4_channel;
	public bool plate_1_done;
	public bool plate_2_done;
	public bool plate_3_done;
	public bool plate_4_done;


	// Use this for initialization
	void Start () {
		cp0 = true;
		cp1 = false;
		cp2 = false;
		cp3 = false;
		cp4 = false;
	}
	
	// Update is called once per frame
	void Update () {
		// cp0 plates to activate puzzles
		if (cp0 = true && cp1 == false) {
			plateCheck ();
			if (plate_1_done && plate_2_done && plate_3_done && plate_4_done) {
				cp1 = true;
			}
		}

		if (cp0 && cp1){
			//bool initial = true
			//if (initial = true){
			//instantiate a collider 'platefordebuff' on a random plate across the emission
			//instantiate an emmision on plate1
			//debuff a random player
			//initial = false
			}
			plateCheck();
			if (plate_1_done && plate_2_done && plate_3_done && plate_4_done && happen == 0){
				seqCheck();
			} else if (happen == 2 ){
				//do stuff in comments
			}
			happen = 0;
			//if seqCount = 4 then u cp2 is true

		}
	void plateCheck(){
		if (plate_1_on) {
			plate_1_channel += channelSpeed;
			if(plate_1_channel == channelLimit) {
				plate_1_done = true;
			}
		} else { plate_1_channel = 0; plate_1_done = false; }
		if (plate_2_on) {
			plate_2_channel += channelSpeed;
			if (plate_2_channel == channelLimit) {
				plate_2_done = true;
			}
		} else { plate_2_channel = 0; plate_2_done = false; }
		if (plate_2_on) {
			plate_2_channel += channelSpeed;
			if (plate_2_channel == channelLimit) {
				plate_2_done = true;
			}
		} else { plate_2_channel = 0; plate_2_done = false; }
		if (plate_3_on) {
			plate_3_channel += channelSpeed;
			if (plate_3_channel == channelLimit) {
				plate_3_done = true;
			}
		} else { plate_3_channel = 0; plate_3_done = false; }
		if (plate_4_on) {
			plate_4_channel += channelSpeed;
			if (plate_4_channel ==channelLimit) {
				plate_4_done = true;
			}
		} else { plate_4_channel = 0; plate_4_done = false; }
	}

	void seqCheck(){
		// if player collide with plate for debuff, seqCount += 1, happen = 2
	}
}
	