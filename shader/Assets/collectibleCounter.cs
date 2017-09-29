using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class collectibleCounter : MonoBehaviour
{
	public Text counterText;
    public Shader shader1;
    public Shader shader2;
    public Shader shader3;
    public Renderer rend;
    private int numberOfCollectablesInScene;
	private int numberOfCollectablesCollected;
	private AudioSource audioSource;



	void start()
	{
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Example/Slices");
        shader2 = Shader.Find("slet/Custom Vertex Data");
        shader3 = Shader.Find("Example/Detail");

        audioSource = GetComponent<AudioSource>();
		numberOfCollectablesCollected = 0;
		GameObject[] collectables = GameObject.FindGameObjectsWithTag ("Collectable");
		numberOfCollectablesInScene = collectables.Length;
	
	}

    void Update()
    {


        if (Input.GetButtonDown("Jump"))
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else
                rend.material.shader = shader1;
    }

	void OnTriggerEnter (Collider other)
	{

       
        if (rend.material.shader == shader1)
            rend.material.shader = shader2;
        else
            rend.material.shader = shader1;
    

    

        if (other.transform.tag == "Collectable") {
			numberOfCollectablesCollected++;
			//audioSource.Play();
			Destroy (other.gameObject);

		
			if (numberOfCollectablesCollected >= numberOfCollectablesInScene) {
				Debug.Log ("you win");
			}
		}
	}

	
}
