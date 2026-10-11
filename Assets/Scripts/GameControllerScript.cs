using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public int itemCollected = 0;
    public TextMeshProUGUI itemCountText;
    public int totalItems = 0;
    public GameObject winPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Collectible").Length;
        winPanel.SetActive(false);
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateUI()
    {
        itemCountText.text = "Items Collected: " + itemCollected + "/" + totalItems;
    }

    public void CollectItem()
    {
        itemCollected++;
        UpdateUI();

        if (itemCollected >= totalItems)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        winPanel.SetActive(true);
    }   
}
