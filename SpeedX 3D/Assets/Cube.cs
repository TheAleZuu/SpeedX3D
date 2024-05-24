using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour {
    private void CubeDefault() {
        Instantiate(cubePrefab, new Vector3(1, 1, 1), new Quaternion(0, 0, 0, 0));
    }
    
    public GameObject cubePrefab;
    public int cubes = 20;
    public float radius = 4f;

    // public GameObject Cube(Clone);
    // ObjectManager.GetObject()

    void Start() {
        // for (int i = 0; i < cubes; i++) {
        //     float angle = i * Mathf.PI * 2 / cubes;
        //     float z = Mathf.Cos(angle) * radius;
        //     float y = Mathf.Sin(angle) * radius;
        //     Vector3 pos = transform.position + new Vector3(0, y, z);
        //     float angleDegress = -angle * Mathf.Rad2Deg;
        //     Quaternion rot = Quaternion.Euler(angleDegress, 0, 0);
        //     Instantiate(cubePrefab, pos, rot);
        // }
        // Debug.Log(cubePrefab);
        // Invoke("CubeDefault", 5);
        // Quaternion q = Quaternion.identity;
        // q.Set(0, 0, 0, 0);
    }

    void Update() {
        for (int i = 1; i <= cubes; i++) {
            cubePrefab = GameObject.Find("Cube" + i);
            float speed = 1f;
            float movPos = Time.deltaTime * speed;
            Vector3 initialPos = new (0, -cubePrefab.transform.position.z, cubePrefab.transform.position.y);
            // initialPos.Normalize();
            if (cubePrefab.transform.position.y >= 0) {
                if (cubePrefab.transform.position.z > 0) {
                    cubePrefab.transform.position = cubePrefab.transform.position + initialPos * movPos;
                } else if (cubePrefab.transform.position.z < 0) {
                    cubePrefab.transform.position = cubePrefab.transform.position - initialPos * movPos;
                }
            }
            // Quaternion rot = new (cubePrefab.transform.rotation.x - movPos, 0, 0, cubePrefab.transform.rotation.w);
            // cubePrefab.transform.rotation = rot;
        }
    }
}
