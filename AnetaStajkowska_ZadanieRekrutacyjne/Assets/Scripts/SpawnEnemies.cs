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
            yield return new WaitForSeconds(5);
            GameObject child = Instantiate(Spawnable, transform.position, Quaternion.identity);
            child.transform.SetParent(transform);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
