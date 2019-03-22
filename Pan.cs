// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Pan : MonoBehaviour
// {
// 	private bool getPan = false;
// 	//private Transform Banana;
// 	public Transform FryingPan;
// 	//public gameObject Banana;

// 	//public Rigidbody rbpan;



//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(getPan == true)
//         {
//         	FryingPan.position = new Vector3(Banana.position.x + 1.93f, Banana.position.y + 0.34f, Banana.position.z);

//         }
//     }

//     void OnCollisionEnter(Collision other)
//     {
//     	if (other.gameObject.tag == "platanoman") 
//     	{
//     		getPan = true;
//     	}
//     }
// }
