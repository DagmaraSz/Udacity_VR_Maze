using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		GameObject coinPoof = (GameObject) Instantiate(coinPoofPrefab, transform.position, transform.rotation);
        // Make sure the poof animates vertically

        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
