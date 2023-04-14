using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoadLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadLevel()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("NextScene");
       
        while (!asyncLoad.isDone)
        {
            _slider.value = asyncLoad.progress;
            _text.text = asyncLoad.progress.ToString();
           yield return null;
        }


    }
}
