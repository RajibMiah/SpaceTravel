using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInfos : MonoBehaviour {
    private string[] earth;
    private string[] mars;
    private string[] jupiter;
    private string[] saturn;
    private string[] uranus;
    private string[] neptune;

    public GameObject txt_PlanetInfoDescription;
    private TypeWriterText typeWriterText;

    public void SetInfoEarth() {
        earth = new string[2];
        earth[0] = "Earth is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        earth[1] = "Earth is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(earth);
    }

    public void SetInfoMars() {
        mars = new string[1];
        mars[0] = "mars is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(mars);
    }

    public void SetInfoJupiter() {
        jupiter = new string[1];
        jupiter[0] = "jupiter is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(jupiter);
    }

    public void SetInfoSaturn() {
        saturn = new string[1];
        saturn[0] = "saturn is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(saturn);
    }

    public void SetInfoUranus() {
        uranus = new string[1];
        uranus[0] = "uranus is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(uranus);
    }

    public void SetInfoNeptune() {
        neptune = new string[1];
        neptune[0] = "neptune is our home planet. Scientists believe Earth and its moon formed around the same time as the rest of the solar system. They think that was about 4.5 billion years ago. Earth is the fifth-largest planet in the solar system. Its diameter is about 8,000 miles. And Earth is the third-closest planet to the sun. Its average distance from the sun is about 93 million miles. Only Mercury and Venus are closer.";
        typeWriterText.SetNewInfoText(neptune);
    }
}


