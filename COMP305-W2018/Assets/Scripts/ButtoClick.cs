using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtoClick : MonoBehaviour {

	public GameObject cBoy;

	public Sprite newSprite;
	private SpriteRenderer sRend;

	// Use this for initialization
	void Start () {

		sRend = cBoy.GetComponent<SpriteRenderer>();

	}

	void OnMouseDown()
	{
		sRend.sprite = newSprite;

	}
}
