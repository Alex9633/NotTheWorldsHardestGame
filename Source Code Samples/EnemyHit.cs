using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "enemy")
        {
            FindObjectOfType<AudioManager>().Play("Hit");
            StartCoroutine(DieAndRespawn());
        }
    }

    IEnumerator DieAndRespawn()
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        transform.position = new Vector3(-10.5f, -2.5f, 0.0f);
        transform.rotation = Quaternion.identity;
        GetComponent<Renderer>().enabled = true;
    }
}

