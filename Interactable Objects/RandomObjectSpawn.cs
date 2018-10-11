/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Random Object Spawn/Generation

 * Methods: Start and Spawn
 	* Start - invokes Spawn
    * Spawn - Instantiates an object randomly and spawns it
 */

using System.Collections;
using UnityEngine;

public class RandomObjectSpawn : MonoBehaviour {

    private GameManager GMS;

    //Array of Obstacle Objects
    public GameObject[] obstacles;

    //Floats to designate the time in which objects should randomly be spawning in between
    public float spawnMin = 3f;
    public float spawnMax = 10f;

    //Starts the process of Spawn
    void Start() {
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("Spawn", Random.Range(spawnMin, spawnMax), Random.Range(spawnMin, spawnMax));
    }

    void Spawn() {
        if(GMS.countdownDone == true) {
            Instantiate(obstacles[Random.Range(0, obstacles.GetLength(0))], transform.position, Quaternion.identity);
        }
    }
}