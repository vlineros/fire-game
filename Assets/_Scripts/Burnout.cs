using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burnout : MonoBehaviour {

    public float fireBurn;
    public GameObject Burned;

    // Use this for initialization
    void Start () {
        //GetComponent of collider on this object
        fireBurn -= Time.deltaTime;
        if (fireBurn < 0)
        {
            //shrink collider to next to nothing!
            Instantiate(Burned, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		//move collider based on wind
	}
}
