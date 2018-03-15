using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
		GameObject keyPoof = (GameObject) Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
        // Call the Unlock() method on the Door
		door.Unlock();
        // Set the Key Collected Variable to true

        // Destroy the key.
		Destroy(gameObject);
    }

}
