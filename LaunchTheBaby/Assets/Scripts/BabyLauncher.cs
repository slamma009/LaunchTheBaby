using UnityEngine;
using System.Collections;

public class BabyLauncher : MonoBehaviour {
    public Rigidbody Baby;
    public float Force = 1.0f;
	// Use this for initialization
	void Start () {
        Baby.AddForce(new Vector3(1, 1, 0).normalized * Force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
