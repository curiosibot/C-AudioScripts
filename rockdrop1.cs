using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockdrop1 : MonoBehaviour 
{
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
		if (collision.relativeVelocity.magnitude > 1)
			audioSource.Play();
	}
}