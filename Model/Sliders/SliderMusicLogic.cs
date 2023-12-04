using UnityEngine;
using UnityEngine.UI;

public class SliderMusicLogic : MonoBehaviour
{
    [SerializeField] private string key;
    [SerializeField] private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        PlayerPrefs.SetFloat(key, slider.value);
    }
}