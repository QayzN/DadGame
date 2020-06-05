using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > nextSpawn)
        {

            nextSpawn = Time.deltaTime + spawnRate;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
