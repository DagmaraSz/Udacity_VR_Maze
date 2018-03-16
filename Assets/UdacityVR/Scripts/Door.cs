using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	private AudioSource _doorSounds;
	public AudioClip doorClosedSound, doorOpenSound;

	bool locked = true, opening = false;

	void Start() {
		_doorSounds = GetComponent<AudioSource> ();
	}

    void Update() {
		if (opening && transform.position.y < 7.5f) {
			transform.Translate (0, 2.1f * Time.deltaTime, 0, Space.World);
		}
    }

    public void OnDoorClicked() {
		if (!locked) {
			opening = true;
			_doorSounds.PlayOneShot (doorOpenSound, 1);
		}
		else {
			_doorSounds.PlayOneShot (doorClosedSound, 1);
		}
    }

    public void Unlock()
    {
			locked = false;
    }
}
