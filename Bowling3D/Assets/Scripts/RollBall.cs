using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RollBall : MonoBehaviour
{

    [SerializeField]
    private GameObject ball;
    float force = 100.0f;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
   
    // Update is called once per frame
    void Update()
    {

         if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            
            if(hit.collider.gameObject.name == "Ball")
            {
                ball.GetComponent<Rigidbody>().AddTorque(new Vector3(100,0,0) * force * 100 * Time.deltaTime);
                
            }

           

        }


    }
}
