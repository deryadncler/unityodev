using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusmansayi : MonoBehaviour
{
    public Text enemyCountText; // UI Text eleman�
    private int enemyCount; // D��man say�s�

    private float enemycount;
    bool oyunDevam = true;
    bool oyunTamam = false;
    public Text durum;

    


    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("enemy").Length; ; // Ba�lang��ta d��man say�s�n� al
        UpdateEnemyCountText(); // Ba�lang��ta d��man say�s�n� g�ster
        
    }

    void Update()
    {
        // Her g�ncellemede d��man say�s�n� kontrol etmek i�in gerekli de�il
        // Ancak ba�ka bir yerde d��manlar�n dinamik olarak eklenip ��kar�ld��� durumlarda kullan�labilir
        int currentEnemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;
        if (currentEnemyCount != enemyCount)
        {
            enemyCount = currentEnemyCount;
            UpdateEnemyCountText(); // D��man say�s�n� g�ncelle
            if (enemyCount <= 0)
            {
                oyunTamam = true;
                durum.text = "Tebrikler Kazand�n�z!";
               
            }
           
        }
        
    }

    void UpdateEnemyCountText()
    {
        enemyCountText.text = "D��man Say�s�: " + enemyCount.ToString(); // UI Text eleman�nda d��man say�s�n� g�ster
    }
}
