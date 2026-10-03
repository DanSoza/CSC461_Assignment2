using UnityEngine;

public class ExhibitProximity : MonoBehaviour
{
    public GameObject infoPanel;
    public AudioSource engineSound;

    void Start() { if (infoPanel) infoPanel.SetActive(false); }

    void OnTriggerEnter(Collider o)
    {
        if (!o.CompareTag("Player")) return;
        if (infoPanel) infoPanel.SetActive(true);
        if (engineSound) engineSound.Play();
    }

    void OnTriggerExit(Collider o)
    {
        if (!o.CompareTag("Player")) return;
        if (infoPanel) infoPanel.SetActive(false);
        if (engineSound) engineSound.Stop();
    }
}