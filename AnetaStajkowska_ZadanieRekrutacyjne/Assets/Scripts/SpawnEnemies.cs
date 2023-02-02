using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnEnemies : MonoBehaviour
{
    public int EnemiesNumber;
    public GameObject Spawnable;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < EnemiesNumber; i++)
        {
            Instantiate(Spawnable);
        }
        yield return new WaitForSeconds(1);
        Debug.Log("Spawn");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
