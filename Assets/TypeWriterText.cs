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
    void Awake() {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";
        audioS = GetComponent<AudioSource>();
        // TODO: add optional delay when to start
        StartCoroutine("PlayText");
        
    }

    IEnumerator PlayText() {
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
    }

}
