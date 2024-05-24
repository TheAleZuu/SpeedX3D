using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class moverCubo : MonoBehaviour {
    // void Start() {}

    void Update() {
        // if (transform.position.x <= 0) {
        //     Vector3 initialPos = new (transform.position.x + 50, transform.position.y + 0, transform.position.z + 0);
        //     transform.position = initialPos;
        // } else {
            // float speed = 10;
            // float movPos = -Time.deltaTime * speed;
            // transform.Translate(movPos, 0, 0);
        // }
        float speed = 5f;
        Vector3 mov = new (transform.position.x, 0, 0);
        transform.position = transform.position - speed * Time.deltaTime * mov;
    }
}
