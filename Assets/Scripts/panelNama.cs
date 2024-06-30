using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using TMPro; 

public class panelNama : MonoBehaviour
{
    [Header("Nama Landmark")]
    public TrackableAR[] tr;
    public string[] nama;

    [Header("UI Nama")]
    public TextMeshProUGUI txtNama;

    public GameObject goNama;
    public bool[] cekMarker;
    int countMarker;

    void Start(){

        cekMarker = new bool[tr.Length];

    }

    void Update(){

        for(int i=0; i<tr.Length; i++){

            if(tr[i].GetMarker()){
                txtNama.text =  nama[i];

                if(!cekMarker[i]){
                    countMarker++;
                    cekMarker[i] = true;
                }
            }

            else {
                if(cekMarker[i]){
                    countMarker--;
                    cekMarker[i] = false;
                }

            }
        }
        namaLandmark();
    }

    private void namaLandmark(){

        if(countMarker == 0){
            goNama.SetActive(false);

        }

        else{
            goNama.SetActive(true);
        }

    }

}
