using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        //starts the player with 0 seeds planted and 5 available; updates UI to match
        _numSeedsPlanted = 0; 
        _numSeedsLeft = _numSeeds;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        //allows player movement
        if(Input.GetKey (KeyCode.UpArrow) || (Input.GetKey (KeyCode.W)))

	{
		_playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
	}
	
	else if(Input.GetKey (KeyCode.DownArrow) || (Input.GetKey (KeyCode.S)))

	{
		_playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
	}
	
	else if(Input.GetKey (KeyCode.LeftArrow) || (Input.GetKey (KeyCode.A)))

	{
		_playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
	}

	else if(Input.GetKey (KeyCode.RightArrow) || (Input.GetKey (KeyCode.D)))

	{
		_playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
	}

    PlantSeed ();
    _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

    }

    
    public void PlantSeed ()
    {
        //plants sprout at players position, updates variables tracking values
        if(Input.GetKeyDown (KeyCode.Space))
        {
            if(_numSeedsLeft > 0)
            {
                _numSeedsLeft -= 1;
                _numSeedsPlanted += 1;
                Instantiate(_plantPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
