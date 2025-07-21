using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    public GameObject MainCamera;
    bool jumping = false; 
    bool floating = false;
    public int health;
    int player_height;
    public Slider HPGauge;

    void Start()
    {
        health = 100;
        player_height = 10;

        if (HPGauge != null)
        {
            HPGauge.value = health;
        }
    }

    void Update() 
    {
        MainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        
        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(2.0f, 0.0f, 0.0f);
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(-2.0f, 0.0f, 0.0f);
        }
        //Spaceキー（ジャンプ）
        if (Input.GetKey(KeyCode.Space))
        {
            if (jumping == false && floating == false)
            {
                Rigidbody rb = this.GetComponent<Rigidbody>();
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 5, rb.linearVelocity.z);
                jumping = true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stageline10"))
        {
            SceneManager.LoadScene("Start");
        }
    }
    void OnCollisionEnter(Collision collision) //落下ダメージの判定
    {
        int height_diff = 0;
        int damage=0;
        if (collision.gameObject.CompareTag("stageline1"))
        {
            height_diff = player_height - 10;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if(damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 10;
        }
        else if (collision.gameObject.CompareTag("stageline2"))
        {
            Debug.Log("2段目");
            height_diff = player_height - 9;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 9;
        }
        else if (collision.gameObject.CompareTag("stageline3"))
        {
            height_diff = player_height - 8;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 8;
        }
        else if (collision.gameObject.CompareTag("stageline4"))
        {
            height_diff = player_height - 7;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 7;
        }
        else if (collision.gameObject.CompareTag("stageline5"))
        {
            height_diff = player_height - 6;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 6;
        }
        else if (collision.gameObject.CompareTag("stageline6"))
        {
            height_diff = player_height - 5;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 5;
        }
        else if (collision.gameObject.CompareTag("stageline7"))
        {
            height_diff = player_height - 4;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 4;
        }
        else if (collision.gameObject.CompareTag("stageline8"))
        {
            height_diff = player_height - 3;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 3;
        }
        else if (collision.gameObject.CompareTag("stageline9"))
        {
            height_diff = player_height - 2;
            damage = height_diff * 30 - 30;
            if (jumping)
            {
                damage = damage + 15;
            }
            if (damage > 0)
            {
                health = health - damage;
            }
            jumping = false;
            player_height = 2;
        }
        if (HPGauge != null)
        {
            HPGauge.value = health;
        }

        floating = false;
        Debug.Log(damage);
        if (health < 0) //死亡時処理
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    void OnCollisionExit(Collision collision) //空中ジャンプの禁止
    {
        bool singlejump = (collision.gameObject.CompareTag("stageline1") || collision.gameObject.CompareTag("stageline2") || collision.gameObject.CompareTag("stageline3") || collision.gameObject.CompareTag("stageline4") || collision.gameObject.CompareTag("stageline5") || collision.gameObject.CompareTag("stageline6") || collision.gameObject.CompareTag("stageline7") || collision.gameObject.CompareTag("stageline8") || collision.gameObject.CompareTag("stageline9")||collision.gameObject.CompareTag("wall"));
        
        if(singlejump)
        {
            floating = true;
        }

    }
}
