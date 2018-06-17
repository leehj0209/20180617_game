using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform muzzle;
    private float spped = 1000;
    [SerializeField]
    private Texture2D cursor;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
	}
	
	// Update is called once per frame
	void Update () {
        // 
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    void Shot ()
    {
        // 弾丸の複製
        GameObject bullets = GameObject.Instantiate(bullet) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.forward * spped;

        // Rigidbodyに力を加えて発射
        bullets.GetComponent<Rigidbody>().AddForce(force);
        // 弾丸の位置を調整
        bullets.transform.position = muzzle.position;

        Destroy(bullets, 3.0f);
    }
}
