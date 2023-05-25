using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColumn : MonoBehaviour
{
    [SerializeField] GameObject ColumnPreFabs;
    [SerializeField] float playerSize;
    [SerializeField] float secondsBetweenSpawn;
    public float elapsedTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            //Debug.Log(transform.position.x+" "+transform.position.y);

            //Vector3 spawnPosition = new Vector3(4.71f, 0.72f, 0f);
            //GameObject newEnemy = (GameObject)Instantiate(enemyObject, spawnPosition, Quaternion.Euler (0, 0, 0));
            Vector3 colPos = transform.position;
            colPos.y -= Random.Range(1, 4);
            Instantiate(ColumnPreFabs, colPos, transform.rotation);
            colPos.y += playerSize;
            Instantiate(ColumnPreFabs, colPos, transform.rotation);
        }
    }
}
