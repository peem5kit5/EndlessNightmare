using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    public float moveSpeed;
    public GameObject RespawnUI;
    private Rigidbody rb;
    private AudioSource audioSource;
    public AudioClip demonSound;
    public AudioClip Ahh;
    public AudioSource PlayerSource;
    public AudioSource FootSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = demonSound;
        
        RespawnUI.SetActive(false);
        rb = GetComponent<Rigidbody>();
        audioSource.Play();
        audioSource.loop = true;

    }

    // Update is called once per frame
    void Update()
    {
       
        rb.AddForce(Vector3.forward * Time.deltaTime/2 * moveSpeed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.clip = Ahh;
            audioSource.Play();
            audioSource.loop = false;
            Time.timeScale = 0;
            RespawnUI.SetActive(true);
            FootSource.Stop();
            PlayerSource.Stop();
        }
    }
}
