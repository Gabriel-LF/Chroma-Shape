using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class CustomMenu : MonoBehaviour
{
    public string cubeEquiped;
    public string sphereEquiped;
    public string triangleEquiped;
    public GameObject player;

    public Image cubeImg;
    public Image sphereImg;
    public Image triangleImg;
    public string cubeName;
    public string sphereName;
    public string triangleName;
    public Text cubeTxt;
    public Text sphereTxt;
    public Text triangleTxt;
    public Sprite[] portraits;

    // Start is called before the first frame update
    void Start()
    {
        cubeEquiped = PlayerPrefs.GetString("cubeEquiped");
        sphereEquiped = PlayerPrefs.GetString("sphereEquiped");
        triangleEquiped = PlayerPrefs.GetString("triangleEquiped");

        if (cubeEquiped == "default")
            CEquipDefault();
        if (sphereEquiped == "default")
            SEquipDefault();
        if (triangleEquiped == "default")
            TEquipDefault();
        if (cubeEquiped == "creeper")
            CEquipCreeper();
        if (cubeEquiped == "lego")
            CEquipLego();
        if (cubeEquiped == "bob")
            CEquipBob();
        if (cubeEquiped == "villager")
            CEquipVillager();
        if (cubeEquiped == "slime")
            CEquipSlime();
        if (sphereEquiped == "jack")
            SEquipJack();
        if (sphereEquiped == "fall")
            SEquipFall();
        if (sphereEquiped == "among")
            SEquipAmong();
        if (sphereEquiped == "homer")
            SEquipHomer();
        if (sphereEquiped == "bean")
            SEquipBean();
        if (triangleEquiped == "plankton")
            TEquipPlankton();
        if (triangleEquiped == "angry")
            TEquipAngry();
        if (triangleEquiped == "bill")
            TEquipBill();
        if (triangleEquiped == "bender")
            TEquipBender();
        if (triangleEquiped == "fruta")
            TEquipFruta();
    }

    // Update is called once per frame
    public void UpdateSkins()
    {
        player.SetActive(false);
        player.SetActive(true);

        cubeTxt.text = cubeName;
        sphereTxt.text = sphereName;
        triangleTxt.text = triangleName;

        PlayerPrefs.SetString("cubeEquiped", cubeEquiped);
        PlayerPrefs.SetString("sphereEquiped", sphereEquiped);
        PlayerPrefs.SetString("triangleEquiped", triangleEquiped);
    }

    public void CEquipDefault()
    {
        cubeEquiped = "default";
        cubeName = "Cube";
        cubeImg.sprite = portraits[0];
        UpdateSkins();
    }
    public void CEquipCreeper()
    {
        cubeEquiped = "creeper";
        cubeName = "Oh..Man";
        cubeImg.sprite = portraits[1];
        UpdateSkins();
    }
    public void CEquipLego()
    {
        cubeEquiped = "lego";
        cubeName = "Nice Guy";
        cubeImg.sprite = portraits[2];
        UpdateSkins();
    }
    public void CEquipBob()
    {
        cubeEquiped = "bob";
        cubeName = "Mr Sponge";
        cubeImg.sprite = portraits[3];
        UpdateSkins();
    }
    public void CEquipVillager()
    {
        cubeEquiped = "villager";
        cubeName = "Huuum";
        cubeImg.sprite = portraits[12];
        UpdateSkins();
    }
    public void CEquipSlime()
    {
        cubeEquiped = "slime";
        cubeName = "Slime";
        cubeImg.sprite = portraits[13];
        UpdateSkins();
    }

    public void SEquipDefault()
    {
        sphereEquiped = "default";
        sphereName = "Sphere";
        sphereImg.sprite = portraits[4];
        UpdateSkins();
    }
    public void SEquipJack()
    {
        sphereEquiped = "jack";
        sphereName = "Jack";
        sphereImg.sprite = portraits[5];
        UpdateSkins();
    }
    public void SEquipFall()
    {
        sphereEquiped = "fall";
        sphereName = "Fall Boy";
        sphereImg.sprite = portraits[6];
        UpdateSkins();
    }
    public void SEquipAmong()
    {
        sphereEquiped = "among";
        sphereName = "Impostor";
        sphereImg.sprite = portraits[7];
        UpdateSkins();
    }
    public void SEquipHomer()
    {
        sphereEquiped = "homer";
        sphereName = "Boomer";
        sphereImg.sprite = portraits[14];
        UpdateSkins();
    }
    public void SEquipBean()
    {
        sphereEquiped = "bean";
        sphereName = "Bean";
        sphereImg.sprite = portraits[15];
        UpdateSkins();
    }

    public void TEquipDefault()
    {
        triangleEquiped = "default";
        triangleName = "Pyramid";
        triangleImg.sprite = portraits[8];
        UpdateSkins();
    }
    public void TEquipPlankton()
    {
        triangleEquiped = "plankton";
        triangleName = "Mr Evil";
        triangleImg.sprite = portraits[9];
        UpdateSkins();
    }
    public void TEquipAngry()
    {
        triangleEquiped = "angry";
        triangleName = "Fast Bird";
        triangleImg.sprite = portraits[10];
        UpdateSkins();
    }
    public void TEquipBill()
    {
        triangleEquiped = "bill";
        triangleName = "The Eye";
        triangleImg.sprite = portraits[11];
        UpdateSkins();
    }
    public void TEquipBender()
    {
        triangleEquiped = "bender";
        triangleName = "B. Robot";
        triangleImg.sprite = portraits[16];
        UpdateSkins();
    }
    public void TEquipFruta()
    {
        triangleEquiped = "fruta";
        triangleName = "Lord Fruta";
        triangleImg.sprite = portraits[17];
        UpdateSkins();
    }
}
