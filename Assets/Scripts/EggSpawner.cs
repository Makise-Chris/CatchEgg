using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject egg;
    [SerializeField]
    private float cooldown;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            float x = Random.Range(-2.5f, 2.5f);
            Vector2 spawnPoint = new Vector2(x, 6);
            Instantiate(egg, spawnPoint, Quaternion.identity);
            timer = cooldown;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
