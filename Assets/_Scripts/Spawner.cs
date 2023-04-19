using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //objects to be spawned
    [SerializeField] GameObject[] fallingObjects;

    //The bounds of the box collider that is added to the Spawner object
    private Bounds bounds;

    //Spawn scaling after time
  

    // Start is called before the first frame update
    void Start()
    {
        bounds = GetComponent<BoxCollider>().bounds;
        StartCoroutine(RandomSpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnCoins()
    {
        float z = Random.Range(-bounds.extents.z, bounds.extents.z);
        float x = Random.Range(-bounds.extents.x, bounds.extents.x);
        float y = Random.Range(-bounds.extents.y, bounds.extents.y);


        GameObject coins = GameObject.Instantiate(fallingObjects[0]);
        coins.transform.position = bounds.center + new Vector3(x,y,z);
    }

    private void SpawnBombs()
    {
        float z = Random.Range(-bounds.extents.z, bounds.extents.z);
        float x = Random.Range(-bounds.extents.x, bounds.extents.x);
        float y = Random.Range(-bounds.extents.y, bounds.extents.y);


        GameObject bombs = GameObject.Instantiate(fallingObjects[1]);
        bombs.transform.position = bounds.center + new Vector3(x, y, z);
    }

    IEnumerator RandomSpawnTimer()
    {
        while(true)
        {
            SpawnCoins();
            SpawnBombs();
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }
}
