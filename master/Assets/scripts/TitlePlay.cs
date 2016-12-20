using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Rewired;

public class TitlePlay : MonoBehaviour {
	public MovieTexture movTexture;

	public int playerId;
	private Player player;

	private bool b1;
	private bool b2;
	private bool b3;
	private bool b4;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage>().texture = movTexture as MovieTexture;
		movTexture.loop = true;
		movTexture.Play();

		player = ReInput.players.GetPlayer(playerId);
	}
	
	// Update is called once per frame
	void Update () {
		b1 = player.GetButtonDown ("Button1");
		b2 = player.GetButtonDown ("Button2");
		b3 = player.GetButtonDown ("Button3");
		b4 = player.GetButtonDown ("Button4");
		if (b1 || b2 || b3 || b4) {
			PlayLoading ();
		}
	}

	void PlayLoading() {
		Application.LoadLevel("Loading");
	}
}
