using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockPanel : MonoBehaviour
{
    void Update()
    {
        // blocks information enablers 

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
        Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit raycastHit;

            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Ablock")) Apanel.SetActive(true);
                if (raycastHit.collider.CompareTag("Bblock")) Bpanel.SetActive(true);    
                if (raycastHit.collider.CompareTag("Cblock")) Cpanel.SetActive(true);
                if (raycastHit.collider.CompareTag("Eblock")) Epanel.SetActive(true);
                
                if (raycastHit.collider.CompareTag("hostel")) Debug.Log("hostel");
                if (raycastHit.collider.CompareTag("Canteen")) Debug.Log("Canteen");    
                if (raycastHit.collider.CompareTag("Workshop")) Debug.Log("Workshop");
                if (raycastHit.collider.CompareTag("BookBank")) Debug.Log("BookBank"); 
                if (raycastHit.collider.CompareTag("MusicRoom")) Debug.Log("MusicRoom");    
                if (raycastHit.collider.CompareTag("TennisRoom")) Debug.Log("TennisRoom");                
                if (raycastHit.collider.CompareTag("SportsRoom")) Debug.Log("SportsRoom");      
            }
        }
    }

// Panels turning off
public GameObject Apanel, Bpanel, Cpanel, Epanel;
    public void ApanelOff(){ Apanel.SetActive(false); }
    public void BpanelOff(){ Bpanel.SetActive(false); }
    public void CpanelOff(){ Cpanel.SetActive(false); }
    public void EpanelOff(){ Epanel.SetActive(false); }
    
    
// pointers
    public GameObject A, B, C, Hostel, Parking, Workshop, BookBank, Canteen, Tennis, Sports, Music;

    // pointer menu toggle
    public GameObject pmenu;
    int pm=1;
    public void pointerMenu()
    {   
        pmenu.SetActive(true);
        if(pm%2 == 0)
            pmenu.SetActive(false);
        pm++;
    }

    // Pointer enablers
    int ap=1;int bp=1;int cp=1;int hosp=1; int parp=1;int worp=1;
    int bbp=1;int canp=1;int tenp=1;int musp=1;int spop=1;
    public void Ap() 
    { 
        A.SetActive(true);
        if(ap%2 == 0)
            A.SetActive(false);
        ap++;
    }
    public void Bp() 
    { 
        B.SetActive(true);
        if(bp%2 == 0)
            B.SetActive(false);
        bp++;
    }
    public void Cp() 
    { 
        C.SetActive(true);
        if(cp%2 == 0)
            C.SetActive(false);
        cp++;
    }
    public void HosP() 
    { 
        Hostel.SetActive(true);
        if(hosp%2 == 0)
            Hostel.SetActive(false);
        hosp++;
    }
    public void Parkp() 
    { 
        Parking.SetActive(true);
        if(parp%2 == 0)
            Parking.SetActive(false);
        parp++;
    }
    public void Workp() 
    { 
        Workshop.SetActive(true);
        if(worp%2 == 0)
            Workshop.SetActive(false);
        worp++;
    }
    public void Bookp() 
    { 
        BookBank.SetActive(true);
        if(bbp%2 == 0)
            BookBank.SetActive(false);
        bbp++;
    }
    public void Canp() 
    { 
        Canteen.SetActive(true);
        if(canp%2 == 0)
            Canteen.SetActive(false);
        canp++;
    }
    public void Tenp() 
    { 
        Tennis.SetActive(true);
        if(tenp%2 == 0)
            Tennis.SetActive(false);
        tenp++;
    }
    public void Musp() 
    { 
        Music.SetActive(true);
        if(musp%2 == 0)
            Music.SetActive(false);
        musp++;
    }
    public void Spop() 
    { 
        Sports.SetActive(true);
        if(spop%2 == 0)
            Sports.SetActive(false);
        spop++;
    }
}