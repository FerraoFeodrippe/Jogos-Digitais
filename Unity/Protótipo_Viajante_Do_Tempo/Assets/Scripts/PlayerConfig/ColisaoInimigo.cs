﻿using UnityEngine;
using System.Collections;

public class ColisaoInimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnParticleCollision(GameObject obj)
	{
		Destroy (obj);
		Cubos.nCubos--;
	}


}
