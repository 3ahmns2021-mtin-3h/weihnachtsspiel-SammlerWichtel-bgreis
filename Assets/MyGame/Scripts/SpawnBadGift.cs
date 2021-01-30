using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnBadGift : MonoBehaviour
{

    public GameObject badgiftPrefab;
    public GameObject parentDamageSpawnGo;

    public float nextSpawn = 4.0f;
    public float spawnRate = 3.0f;

    void Start()
    {
        BadGiftSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            BadGiftSpawner();
        }
    }

    private void BadGiftSpawner()
    {
        var clones = Instantiate(badgiftPrefab);
        clones.GetComponent<Transform>().SetParent(parentDamageSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
    }
}