using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public  Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }   
    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) *speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }
    public void SetCountText()
    {
        countText.text = count.ToString();
        if(count >= 9)
        {
            winText.text = "You Win!";
        }
    }
    
}
