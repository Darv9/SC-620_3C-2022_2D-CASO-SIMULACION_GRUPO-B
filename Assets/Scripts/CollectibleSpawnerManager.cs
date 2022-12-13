using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawnerManager : MonoBehaviour
{
    public List<GameObject> collectiblesToSpawn;
    public List<Transform> spawnPoints;
    private int randomSpawnPoint;
    private int randomCollectible;
    public List<Transform> OldSpawnPoints;
    private int prefabLifeTime = (int)90.0f;


    void Update()
    {
        //Se invoca el metodo para que ocurra cada 45 segundos
        Invoke("SpawnAtRandom", 45F);
    }

    void SpawnAtRandom()
    {
        //Se define el punto random y el coleccionable random que va a hacer spawn
        randomSpawnPoint = Random.Range(0, spawnPoints.Count);
        randomCollectible = Random.Range(0, collectiblesToSpawn.Count);


        //Se verifica que no haya otro coleccionable en el mismo punto
        if (!OldSpawnPoints.Contains(spawnPoints[randomSpawnPoint]))
        {
            Transform OldSpawn = spawnPoints[randomSpawnPoint];
            OldSpawnPoints.Add(OldSpawn);
            //Se destruye el coleccionable que hizo spawn despues de 90 segundos de vida
            Destroy(Instantiate(collectiblesToSpawn[randomCollectible], spawnPoints[randomSpawnPoint].transform), prefabLifeTime) ;
            OldSpawnPoints.Clear();
        }
        CancelInvoke();
    }

    public GameObject GetObject(int index)
    {
        GameObject indexObject = collectiblesToSpawn[index];
        return indexObject;
    }
}
