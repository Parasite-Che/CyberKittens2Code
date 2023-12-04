using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class GlobalAudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] listOfMusic;
    [SerializeField] private AudioSource audioPlayer;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
        listOfMusic = Resources.LoadAll<AudioClip>("Audio/Music");
        StartCoroutine(PlayMusic());
    }

    IEnumerator PlayMusic()
    {
        audioPlayer.clip = listOfMusic[Random.Range(0, listOfMusic.Length)];
        audioPlayer.Play();
        while (true)
        {
            yield return new WaitForSeconds(audioPlayer.clip.length+0.2f);
            audioPlayer.Stop();
            audioPlayer.clip = ChooseNextTrack(audioPlayer.clip);
            audioPlayer.Play();
        }
    }

    AudioClip ChooseNextTrack(AudioClip clip)
    {
        int prevInd=0;
        int newInd=0;
        for(int i=0; i < listOfMusic.Length; i++)
        {
            if (listOfMusic[i] == clip)
            {
                prevInd = i;
                break;
            }
        }

        do
        {
            newInd = Random.Range(0, listOfMusic.Length);
        } while (newInd == prevInd);

        return listOfMusic[newInd];
    }
}
