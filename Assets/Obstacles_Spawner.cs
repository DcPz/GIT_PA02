using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Spawner : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject Ice;
    public GameObject Tire;
    public GameObject Walrus;

    public float minX = -4f;
    public float maxX = 4f;
    public float minY = -4f;
    public float maxY = 4f;
    public float minZ = -1f;
    public float maxZ = 1f;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = WaitAndSpawn(1.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            transform.position = new Vector3(Random.Range(minX, maxX),Random.Range(minY, maxY),Random.Range(minZ, maxZ));
            Instantiate(Barrel, transform.position, transform.rotation);

            yield return new WaitForSeconds(waitTime);

            Instantiate(Ice, transform.position + (transform.forward * 10), transform.rotation);

            yield return new WaitForSeconds(waitTime);

            Instantiate(Tire, transform.position + (transform.forward * 10), transform.rotation);

            yield return new WaitForSeconds(waitTime);

            Instantiate(Walrus, transform.position + (transform.forward * 10), transform.rotation);
        }
    }
}
