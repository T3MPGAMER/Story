using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Collision : MonoBehaviour
{
    
    public Text Speech;
    public Text Hint;
    public string A = "Omg Omg, frank what the hell happened to you!!! Please anyone HELPPPPP! There must be some clues as to what happened arround here";
    public string B = "I wonder what this letter says        Letter:I will get you frank this will be the end of you. How dare you steal from me this buisness is mine you theving... I Will have your head.                Player : I wonder who that could be from there must be somthing here about who the other founder are";
    public string C = "Right lets see here, founders founders oh there it is.   ledger: Brothers in Law Frank Asop and Benjamin Bishop Co-founded CE Industrys signing a life long company contract together There must be more clues";
    public string D = "Blood!! This must have fingerprints on. I think its time to involve the police";
    public string E = "Find the letter ";
    public string F = "Try to find the ledger";
    public string G = "Look for one more clue";
    public string H = "Exit through the door to get help";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "DeadBody")
        {

            {
                Speech.text = A;
                Hint.text = E;
            }
        }
        else if (col.gameObject.tag == "Letter")
        {

            {
                Speech.text = B;
                Hint.text = F;
               
            }
        }
         else if (col.gameObject.tag == "Book")
        {

            {
              
                Speech.text = C;
                Hint.text = G;
            }
        }
        else if (col.gameObject.tag == "Poker")
        {

            {
               
                Speech.text = D;
                Hint.text = H;
            }
        }
        else if (col.gameObject.tag == "Door")
        {

            {

                SceneManager.LoadScene("Start");
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }
}
