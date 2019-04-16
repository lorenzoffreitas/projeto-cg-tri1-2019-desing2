using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilespawn : MonoBehaviour
{

    GameObject parent;
    public GameObject prefab;
    public GameObject spawnpoint;
    public float waitTime = 3f;
    public float projectilespeed = 3f;
    public Vector3[] directions;



    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Tape");
        StartCoroutine(Spawn());
    }

            IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            for (int i = 0; i<directions.Length; i++)
            {
                GameObject projectile = Instantiate(prefab, spawnpoint.transform.position, Quaternion.identity);
                projectile.transform.SetParent(parent.transform);
                projectile.GetComponent<Rigidbody2D>().velocity = projectilespeed * directions[i];



            }


        }


    }
}
