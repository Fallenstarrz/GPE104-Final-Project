using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_FloatingScore : MonoBehaviour
{
    public float destroyAfter;
    public float speed;

    // On start, destroy after X seconds
    void Start ()
    {
        Destroy(gameObject, destroyAfter);
	}
    // Once per frame: move upwards X per second
    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
