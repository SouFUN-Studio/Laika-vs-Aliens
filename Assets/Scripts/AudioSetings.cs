using UnityEngine;
using System.Collections;

public class AudioSetings : MonoBehaviour {

    public static float volume;
    public AudioSource music;
    public void start()
    {
        Debug.Log("Volumen actual: " + volume);
        music.volume = volume;
    }
    public void setVolume()
    {
        volume = music.volume;
        Debug.Log("Volumen: " + volume);

    }
    public float getVolume()
    {
        return volume;
    }
}
