using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	private Quaternion targetRotation;
	private CharacterController player;

	public float vel = 450;
	public float velWalk = 5;
	public float velRun = 10;

	void Start () {
		player = GetComponent<CharacterController> ();
	
	}

	void Update () {
		var input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		var motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1)?.7f:1;
		motion *= (Input.GetButton ("Run")) ? velRun : velWalk;
		motion += Vector3.up * -1000;
			
		player.Move (motion * Time.deltaTime);
	
	}
}
