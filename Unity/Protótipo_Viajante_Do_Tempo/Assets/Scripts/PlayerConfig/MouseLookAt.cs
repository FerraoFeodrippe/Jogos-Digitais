using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class MouseLookAt : MonoBehaviour {



	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		var posPlayer = Camera.main.WorldToScreenPoint(transform.position);
		var posMouse = Input.mousePosition;
		var direcao = posMouse - posPlayer;
	
		var angle = Mathf.Atan2(direcao.x, direcao.y) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.up);	
	}
}
