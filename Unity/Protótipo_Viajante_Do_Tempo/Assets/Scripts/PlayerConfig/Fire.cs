using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public ParticleEmitter bullet;

	// Use this for initialization
	void Start () {
		bullet.renderer.material.color = new Color (1, 0.5f, 0.5f);

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire")){
			bullet.Emit(1);
				}
	
	}
}
