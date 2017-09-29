using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectibleCounter : MonoBehaviour
{
    public Text counterText;

    private int numberOfCollectablesInScene;
    private int numberOfCollectablesCollected;
    private AudioSource audioSource;

    void start()
    {
        audioSource = GetComponent<AudioSource>();
        numberOfCollectablesCollected = 0;
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
        numberOfCollectablesInScene = collectables.Length;
        UpdateCollectableUI();
    }
    void OnTriggerEnter(Collider other)
    {


        if (other.transform.tag == "Collectable")
        {
            numberOfCollectablesCollected++;
            //audioSource.Play();
            Destroy(other.gameObject);

            UpdateCollectableUI();

            if (numberOfCollectablesCollected >= numberOfCollectablesInScene)
            {
                Debug.Log("you win");
            }
        }
    }

    private void UpdateCollectableUI()
    {
        counterText.text = "Collectables: " + numberOfCollectablesCollected.ToString() + " / " + numberOfCollectablesInScene.ToString();
    }
}
