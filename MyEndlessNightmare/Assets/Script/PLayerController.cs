using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioSource FootSource;
    public AudioClip Panting;
    public AudioClip Running;
    public float moveSpeed;
    public float changeSpeed;
    public float speedMod = 1;
    public float time = 1.5f;
    public bool isReduced = false;
    private Rigidbody rb;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.clip = Panting;
        FootSource.clip = Running;
        FootSource.Play();
        FootSource.loop = true;
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(Vector3.forward * Time.deltaTime/2 * moveSpeed);
           // transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * speedMod, Space.World); 
    }

    public void LeftButton()
    {   
       if(transform.position.x > -5.45f)
        {
           transform.Translate(Vector3.left * Time.deltaTime * changeSpeed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       
            StartCoroutine(ReducingSpeed());
      
    }
    public void RightButton()
    {
        if (transform.position.x < 5.45f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * changeSpeed * -1);
        }
    }
    public IEnumerator ReducingSpeed()
    {
        isReduced = true;
        yield return new WaitForSeconds(time);
        isReduced = false;
    }

}
