using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingCar : MonoBehaviour
{
        public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public AudioClip engineSound;
    public AudioClip doorSound;
    public AudioClip hoodSound;
    public AudioClip headlightsSound;

    private bool isDoorOpen = false;
    private bool isHoodOpen = false;
    private bool isHeadlightsOn = false;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = engineSound;
        audioSource.loop = true;
        audioSource.Play();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleDoor();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ToggleHood();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleHeadlights();
        }
    }

    void ToggleDoor()
    {
        isDoorOpen = !isDoorOpen;

        if (isDoorOpen)
        {
            audioSource.PlayOneShot(doorSound);
            // Open door code here
        }
        else
        {
            audioSource.PlayOneShot(doorSound);
            // Close door code here
        }
    }

    void ToggleHood()
    {
        isHoodOpen = !isHoodOpen;

        if (isHoodOpen)
        {
            audioSource.PlayOneShot(hoodSound);
            // Open hood code here
        }
        else
        {
            audioSource.PlayOneShot(hoodSound);
            // Close hood code here
        }
    }

    void ToggleHeadlights()
    {
        isHeadlightsOn = !isHeadlightsOn;

        if (isHeadlightsOn)
        {
            audioSource.PlayOneShot(headlightsSound);
            // Turn on headlights code here
        }
        else
        {
            audioSource.PlayOneShot(headlightsSound);
            // Turn off headlights code here
        }
    }
}