using UnityEngine;

public class CollectibleScript : MonoBehaviour
{

    public GameControllerScript gameController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            gameController.CollectItem();
        }
    }

}
