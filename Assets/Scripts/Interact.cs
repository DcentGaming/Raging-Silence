using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject tagArea;
    public GameObject interactableMarker;
    public GameObject interactText;
    public GameObject grafittiTag;
    bool interactable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && interactable == true)
        {
            Debug.Log("Grafitiied");
            interactableMarker.SetActive(false);
            interactText.SetActive(false);
            grafittiTag.SetActive(true);
            interactable = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            tagArea = other.gameObject;
            interactableMarker = tagArea.transform.GetChild(0).gameObject;
            interactText = tagArea.transform.GetChild(1).gameObject;
            grafittiTag = tagArea.transform.GetChild(2).gameObject;
            interactText.SetActive(true);
            interactable = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            interactText.SetActive(false);
            interactableMarker = null;
            interactText = null;
            grafittiTag = null;
            tagArea = null;
            interactable = false;
        }
    }
}
