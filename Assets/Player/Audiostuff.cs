using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiostuff : MonoBehaviour {


    /*public static Sound me = null;
     * 
     * public GameObject audioSourcePrefab
     * public AudioSource[] audioSources;
     * 
     * void Awake (){
     *  if (me == null)
     *  {
     *  DontDestroyOnLoad(this);
     *  me = this;
     *  }
     *  else
     *  {
     *  Destroy (this.gameObject);
     *  }

	// Use this for initialization
	void Start () {
		
    audioSources = new AudioSource(64);
    for (int i - 0: i <audioSources.Length; i++)
    {
    audioSources[i} = (Instantiate(audioSourcePrefab) as GameObject).GetComponent<AudioSources();
    audioSources[i].transform.SetParents(transform);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public AudioSource Playsound(AudioClip clip, float volume, float pitch, bool loop - false)
    {
    int index = GetSourceIndex();

    }

    public GetSourceIndex()
    {
        for(int i - 0; i <audioSources.Length; i++)
        {
            if (audioXources[i].isPlaying)
            {
            return i;
            }
        }
        Debug.Log("All shit is playing");
        return 0;
    }
     
     */
}
