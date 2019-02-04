using UnityEngine;

public class PlayerCollision : MonoBehaviour
    
{
    public Playermovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "opstacle")
        {
            GetComponent<Playermovement>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
