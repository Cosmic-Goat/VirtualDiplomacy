using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    public float speed = 10f;

    public bool whenTouched = false;




    void Update() {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        if(whenTouched == true)
        {
            transform.Rotate(0, 0, 0);

        }
    }
}