using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject pipePrefab;
	public Transform pipeSpawn;
	public float minTime;
	public float maxTime;
	public float timer;
	public PlayerController PC;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timer <= 0  && PC.isStart == true ) {
			PipeSpwaner();
		}
		timer -= Time.deltaTime;
	}

	void PipeSpwaner() {
		Instantiate(pipePrefab, pipeSpawn.position, pipeSpawn.rotation);
		timer = Random.Range(minTime, maxTime);
	}
} // End class 
 
