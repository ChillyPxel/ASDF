using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    int scene = 0;
    int boss  = 1;
    int character = 0;
    void Start()
    {
        boss++;
    }
    public void ChangeScene()  {
        scene++;
        SceneManager.LoadScene(scene);
    }
    public void LoadTutorial() {
        scene = 2;
        SceneManager.LoadScene(scene);
    }
    public void PlayGame() {
        scene = 3;
        SceneManager.LoadScene(scene);      
    }
     public void BegGame() {
        scene = 4;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame2() {
        scene = 5;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame3() {
        scene = 6;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame4() {
        scene = 7;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame5() {
        scene = 8;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame6() {
        scene = 9;
        SceneManager.LoadScene(scene);      
    }
     public void BegGame7() {
        scene = 10;
        SceneManager.LoadScene(scene);      
    }
     public void BegGame8() {
        scene = 11;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame9() {
        scene = 12;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame10() {
        scene = 13;
        SceneManager.LoadScene(scene);      
    }
     public void BegGame11() {
        scene = 14;
        SceneManager.LoadScene(scene);      
    }
     public void BegGame12() {
        scene = 15;
        SceneManager.LoadScene(scene);      
    }
    public void BegGame13() {
        scene = 16;
        SceneManager.LoadScene(scene);      
    }
    public void CharacterSelect() {
        scene = 17;
        SceneManager.LoadScene(scene);      
    }
    public void CharacterSelect2() {
        scene = 18;
        SceneManager.LoadScene(scene);      
    }
    public void Room1() {
        scene = 19;
        character = scene;
        SceneManager.LoadScene(scene);      
    }
    public void Room2() {
        scene = 20;
        character = scene;
        SceneManager.LoadScene(scene);      
    }
     public void Room3() {
        scene = 21;
        character = scene;
        SceneManager.LoadScene(scene);      
    }
    public void Dice() {
        if(boss >= 3) {
            SceneManager.LoadScene(74);
        }
        else{
            SceneManager.LoadScene(Random.Range(22, 32));
            boss ++;
        }
    }
    public void FightSlime() {
         scene = 32;
        SceneManager.LoadScene(scene); 
        boss++;
    }
    public void FightSlime2() {
         scene = 42;
        SceneManager.LoadScene(scene); 
    }
    public void AttackSlime() {
         scene = 52;
        SceneManager.LoadScene(scene); 
    }
    public void FleeSlime() {
         scene = 57;
        SceneManager.LoadScene(scene); 
    }
     public void TalkSlime() {
         scene = 53;
        SceneManager.LoadScene(scene); 
    }
     public void FlirtSlime() {
         scene = 54;
        SceneManager.LoadScene(scene); 
    }
     public void FlirtSlime2() {
         scene = 55;
        SceneManager.LoadScene(scene); 
    }
     public void FlirtSlime3() {
         scene = 56;
        SceneManager.LoadScene(scene); 
    }
     public void FlirtSlime4() {
        SceneManager.LoadScene(75); 
    }
     public void InsultSlime() {
         scene = 58;
        SceneManager.LoadScene(scene); 
    }
    public void JokeSlime() {
        scene = 59;
        SceneManager.LoadScene(scene);
    }
    public void FightGlobo() {
        scene = 33; 
        SceneManager.LoadScene(scene);
        boss++;
    }
    public void OptionsGlobo() {
        scene = 43; 
        SceneManager.LoadScene(scene);
    }
     public void AttackGlobo() {
        scene = 60; 
        SceneManager.LoadScene(scene);
    }
    public void TalkkGlobo() {
        scene = 61; 
        SceneManager.LoadScene(scene);
    }
     public void FlirtGlobo() {
        scene = 62; 
        SceneManager.LoadScene(scene);
    }
     public void InsultGlobo() {
        scene = 63; 
        SceneManager.LoadScene(scene);
    }
     public void JokeGlobo() {
        scene = 64; 
        SceneManager.LoadScene(scene);

    }
     public void FleeGlobo() {
        scene = 65; 
        SceneManager.LoadScene(scene);

    }
     public void FightGoblin() {
        scene = 44; 
        SceneManager.LoadScene(scene);
        boss++;
    }
    public void GoblinAttack() {
        scene = 66;
        SceneManager.LoadScene(scene);
    }
     public void GoblinTalk() {
        scene = 67;
        SceneManager.LoadScene(scene);
    }
     public void GoblinFlee() {
        scene = 68;
        SceneManager.LoadScene(scene);
    }
    public void Window1() {
        scene = 35;
        SceneManager.LoadScene(scene);
        boss++;
    }
    public void Window2() {
        scene = 45;
        SceneManager.LoadScene(scene);
    }
    public void Window3() {
        scene = 69;
        SceneManager.LoadScene(scene);
    }
    public void Window4() {
        scene = 70;
        SceneManager.LoadScene(scene);

    }
    public void Snek() {
        scene = 36;
        SceneManager.LoadScene(scene);
        boss++;
    }
    public void SnekOptions(){
        scene = 46;
        SceneManager.LoadScene(scene);
    }
    public void SnekAttack() {
        scene = 71;
        SceneManager.LoadScene(scene);
    }
    public void SnekTalk() {
        scene  = 72;
        SceneManager.LoadScene(scene);
    }
    public void SnekFlee() {
        scene = 73;
        SceneManager.LoadScene(scene);
    }
    public void Rock(){
        scene = 47;
        SceneManager.LoadScene(scene);
        boss++;
    }
    public void employee() {
        SceneManager.LoadScene(74);
    }

}
