using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameClearUI;
    public GameObject gameOverUI;

    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if( isGameClear != true ){
            if( DestroyAllBlocks())
            {
                //ゲームクリア
                Debug.Log("ゲームクリア");
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }
    }

    // ブロックが全て破壊されているかの判定
    private bool DestroyAllBlocks()
    {
        foreach ( Block b in blocks)
        {
            if( b != null)
            {
                return false;
            }
        }
        return true;
    }
    public void GameOver()
    {
        foreach ( Block b in blocks)
        {
            if( b != null)
            {
                Debug.Log("ゲームオーバー");
                gameOverUI.SetActive(true);
            }
        }
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
