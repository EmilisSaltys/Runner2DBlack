using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controler : MonoBehaviour
{

    private Vector2 targetPos;
    public float MaxHight;
    public float MinHight;
    public int health = 3;
   
    void Start()
    {
        
    }


    void Update()
    {

        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
        

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxHight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + 3);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > MinHight )
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 3);
            transform.position = targetPos;
        }

    }
}
