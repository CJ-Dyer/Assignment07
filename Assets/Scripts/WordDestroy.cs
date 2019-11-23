using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDestroy : MonoBehaviour
{
    public static int wordsMissed = 0;

    void Update()
    {
        if (transform.position.y <= -62)
        {
            Destroy(gameObject);
            wordsMissed++;
        }
    }
}
