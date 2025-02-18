using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Codes : MonoBehaviour
{
    [SerializeField] private Sprite rostike_;
    [SerializeField] private Sprite Teo_;
    [SerializeField] private Sprite FITH;
    [SerializeField] private List<Image> bg;
    [SerializeField] private Camera cam;
    [SerializeField] private List<GameObject> Particles;
    private TMP_InputField inputField;
    private void Start()
    {
        inputField = gameObject.GetComponent<TMP_InputField>();   
    }
    private void rostike()
    {
        cam.backgroundColor = Color.gray;
        foreach (GameObject particle in Particles)
        {
            if (particle.name == "ParticlesRostike") particle.SetActive(true);
            else particle.SetActive(false);
        }
        foreach (Image image in bg)
        {
            image.sprite = rostike_;
        }
        inputField.text = null;
    }
    private void Teo()
    {
        cam.backgroundColor = Color.gray;
        foreach (GameObject particle in Particles)
        {
            if (particle.name == "Particles Teo") particle.SetActive(true);
            else particle.SetActive(false);
        }
        foreach (Image image in bg)
        {
            image.sprite = Teo_;
        }
        inputField.text = null;
    }
    private void FireITH()
    {
        cam.backgroundColor = new Color(0.3940459f, 0.7264151f, 0.4339302f);
        foreach (GameObject particle in Particles)
        {
            if (particle.name == "ParticlesFireInTheHole") particle.SetActive(true);
            else particle.SetActive(false);
        }
        foreach (Image image in bg)
        {
            image.sprite = FITH;
        }
        inputField.text = null;
    }
    public void Redeem()
    {
        if (inputField.text == "rostike_") rostike();
        else if (inputField.text == "teo") Teo();
        else if (inputField.text == "fire in the hole") FireITH();
    }
}
