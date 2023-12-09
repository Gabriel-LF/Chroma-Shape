using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class PlayerProgress : MonoBehaviour
{
    public Shapeshift ss;
    public int score;
    public Text scoreText;

    public float spawnDistance;
    public int obstacleToSpawn;
    public PlayerMove pm;

    public string randomTag;
    public GameObject deathScreen;
    public GameObject deathScreen2;
    public int deathCount;
    public bool invencibility;
    public GameObject countdownScreen;
    public Text countdown;

    public int doubledCoins;
    public Text regularText;
    public Text doubleText;

    public bool died;
    public AudioClip hit;
    public AudioSource ass;

    // Start is called before the first frame update
    void Start()
    {
        ss = gameObject.GetComponent<Shapeshift>();
        spawnDistance = -40;
        pm = gameObject.GetComponent<PlayerMove>();
        ass.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            if (ss.currentForm == 0)
                Up(); else { Die(); died = true; }
        }
        if (other.gameObject.tag == "Sphere")
        {
            if (ss.currentForm == 1)
                Up(); else { Die(); died = true; }
        }
        if (other.gameObject.tag == "Triangle")
        {
            if (ss.currentForm == 2)
                Up(); else { Die(); died = true; }
        }
        if (other.gameObject.GetComponent<ColorRandomizer>().myColor != ss.currentColor && !died)
            Die();
    }

    public void Up()
    {
        score++;
        scoreText.text = score.ToString();
        SpawnObstacle();
        pm.playerSpeed += 0.1f;
        ass.clip = hit;
        ass.Play();
    }

    public void Die()
    {
        SpawnObstacle();
        if (!invencibility)
        {
            pm.itHasBegun = false;
            ss.dead = true;
            deathCount++;
            if(deathCount == 1)
                deathScreen.SetActive(true);
            if (deathCount >= 2)
            {
                deathScreen2.SetActive(true);
                doubledCoins = score * 2;
                regularText.text = score.ToString();
                doubleText.text = doubledCoins.ToString();
            }
        }
    }

    public void SpawnObstacle()
    {
        RandomizeObstacle();
        //Instantiate(prefabs[obstacleToSpawn], new Vector3(0, spawnDistance, 0), Quaternion.Euler(90, 0, 0));
        ObjectPooler.Instance.SpawnFromPool(randomTag, new Vector3(0, spawnDistance, 0), Quaternion.Euler(90, 0, 0));
        spawnDistance -= ((score / 2) + 10);
    }

    public void RandomizeObstacle()
    {
        obstacleToSpawn = Random.Range(0, 3);
        if (obstacleToSpawn == 0)
            randomTag = "Cube";
        if (obstacleToSpawn == 1)
            randomTag = "Sphere";
        if (obstacleToSpawn == 2)
            randomTag = "Triangle";
    }

    public void Revive()
    {
        deathScreen.SetActive(false);
        ss.forms[0].SetActive(true);
        ss.currentForm = 0;
        ss.dead = false;
        ss.death.SetActive(false);
        ss.currentColor = 2;
        ss.ChangeColor();
        StartCoroutine("Countdown");
        died = false;
    }
    IEnumerator Countdown()
    {
        pm.itHasBegun = true;
        invencibility = true;
        countdownScreen.SetActive(true);
        countdown.text = "3";
        yield return new WaitForSeconds(1);
        countdown.text = "2";
        yield return new WaitForSeconds(1);
        countdown.text = "1";
        yield return new WaitForSeconds(1);
        countdownScreen.SetActive(false);
        invencibility = false;
    }
}
