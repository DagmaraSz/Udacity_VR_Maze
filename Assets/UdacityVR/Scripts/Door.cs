using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	private AudioSource _doorSounds;
	public AudioClip doorClosedSound;
	public AudioClip doorOpenSound;

	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	bool locked = true, opening = false;

	void Start() {
		_doorSounds = GetComponent<AudioSource> ();
	}

    void Update() {
        // If the door is opening and it is not fully raised
		if (opening && transform.position.y < 7.5f) {
			// Animate the door raising up
			transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if (!locked) {
			// Set the "opening" boolean to true
			opening = true;
			_doorSounds.PlayOneShot (doorOpenSound, 1);
        // (optionally) Else
		}
		else {
            // Play a sound to indicate the door is locked
			_doorSounds.PlayOneShot (doorClosedSound, 1);
		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
			locked = false;
    }
}
