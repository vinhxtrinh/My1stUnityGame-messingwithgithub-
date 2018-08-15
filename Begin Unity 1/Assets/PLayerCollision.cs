using UnityEngine;

public class PLayerCollision : MonoBehaviour {

    public PlayerMovement movement;
   

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit the cube young man ");
            movement.enabled = false;         
        }     
    }
}
