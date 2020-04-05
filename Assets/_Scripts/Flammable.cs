using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flammable : MonoBehaviour {

    // MAKE ALL TAGS CAPITALIZED !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    public GameObject Fire;
    public GameObject CurrentTile;
    public float Delay;
    private bool Collided;

    void Start()
    {
        Collided = false;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider has left");
        Collided = false;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(Delay);
        Collided = true;
        this.Destroy();
    }

    private void Destroy()
    {
        if (Collided == true)
        {
            Instantiate(Fire, transform.position, transform.rotation);
            Destroy(gameObject);
            Collided = false;
        }
    }
}
