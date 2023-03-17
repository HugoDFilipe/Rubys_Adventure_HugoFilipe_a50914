using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
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

        position.y = position.y + 0.1f* vertical;
        position.x = position.x + 0.1f* horizontal;
        transform.position = position;
    }
}
