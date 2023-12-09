using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TheClaw : MonoBehaviour
{
    public int skinsUnlocked;
    public int skinToUnlock;
    public Sprite[] portraits;
    public Image reward;
    public Button clawButton;

    public GameObject claw;
    public Animator anim;
    public Sprite[] unlocks;
    public GameObject unlockObject;
    public Image unlockImage;

    public int cost;
    public Text costText;
    public Text coinsText;
    public MenuFunctions mf;

    public GameObject repeated;
    public Text repeatedText;

    public bool creeperUnlocked;
    public Button creeperButton;
    public bool legoUnlocked;
    public Button legoButton;
    public bool bobUnlocked;
    public Button bobButton;
    public bool villagerUnlocked;
    public Button villagerButton;
    public bool slimeUnlocked;
    public Button slimeButton;
    public bool jackUnlocked;
    public Button jackButton;
    public bool fallUnlocked;
    public Button fallButton;
    public bool amongUnlocked;
    public Button amongButton;
    public bool homerUnlocked;
    public Button homerButton;
    public bool beanUnlocked;
    public Button beanButton;
    public bool planktonUnlocked;
    public Button planktonButton;
    public bool angryUnlocked;
    public Button angryButton;
    public bool billUnlocked;
    public Button billButton;
    public bool benderUnlocked;
    public Button benderButton;
    public bool frutaUnlocked;
    public Button frutaButton;

    // Start is called before the first frame update
    void Start()
    {
        skinsUnlocked = PlayerPrefs.GetInt("skinsUnlocked");

        creeperUnlocked = PlayerPrefsX.GetBool("creeperUnlocked");
        legoUnlocked = PlayerPrefsX.GetBool("legoUnlocked");
        bobUnlocked = PlayerPrefsX.GetBool("bobUnlocked");
        villagerUnlocked = PlayerPrefsX.GetBool("villagerUnlocked");
        slimeUnlocked = PlayerPrefsX.GetBool("slimeUnlocked");
        jackUnlocked = PlayerPrefsX.GetBool("jackUnlocked");
        fallUnlocked = PlayerPrefsX.GetBool("fallUnlocked");
        amongUnlocked = PlayerPrefsX.GetBool("amongUnlocked");
        homerUnlocked = PlayerPrefsX.GetBool("homerUnlocked");
        beanUnlocked = PlayerPrefsX.GetBool("beanUnlocked");
        planktonUnlocked = PlayerPrefsX.GetBool("planktonUnlocked");
        angryUnlocked = PlayerPrefsX.GetBool("angryUnlocked");
        billUnlocked = PlayerPrefsX.GetBool("billUnlocked");
        benderUnlocked = PlayerPrefsX.GetBool("benderUnlocked");
        frutaUnlocked = PlayerPrefsX.GetBool("frutaUnlocked");

        anim = claw.GetComponent<Animator>();
        mf = gameObject.GetComponent<MenuFunctions>();
        UpdateButtons();
    }

    // Update is called once per frame
    public void UpdateButtons()
    {
        cost = 50 + (skinsUnlocked * 10);
        costText.text = cost.ToString();
        mf.coinsText.text = mf.coins.ToString();

        coinsText.text = mf.coins.ToString();
        if(cost > mf.coins)
            clawButton.interactable = false; else clawButton.interactable = true;

        if (creeperUnlocked)
            creeperButton.interactable = true;
        if (legoUnlocked)
            legoButton.interactable = true;
        if (bobUnlocked)
            bobButton.interactable = true;
        if (villagerUnlocked)
            villagerButton.interactable = true;
        if (slimeUnlocked)
            slimeButton.interactable = true;
        if (jackUnlocked)
            jackButton.interactable = true;
        if (fallUnlocked)
            fallButton.interactable = true;
        if (amongUnlocked)
            amongButton.interactable = true;
        if (homerUnlocked)
            homerButton.interactable = true;
        if (beanUnlocked)
            beanButton.interactable = true;
        if (planktonUnlocked)
            planktonButton.interactable = true;
        if (angryUnlocked)
            angryButton.interactable = true;
        if (billUnlocked)
            billButton.interactable = true;
        if (benderUnlocked)
            benderButton.interactable = true;
        if (frutaUnlocked)
            frutaButton.interactable = true;
    }

    public void UseClaw()
    {
        StartCoroutine(ClawAnimation());
    }

    IEnumerator ClawAnimation()
    {
        reward.gameObject.SetActive(false);
        clawButton.interactable = false;
        mf.coins -= cost;
        anim.SetTrigger("ClawActive");
        skinToUnlock = Random.Range(0, 15);
        reward.sprite = portraits[skinToUnlock];
        if (skinToUnlock == 0)
        {
            if (!creeperUnlocked)
            {
                creeperUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("creeperUnlocked", creeperUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 1)
        {
            if (!legoUnlocked)
            {
                legoUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("legoUnlocked", legoUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 2)
        {
            if (!bobUnlocked)
            {
                bobUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("bobUnlocked", bobUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 9)
        {
            if (!villagerUnlocked)
            {
                villagerUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("villagerUnlocked", villagerUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 10)
        {
            if (!slimeUnlocked)
            {
                slimeUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("slimeUnlocked", slimeUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 3)
        {
            if (!jackUnlocked)
            {
                jackUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("jackUnlocked", jackUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 4)
        {
            if (!fallUnlocked)
            {
                fallUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("fallUnlocked", fallUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 5)
        {
            if (!amongUnlocked)
            {
                amongUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("amongUnlocked", amongUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 11)
        {
            if (!homerUnlocked)
            {
                homerUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("homerUnlocked", homerUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 12)
        {
            if (!beanUnlocked)
            {
                beanUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("beanUnlocked", beanUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 6)
        {
            if (!planktonUnlocked)
            {
                planktonUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("planktonUnlocked", planktonUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 7)
        {
            if (!angryUnlocked)
            {
                angryUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("angryUnlocked", angryUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 8)
        {
            if (!billUnlocked)
            {
                billUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("billUnlocked", billUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 13)
        {
            if (!benderUnlocked)
            {
                benderUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("benderUnlocked", benderUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        if (skinToUnlock == 14)
        {
            if (!frutaUnlocked)
            {
                frutaUnlocked = true;
                skinsUnlocked++;
                repeated.SetActive(false);
                repeatedText.text = "You unlocked:";
                PlayerPrefsX.SetBool("frutaUnlocked", frutaUnlocked);
            }
            else { mf.coins += cost / 2; repeated.SetActive(true); repeatedText.text = ("+ " + (cost / 2).ToString()); }
        }
        PlayerPrefs.SetInt("coins", mf.coins);
        PlayerPrefs.SetInt("skinsUnlocked", skinsUnlocked);

        yield return new WaitForSeconds(4f);
        UpdateButtons();
        unlockObject.SetActive(true);
        unlockImage.sprite = unlocks[skinToUnlock];
        //clawButton.interactable = true;
    }
}
