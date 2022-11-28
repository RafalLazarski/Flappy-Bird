using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPrefabsCreator : MonoBehaviour
{
    public GameObject prefab;
    public float Timer = 2.0f;


    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0.0f)
        {
            prefab = Instantiate(prefab,
                new Vector2(11.0f, Random.Range(-2.5f, 2.5f)),
                Quaternion.identity);
            prefab.name = "PipesPrefab";

            Timer = 2.0f;
        }
    }
}
