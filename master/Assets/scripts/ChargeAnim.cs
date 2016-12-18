using UnityEngine;
using System.Collections;

public class ChargeAnim : MonoBehaviour {
	private Vector3 shake;
	// Use this for initialization
	void Start () {
		shake.x = 0f;
		shake.y = 360f;
		shake.z = 0f;
	}

	// Update is called once per frame
	void Update () {
		iTween.RotateAdd (gameObject, shake, 1);
	}
}
