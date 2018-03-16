using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
		GameObject coinPoof = (GameObject) Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
		Destroy(gameObject);
    }

}
