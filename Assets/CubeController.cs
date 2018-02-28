using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	//音源を宣言
	public AudioClip block;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);

		}

	}

	//Lesson7の課題
	void OnCollisionEnter2D(Collision2D Collision) {

		if (Collision.gameObject.tag == "blockTag" || Collision.gameObject.tag == "BG_02Tag") {
			
			//音を鳴らす	
			GetComponent<AudioSource> ().PlayOneShot(block);

			//AudioSourceController.instance.PlayOneShot(block);
			//Debug.Log ("hit!");

		}

	}


}
