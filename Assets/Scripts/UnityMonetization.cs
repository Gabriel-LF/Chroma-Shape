using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityMonetization : MonoBehaviour, IUnityAdsListener
{
    string GooglePlay_ID = "4062873";
    bool TestMode = false;

    string mySurfacingId = "rewardedVideo";
    string placementId = "banner";

    public GameObject player;
    public PlayerProgress pp;
    public GameObject mainMenu;
    public MenuFunctions mm;
    public TheClaw tc;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_ID, TestMode);

        pp = player.GetComponent<PlayerProgress>();
        mm = mainMenu.GetComponent<MenuFunctions>();
        tc = mainMenu.GetComponent<TheClaw>();

        while (!Advertisement.IsReady(placementId))
            yield return null;
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(placementId);
    }

    public void DisplayInterstitialAD()
    {
        Advertisement.Show();
    }

    public void DisplayVideoAD()
    {
        Advertisement.Show(mySurfacingId);
    }

    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId))
        {
            Advertisement.Show(mySurfacingId);
        }
        else
        {
            Debug.LogWarning("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.

            if (pp.deathCount <= 0)
            {
                mm.coins += 25;
                tc.UpdateButtons();
                PlayerPrefs.SetInt("coins", mm.coins);
            } 
            if (pp.deathCount == 1)
                pp.Revive();
            if (pp.deathCount >= 2)
            {
                mm.coins += pp.score;
                mm.BackToMenu();
            }
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.

            Debug.Log(" PULA A MÃE CUZÃO ");
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId)
    {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == mySurfacingId)
        {
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}
