using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody playerRigidBody;
    public Text litereColectate;
    private string litereleMele;
    static int ct = 0;
    static int ct2 = 0;
    static int ct3 = 0;

    public UnityEngine.UI.Button butonMaiJoacaOdata;
    public UnityEngine.UI.Button butonMeniu;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerRigidBody.AddForce(movement * speed * Time.deltaTime);
    }

   

    private void Start()
    {
        litereColectate.text = "Ai colectat: ";
        litereleMele = "";
        Time.timeScale = 1;
        butonMaiJoacaOdata.gameObject.SetActive(false);
        butonMeniu.gameObject.SetActive(false);
    }

    void methodJ(Collider j)
    {
        Debug.Log("Am colectat litera J!");
        j.gameObject.SetActive(false);
        litereleMele = litereleMele + " " + "'"+ j.gameObject.GetComponent<TextMeshPro>().text + "'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 1;
        ct3++;
    }
    void methodO(Collider o) 
    {
        Debug.Log("Am colectat litera O!");
        o.gameObject.SetActive(false);
        litereleMele = litereleMele + " " + "'" + o.gameObject.GetComponent<TextMeshPro>().text + "'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 2;
        ct3++;
    }
    void methodC(Collider c) 
    {
        Debug.Log("Am colectat litera C!");
        c.gameObject.SetActive(false);
        litereleMele = litereleMele + " "+ "'" + c.gameObject.GetComponent<TextMeshPro>().text + "'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 3;
        ct3++;
    }
    void methodTURS(Collider t_urs)
    {
        Debug.Log("Am colectat textul URS!");
        t_urs.gameObject.SetActive(false);
        litereleMele = litereleMele + " textul " + "'" + t_urs.gameObject.GetComponent<TextMeshPro>().text.ToUpper() + "'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 4;
        ct3++;
    }
    void methodTLUP(Collider t_lup) 
    {
        Debug.Log("Am colectat textul LUP!");
        t_lup.gameObject.SetActive(false);
        litereleMele = litereleMele  + " textul " + "'" + t_lup.gameObject.GetComponent<TextMeshPro>().text.ToUpper() + "'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 5;
        ct3++;
    }
    void methodURS(Collider urs) 
    {
        Debug.Log("Am colectat URSUL!");
        urs.gameObject.SetActive(false);
        litereleMele = litereleMele + " obiectul 'URS'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 6;
        ct2++;
        ct3++;
    }
    void methodLUP(Collider lup) 
    {
        Debug.Log("Am colectat LUPUL!");
        lup.gameObject.SetActive(false);
        litereleMele = litereleMele + " obiectul 'LUP'";
        litereColectate.text = "Ai colectat: " + litereleMele;
        ct = 7;
        ct2++;
        ct3++;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "J" && ct == 0)
        {
            methodJ(other);
        }
        else if (other.gameObject.tag == "J")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3  + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
        
        }


        if (other.gameObject.tag == "O" && ct == 1)
        {
            methodO(other);
        }
        else if (other.gameObject.tag == "O")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
      
        }


        if (other.gameObject.tag == "C" && ct == 2)
        {
            methodC(other);
        }
        else if (other.gameObject.tag == "C")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
       
        }

        if (other.gameObject.tag == "Text_URS" && (ct == 3 || ct == 7))
        {
            methodTURS(other);
        }
        else if (other.gameObject.tag == "Text_URS")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
       
        }

        if (other.gameObject.tag == "Text_LUP" && (ct == 3 || ct == 6))
        {
            methodTLUP(other);
        }
        else if (other.gameObject.tag == "Text_LUP")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
         
        }

        if (other.gameObject.tag == "URS" && ct == 4)
        {
            methodURS(other);
        }
        else if (other.gameObject.tag == "URS")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
           Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
         
        }

        if (other.gameObject.tag == "LUP" && ct == 5)
        {
            methodLUP(other);
        }
        else if (other.gameObject.tag == "LUP")
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Ai greșit ordinea, mai încearcă!" + " | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
            
        }
        if ((ct == 7 || ct==6) && ct2 > 1)
       
        {
            butonMaiJoacaOdata.gameObject.SetActive(true);
            butonMaiJoacaOdata.GetComponentInChildren<Text>().text = "Try Again";
            butonMeniu.gameObject.SetActive(true);
            butonMeniu.GetComponentInChildren<Text>().text = "Meniu";
            litereColectate.text = "Felicitări! Ai colectat tot!  | Scor final: " + ct3 + "/7 |";
            Time.timeScale = 0;
            ct2 = 0;
            ct = 0;
            ct3 = 0;
           
        }
    }

}

