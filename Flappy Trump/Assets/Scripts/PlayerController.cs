using UnityEngine;

public class PlayerController : MonoBehaviour {

public float flapForce;
private Rigidbody2D rB; // Rigidbody2D
public bool isGameOver; 
public bool isStart;
public int playerScore;


	// Use this for initialization
	void Start () {
		rB = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && !isGameOver) {
			if(!isStart) {
				isStart = true;
				rB.gravityScale = 1;
			}
			Flap();
		}
	}

	void Flap() {
		rB.velocity = Vector2.zero;
		rB.AddForce(new Vector2(0, flapForce));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "DeathZone") {
			isGameOver = true;
		}
		if(other.tag == "ScoreZone") {
			playerScore++;
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if(other.transform.tag == "DeathZone") {
			isGameOver = true;
		}
	}




} // End Class
