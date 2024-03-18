using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    private void Awake()
    {
        instance = this;
    }

    public GameObject[] wallGroupPrefabs;
    public Transform wallGroupSpawnPosition;
    public int fallenBrickAmount, fallenBrickNeeded;

    public event Action setAmmo;

    public TextMeshProUGUI levelText;
    public static int level = 1;

    private void Start()
    {
        SpawnWallGroup(UnityEngine.Random.Range(0, wallGroupPrefabs.Length));
        levelText.text = "Level: " + level;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RestartGame();
        }
    }


    public void SetAmmo()
    {
        setAmmo?.Invoke();
    }

    void SpawnWallGroup(int wallGroupIndex)
    {
        Instantiate(wallGroupPrefabs[wallGroupIndex], wallGroupSpawnPosition.position, Quaternion.identity);
    }

    public void BrickFall()
    {
        fallenBrickAmount++;
        if (fallenBrickAmount >= fallenBrickNeeded)
        {
            level++;
            RestartGame();
            print("You Win");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
