using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject keyPoofPrefab;
	public Door door;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
		GameObject keyPoof = (GameObject) Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
		door.Unlock();
		Destroy(gameObject);
    }

}
