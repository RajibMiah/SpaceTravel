using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeWriterText : MonoBehaviour
{
    Text txt;
    string story;
    public float waiting = 0.125f;
    private AudioSource audioS;
    private string[] planetInfo;
    public float waitForNextParagraph = 3f;
    private int paragraphnumber = 0;
    void Awake() {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";
        audioS = GetComponent<AudioSource>();
        // TODO: add optional delay when to start
        StartCoroutine("PlayText");
        
    }

    IEnumerator PlayText() {
        txt.text = "";
        if (audioS != null && !audioS.enabled) {
            audioS.enabled = true;
        }
        foreach (char c in story) {
            txt.text += c;
            yield return new WaitForSeconds(waiting);
        }
        if(audioS != null && audioS.enabled) {
            audioS.enabled = false;
        }
        if(planetInfo.Length - 1>= paragraphnumber) {
            paragraphnumber++;
            story = planetInfo[paragraphnumber];
            yield return new WaitForSeconds(waitForNextParagraph);
            StartCoroutine("PlayText");
        }
    }

    public void SetNewInfoText(string[] newPlanetInfo) {
        paragraphnumber = -1;
        planetInfo = newPlanetInfo;
        story = planetInfo[0];
        StartCoroutine("PlayText");
    }
}
