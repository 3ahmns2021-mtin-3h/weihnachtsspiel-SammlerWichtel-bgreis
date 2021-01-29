using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnGoodGift : MonoBehaviour
{

    public GameObject GoodGiftPrefab;
    public GameObject parentSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        GoodGiftSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            GoodGiftSpawner();
        }
    }

    private void GoodGiftSpawner()
    {
        var clones = Instantiate(GoodGiftPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
