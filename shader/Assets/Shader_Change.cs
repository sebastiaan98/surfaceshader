using UnityEngine;
using System.Collections;

public class Shader_Change : MonoBehaviour
{
    
    public Shader shader1;
    public Shader shader2;
   
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Example/Slices");
        shader2 = Shader.Find("slet/Custom Vertex Data");
    
    }
    void Update()
    {

        
            if (Input.GetButtonDown("Jump"))
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else
                rend.material.shader = shader1;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectable")
        {

            Debug.Log("jokojij");
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else {
                rend.material.shader = shader1;
            }
            


           
        
        }

    }
}