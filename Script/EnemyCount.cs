using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {

    [SerializeField]
    private Text countText;
    private int countInt;

	// Use this for initialization
	void Start () {
        countInt = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
	
	// Update is called once per frame
	void Update () {
        countText.text = countInt.ToString();
    }

    public void Count ()
    {
        countInt = GameObject.FindGameObjectsWithTag("Enemy").Length - 1;
    }
}
