using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExMouseButton : MonoBehaviour
{

    public int Hp = 100;
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        textUI.text = "ü��" + Hp.ToString();


        if (Input.GetMouseButtonDown(0)) 
        {
            Hp -= 10;
            Debug.Log("ü��:" + Hp);
            if (Hp < 0)
            {
                Destroy(gameObject);
            }
        } 
    }
}
