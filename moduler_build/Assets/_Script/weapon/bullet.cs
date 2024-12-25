using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    bool cnbedestroyed;
    private void Update()
    {
        StartCoroutine(bulletdistroyer());

        if(cnbedestroyed)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator bulletdistroyer()
    {
        yield return new WaitForSeconds(2);
        cnbedestroyed = true;
    }
}
