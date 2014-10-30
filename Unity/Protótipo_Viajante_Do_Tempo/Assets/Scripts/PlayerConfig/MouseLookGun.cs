using UnityEngine;
using System.Collections;

public class MouseLookGun : MonoBehaviour {

	void Start () {
		
		
	}
	

	void Update () {
		
		var posGun = Camera.main.WorldToScreenPoint(transform.position);
		var posMouse = Input.mousePosition;
		var direcao = posMouse - posGun;
		var angle = Mathf.Atan2(direcao.x, direcao.y) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.up);	
	}
}

