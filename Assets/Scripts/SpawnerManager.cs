using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject prefabEnemy;
    public List<Transform> spawnPoints;
    private int randomSpawnPoint;
    public List<Transform> OldSpawnPoints;
    private int prefabLifeTime = 7;


    void Update()
    {
        //Se invoca el metodo para que ocurra cada 0.5 segundos
        Invoke("SpawnAtRandom", 8);
    }

    void SpawnAtRandom()
    {
        //Se define el spawn point random
        randomSpawnPoint = Random.Range(0, spawnPoints.Count);


        //Se verifica que no haya otro enemigo en el mismo spawn point
        if (!OldSpawnPoints.Contains(spawnPoints[randomSpawnPoint]))
        {
            Transform OldSpawn = spawnPoints[randomSpawnPoint];
            OldSpawnPoints.Add(OldSpawn);
            //Se destruye el enemigo despues de 2 segundos
            Destroy(Instantiate(prefabEnemy, spawnPoints[randomSpawnPoint].transform), prefabLifeTime);
            OldSpawnPoints.Clear();
        }
        CancelInvoke();
    }

}
