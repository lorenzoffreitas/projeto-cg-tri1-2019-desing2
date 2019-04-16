using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwoPoints : MonoBehaviour
{

    public GameObject obj;
    public Transform pos1, pos2;
    public float waitTime = 0.5f;
    public float speed = 2f;
    Vector3 nextpos;


    void Start()
    {
        nextpos = pos1.localPosition;
        StartCoroutine(Move());

    }

        IEnumerator Move()
    {

        while (true)
        {
            if (obj.transform.localPosition == pos1.localPosition)
            {

                nextpos = pos2.localPosition;
                yield return new WaitForSeconds(waitTime);

            }

            if (obj.transform.localPosition == pos2.localPosition)
            {
                nextpos = pos1.localPosition;
                yield return new WaitForSeconds(waitTime);

            }

            obj.transform.localPosition = Vector3.MoveTowards(obj.transform.localPosition, nextpos, speed * Time.deltaTime);
            yield return null;

        }


    }
   
    void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);


    }
}