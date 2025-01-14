using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        //after the variables are assigned the correct value through the parameters; 
        //the text is then assigned that same value and updated;
        _plantedText.text = " " + seedsLeft;
        _remainingText.text = " " + seedsPlanted;
    }
}