using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies; //enemies array field.
 
    //whenever the game level is enable
    private void OnEnable()
    {
        //saving the enemies
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        //loop each enemy and run the code for that enemy
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
                return; 
        }

        Debug.Log("You killed all enemies");
        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
