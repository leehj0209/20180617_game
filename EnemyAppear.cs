using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAppear : MonoBehaviour {

    [SerializeField]
    GameObject[] enemys;

    [SerializeField]
    float appearNextTime;

    [SerializeField]
    int maxNumEnemys;

    private int numberEnemy;
    private float elapsedTime;

	// Use this for initialization
	void Start () {
        numberEnemy = 0;
        elapsedTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (numberEnemy > maxNumEnemys)
        {
            return;
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime > appearNextTime)
        {
            elapsedTime = 0f;
            AppearEnemy();
        }
	}

    void AppearEnemy()
    {
        var randomValue = Random.Range(0, enemys.Length);
        var randomRotationY = Random.value * 360f;

        GameObject.Instantiate(enemys[randomValue], transform.position, Quaternion.Euler(0f, randomRotationY, 0f));

        numberEnemy++;
        elapsedTime = 0f;
    }
}
