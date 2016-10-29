using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BabyLauncher : MonoBehaviour {
    public Rigidbody Baby;
    public float Force = 1.0f;
	// Use this for initialization
	void Start () {
        Transform parent = Baby.transform.parent;
        while(parent.parent != null)
        {
            parent = parent.parent;
        }

        parent.rotation = Random.rotation;

        var children = GetAllRigidChildren(Baby.transform);

        foreach(var child in children)
        {
            child.AddForce(new Vector3(1, 1, 0).normalized * Force);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public List<Rigidbody> GetAllRigidChildren(Transform start)
    {
        List<Rigidbody> children = new List<Rigidbody>();
        Rigidbody rigid = start.GetComponent<Rigidbody>();
        if (rigid != null)
        {
            children.Add(rigid);
        }
        foreach (Transform child in start)
        {
            children.AddRange(GetAllRigidChildren(child));
        }

        return children;
    }
}
