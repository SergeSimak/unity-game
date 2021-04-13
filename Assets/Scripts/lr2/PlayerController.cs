using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public new Rigidbody rigidbody2D;
    [SerializeField] private Text Coins;
    [SerializeField] private Text PlayerName;
    public int _coins = 0;
    public static string playerName;
    PlayerData playerData = new PlayerData();

    private void Start()
    {
        MainMenu mainMenu = new MainMenu();
        PlayerName.text = playerName;
    }

    // Update is called once per frame
    //void FixedUpdate()
    //{
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        //rigidbody2D.DOMoveX(-4, 2);
    //        rigidbody2D.velocity = new Vector2(-4, rigidbody2D.velocity.y);
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        //rigidbody2D.DOMoveX(4, 2);
    //        rigidbody2D.velocity = new Vector2(4, rigidbody2D.velocity.y);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        //rigidbody2D.DOMoveY(10, 2);
    //        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 14f);
    //    }
    //}
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Coins")
        {
            Destroy(collision.gameObject);
            _coins += 1;
            playerData.PlayerCoins = _coins;
               Coins.text = _coins.ToString();
        }
        if (collision.gameObject.tag == "Trap")
        {
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene(0);
        }
    }

}
