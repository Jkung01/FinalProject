using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public int speed =1;
    public int xMove =1;
    void Start ()
{

}

    void Update()
    {
    RaycastHit2D hit=Physics2D.Raycast(transform.position,new Vector2(xMove,0));
    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMove,0)*speed;
    if (hit.distance<1f)
    {
    Flip();
   if (hit.collider.tag=="Player")
        {
            print("die");
            SceneManager.LoadScene(5);
        }
    }
    void Flip()
    {

        if (xMove>0)
        { 
            xMove = -1;
        }
        else
        {
            xMove = 1;
        }
    }
    }
}

    
    
    
