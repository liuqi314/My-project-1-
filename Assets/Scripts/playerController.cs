using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class playerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameoverScreen2 gameover;  // Reference to the Gameover script
    public GameWin GameWin; // Reference to the GameWin script

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
        gameover.gameObject.SetActive(false); // Initially hide the Gameover screen
        GameWin = FindObjectOfType<GameWin>();

        if (GameWin == null ) 
        {
            Debug.LogError("GameWin object not found or not assigned.");
        
        }
        else 
        { 
        
            GameWin.gameObject.SetActive(false);
        
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
        audioManager.PlaySFX(audioManager.wallhit);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >=90)
        {
            GameWin.gameObject.SetActive(true);

            // Pass the score to the GameWin script
            GameWin.Setup(count);
            audioManager.PlaySFX(audioManager.win);

        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick up3"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
            audioManager.PlaySFX(audioManager.pickup);
        }

         
    }
   
    private bool gameEnded = false;

    void Update()
    {
        if (transform.position.y < -10)  // change the Y threshold as needed
        {
            EndGame();
        
        }


    }

    void EndGame()
    {
         if (!gameEnded)
        {
             gameEnded = true;

            // Pass the score to the Gameover script
            gameover.Setup(count);
            audioManager.PlaySFX(audioManager.death);
        }
    
    
    

    }



}




