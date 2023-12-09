using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuFunctions : MonoBehaviour
{
    public GameObject player;
    public GameObject mainMenu;
    public Shapeshift ss;
    public PlayerProgress pp;
    public PlayerMove pm;

    public int coins;
    public Text coinsText;

    public Text personalBest;
    public int pb;

    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
        pb = PlayerPrefs.GetInt("pb");
        personalBest.text = (pb.ToString());

        ss = player.GetComponent<Shapeshift>();
        pp = player.GetComponent<PlayerProgress>();
        pm = player.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        mainMenu.SetActive(true);
        coins += pp.score;
        coinsText.text = coins.ToString();
        PlayerPrefs.SetInt("coins", coins);
        if (pp.score > pb)
        {
            pb = pp.score;
            personalBest.text = (pb.ToString());
            PlayerPrefs.SetInt("pb", pb);
        }

        pp.score = 0;
        pp.scoreText.text = "00";
        pp.deathScreen.SetActive(false);
        pp.deathScreen2.SetActive(false);
        pp.deathCount = 0;
        pp.spawnDistance = -40;

        player.GetComponent<Transform>().transform.position = new Vector3(0,0,0);
        pp.died = false;
        pm.playerSpeed = 2;

        ss.forms[0].SetActive(true);
        ss.currentForm = 0;
        ss.dead = false;
        ss.death.SetActive(false);

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject go in cubes)
        {
            go.SetActive(false);
        }
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Sphere");
        foreach (GameObject go in spheres)
        {
            go.SetActive(false);
        }
        GameObject[] triangles = GameObject.FindGameObjectsWithTag("Triangle");
        foreach (GameObject go in triangles)
        {
            go.SetActive(false);
        }
    }
}
