using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        
        //movimentação horizontal
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        
        //movimentação vertical
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);

        position.y = position.y + 3.0f* vertical* Time.deltaTime;
        position.x = position.x + 3.0f* horizontal* Time.deltaTime;
        transform.position = position;
    }
}
