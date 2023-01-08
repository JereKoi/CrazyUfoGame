using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
#if UNITY_IOS
string gameId = "5109840";
#endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("5109841");
        ShowBanner();
    }

    public void PlayAd()
    {
        if (Advertisement.IsReady("Interstitial"))
        {
            Advertisement.Show("Interstitial");
        }
    }

    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner"))
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("Banner");
        }
        else
        {
            StartCoroutine(RepeatShowBanner());
        }
    }

    public void HideBanner()
    {
        Advertisement.Banner.Hide();
    }

    IEnumerator RepeatShowBanner()
    {
        yield return new WaitForSeconds(1);
        ShowBanner();
    }
}
