using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set;}
    private Blade blade;
    private FruitSpawner fruitSpawner;
    public Text scoreText;
    public Button tryAgainButton;
    private int score;
    private void Awake() {
        if(Instance == null)
            Instance = this;
        else
            DestroyImmediate(gameObject);
        blade = FindObjectOfType<Blade>();
        fruitSpawner = FindObjectOfType<FruitSpawner>();
    }
    private void Start() {
        NewGame();
    }
    public void NewGame()
    {
        blade.enabled = true;
        fruitSpawner.enabled = true;
        score = 0;
        scoreText.text = score.ToString();
        tryAgainButton.gameObject.SetActive(false);
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void Explode()
    {
        blade.enabled = false;
        fruitSpawner.enabled = false;
        tryAgainButton.gameObject.SetActive(true);
    }
}
