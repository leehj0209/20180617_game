using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletAttack : MonoBehaviour {

    [SerializeField]
    private GameObject exploadObj;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Instantiate(exploadObj, col.gameObject.transform.position, Quaternion.identity);
            FindObjectOfType<EnemyCount>().Count();
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
