using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class WW_MobileVersion : MonoBehaviour {

    [Space]

    public bool _loadScene;
    public string _pc;
    public string _mobile;

    [Space]
    [Space]
    [Space]

    public bool ifMobileActive;
    
    [Header("Active - True")]
    public GameObject[] objsTrue;

    [Header("Active - False")]
    public GameObject[] objsFalse;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    string platform;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    void Awake(){

        platform = Application.platform.ToString();

        if ( _loadScene ){

            if ( platform != RuntimePlatform.IPhonePlayer.ToString() && platform != RuntimePlatform.Android.ToString() ){ SceneManager.LoadScene( _pc ); }
            else { SceneManager.LoadScene( _mobile ); }

        }

        if ( ifMobileActive ){ for ( int i=0; i<objsTrue.Length; i++ ){ objsTrue[ i ].SetActive( true ); } }
        if ( ifMobileActive ){ for ( int i=0; i<objsFalse.Length; i++ ){ objsFalse[ i ].SetActive( false ); } }

    }

}