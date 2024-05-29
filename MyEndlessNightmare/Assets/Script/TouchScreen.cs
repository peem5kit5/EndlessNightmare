using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    bool isMovingLeft = false;
    bool isMovingRight = false;
    PLayerController player;
    // Start is called before the first frame update
    public Animator CamAnim;
    public Animator LightAnim;

    private void Start()
    {
        player = FindObjectOfType<PLayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x < Screen.width / 2 && touch.position.y > Screen.height / 3)
            {
                isMovingLeft = true;
                isMovingRight = false;
                player.moveSpeed = 20;
            }
            else if (touch.position.x > Screen.width / 2 && touch.position.y > Screen.height / 3)
            {
                isMovingRight = true;
                isMovingLeft = false;
                player.moveSpeed = 20;
            }
            else if (touch.position.y < Screen.height/ 3)
            {
                player.moveSpeed = 40;
                CamAnim.Play("WatchBack");
                LightAnim.Play("LightBack");
            }
        }
        else
        {
            player.moveSpeed = 20;
            isMovingRight = false;
            isMovingLeft = false;
            CamAnim.Play("CameraWalk");
            LightAnim.Play("LightWalk");
        }
    }
    private void FixedUpdate()
    {
        if (isMovingLeft && !isMovingRight)
        {
            player.LeftButton();
            CamAnim.Play("Left");
            LightAnim.Play("LightLeft");
        }
        else if (isMovingRight && !isMovingLeft)
        {
           player.RightButton();
            CamAnim.Play("Right");
            LightAnim.Play("LightRight");
        }
    }
}
