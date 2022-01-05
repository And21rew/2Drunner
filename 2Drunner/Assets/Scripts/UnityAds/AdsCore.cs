using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdsCore : MonoBehaviour
{
    [SerializeField] private bool _testMode = true;

    private string _gameId = "4528543";

    private string _video = "Interstitial_Android";
    private string _banner = "Banner_Android";

    void Start()
    {
        Advertisement.Banner.Hide(false);
        Advertisement.Initialize(_gameId, _testMode);

        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    public void ShowAd()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show(_video);
        }
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
            Advertisement.Banner.Show(_banner);
    }

    private void OnDestroy()
    {
        Advertisement.Banner.Hide(true);
    }
}
