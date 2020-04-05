using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpread : MonoBehaviour {

    public float speed;

    void Start()
    {

    }

    void Update()
    {
        while (transform.localScale.x < 7)
        {
            gameObject.transform.localScale += new Vector3(speed, speed, 0f);
        }
    }

}
