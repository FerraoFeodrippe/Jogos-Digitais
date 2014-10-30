using UnityEngine;
using System.Collections;

public class Cubos : MonoBehaviour {

	public static IList cubos;
	public static volatile int nCubos;

	// Use this for initialization
	void Start () {
		cubos = new System.Collections.ArrayList ();
		nCubos = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (nCubos < 10) 
		{
			nCubos++;
			GameObject cubo = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cubo.AddComponent<Rigidbody> ();
			cubos.Add(cubo);
			var r = Random.Range (0, 255)/255.0f;
			var g = Random.Range (0, 255)/255.0f;
			var b = Random.Range (0, 255)/255.0f;
			cubo.renderer.material.color = new Color(r, g, b);
			var x = Random.Range (-6, 6);
			var z = Random.Range (-6, 6);
			var y = 0.5f;
			cubo.transform.position = (new Vector3 (x, y, z));
		}
	
	}
}
