using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;

public class UISceneManager : MonoBehaviour
{

    public AudioSource m_MyAudioSource;


    bool m_Play;
    bool m_ToggleChange;

    public GameObject HeadSetController;

    public GameObject first_screen;
    public GameObject second_screen;
    public GameObject third_screen;
    public GameObject audio_player;
    public GameObject categories;

    public GameObject ao_open;
    public GameObject ao_active;
    public GameObject lss_open;
    public GameObject lss_active;

    public GameObject introduction;


    public GameObject vanfrestllningar;
    public GameObject vanforestallningar_active;

    public GameObject hallucinationer;
    public GameObject hallucinationer_active;

    public GameObject miljoanpassning;
    public GameObject miljoanpassning_active;

    public GameObject ensamhet;
    public GameObject ensamhet_active;

    public GameObject kommunikation;
    public GameObject kommunikation_active;



    public GameObject tidsuppfattning;
    public GameObject tidsuppfattning_active;

    public GameObject social_berttelse;
    public GameObject social_berttelse_active;

    public GameObject miljoanpassning_lss;
    public GameObject miljoanpassning_lss_active;

    public GameObject valja_aktivitet;
    public GameObject valja_aktivitet_active;

    public GameObject plotsliga_handelser;
    public GameObject plotsliga_handelser_active;

    public GameObject wifi_on;
    public GameObject wifi_off;


    //setup media player
    public GameObject sphere_upload;
    public MediaPlayer mediaPlayer;
    public GameObject controls;
    public GameObject click_controls;

    //active menus for the back button
    public GameObject third_menu_active;
    public GameObject forth_menu_active;
    public GameObject categories_active;
    public GameObject ao_menu_active;
    public GameObject ao_menu_item_active;
    public GameObject lss_menu_active;
    public GameObject lss_menu_item_active;
    public GameObject intro_ao_active;
    public GameObject intro_lss_active;

    void HandleEvent(MediaPlayer mp, MediaPlayerEvent.EventType eventType, ErrorCode code)
    {
        if (eventType == MediaPlayerEvent.EventType.FinishedPlaying)
        {
            if (vanforestallningar_active.activeSelf)
            {

                vanforestallningar_active.SetActive(false);
                vanfrestllningar.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (hallucinationer_active.activeSelf)
            {

                hallucinationer_active.SetActive(false);
                hallucinationer.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (miljoanpassning_active.activeSelf)
            {

                miljoanpassning_active.SetActive(false);
                miljoanpassning.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }


            if (ensamhet_active.activeSelf)
            {
                ensamhet_active.SetActive(false);
                ensamhet.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }

            if (kommunikation_active.activeSelf)
            {

                kommunikation_active.SetActive(false);
                kommunikation.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (tidsuppfattning_active.activeSelf)
            {

                tidsuppfattning_active.SetActive(false);
                tidsuppfattning.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (tidsuppfattning_active.activeSelf)
            {

                tidsuppfattning_active.SetActive(false);
                tidsuppfattning.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (social_berttelse_active.activeSelf)
            {

                social_berttelse_active.SetActive(false);
                social_berttelse.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (miljoanpassning_lss_active.activeSelf)
            {

                miljoanpassning_lss_active.SetActive(false);
                miljoanpassning_lss.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (valja_aktivitet_active.activeSelf)
            {

                valja_aktivitet_active.SetActive(false);
                valja_aktivitet.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }

            if (plotsliga_handelser_active.activeSelf)
            {

                plotsliga_handelser_active.SetActive(false);
                plotsliga_handelser.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);

            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {

            Debug.Log("Error. Check internet connection!");
        }
        else
        {

            Debug.Log("imaaaaaa!");
        }


        //media player
        sphere_upload = GameObject.FindGameObjectWithTag("upload");
        mediaPlayer = sphere_upload.GetComponent<MediaPlayer>();
        controls = GameObject.FindGameObjectWithTag("controls");
        click_controls = GameObject.FindGameObjectWithTag("click_controls");


        //UI layout
        first_screen = GameObject.FindGameObjectWithTag("front");
        second_screen = GameObject.FindGameObjectWithTag("MainCanvas");
        third_screen = GameObject.FindGameObjectWithTag("third_menu");
        audio_player = GameObject.FindGameObjectWithTag("audio_player");
        categories = GameObject.FindGameObjectWithTag("categories");
        wifi_on = GameObject.FindGameObjectWithTag("wifi_on");
        wifi_off = GameObject.FindGameObjectWithTag("wifi_off");

        //Categories
        ao_open = GameObject.FindGameObjectWithTag("ao_open");
        lss_open = GameObject.FindGameObjectWithTag("lss_open");
        ao_active = GameObject.FindGameObjectWithTag("ao_active");
        lss_active = GameObject.FindGameObjectWithTag("lss_active");

        //Introduction
        introduction = GameObject.FindGameObjectWithTag("introduction");
        m_MyAudioSource = introduction.GetComponent<AudioSource>();

        //AO category
        vanfrestllningar = GameObject.FindGameObjectWithTag("Vanfrestllningar_open");
        vanforestallningar_active = GameObject.FindGameObjectWithTag("vanforestallningar_active");

        hallucinationer = GameObject.FindGameObjectWithTag("Hallucinationer_open");
        hallucinationer_active = GameObject.FindGameObjectWithTag("hallucinationer_active");

        miljoanpassning = GameObject.FindGameObjectWithTag("Miljoanpassning_open");
        miljoanpassning_active = GameObject.FindGameObjectWithTag("miljoanpassning_active");

        ensamhet = GameObject.FindGameObjectWithTag("Ensamhet_open");
        ensamhet_active = GameObject.FindGameObjectWithTag("ensamhet_active");

        kommunikation = GameObject.FindGameObjectWithTag("Kommunikation_open");
        kommunikation_active = GameObject.FindGameObjectWithTag("kommunikation_active");

        //LSS category
        tidsuppfattning = GameObject.FindGameObjectWithTag("Tidsuppfattning_open");
        tidsuppfattning_active = GameObject.FindGameObjectWithTag("tidsuppfattning_active");

        social_berttelse = GameObject.FindGameObjectWithTag("Social_berttelse_open");
        social_berttelse_active = GameObject.FindGameObjectWithTag("social_berttelse_active");

        miljoanpassning_lss = GameObject.FindGameObjectWithTag("Miljoanpassning_lss_open");
        miljoanpassning_lss_active = GameObject.FindGameObjectWithTag("miljoanpassning_lss_active");

        valja_aktivitet = GameObject.FindGameObjectWithTag("Valja_aktivitet_open");
        valja_aktivitet_active = GameObject.FindGameObjectWithTag("valja_aktivitet_active");

        plotsliga_handelser = GameObject.FindGameObjectWithTag("Plotsliga_handelser_opem");
        plotsliga_handelser_active = GameObject.FindGameObjectWithTag("plotsliga_handelser_active");


        first_screen.SetActive(true);

        controls.SetActive(false);
        click_controls.SetActive(false);
        second_screen.SetActive(false);
        third_screen.SetActive(false);
        third_screen.SetActive(false);
        audio_player.SetActive(false);
        categories.SetActive(false);

        ao_open.SetActive(false);
        lss_open.SetActive(false);
        ao_active.SetActive(false);
        lss_active.SetActive(false);

        introduction.SetActive(false);

        vanfrestllningar.SetActive(false);
        vanforestallningar_active.SetActive(false);

        hallucinationer.SetActive(false);
        hallucinationer_active.SetActive(false);

        miljoanpassning.SetActive(false);
        miljoanpassning_active.SetActive(false);

        ensamhet.SetActive(false);
        ensamhet_active.SetActive(false);

        kommunikation.SetActive(false);
        kommunikation_active.SetActive(false);


        tidsuppfattning.SetActive(false);
        tidsuppfattning_active.SetActive(false);

        social_berttelse.SetActive(false);
        social_berttelse_active.SetActive(false);

        miljoanpassning_lss.SetActive(false);
        miljoanpassning_lss_active.SetActive(false);

        valja_aktivitet.SetActive(false);
        valja_aktivitet_active.SetActive(false);

        plotsliga_handelser.SetActive(false);
        plotsliga_handelser_active.SetActive(false);

        //hide active menus for the back button
        third_menu_active.SetActive(false);
        forth_menu_active.SetActive(false);
        categories_active.SetActive(false);
        ao_menu_active.SetActive(false);
        ao_menu_item_active.SetActive(false);
        lss_menu_active.SetActive(false);
        lss_menu_item_active.SetActive(false);
        intro_ao_active.SetActive(false);
        intro_lss_active.SetActive(false);

        //hide first screen
        StartCoroutine(ExecuteAfterTime(2));
    }

    // Update is called once per frame
    void Update()
    {

         mediaPlayer.Events.AddListener(HandleEvent);
        if (vanforestallningar_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                vanforestallningar_active.SetActive(false);
                vanfrestllningar.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (hallucinationer_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                hallucinationer_active.SetActive(false);
                hallucinationer.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (miljoanpassning_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                miljoanpassning_active.SetActive(false);
                miljoanpassning.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                controls.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (ensamhet_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                ensamhet_active.SetActive(false);
                ensamhet.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (kommunikation_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                kommunikation_active.SetActive(false);
                kommunikation.SetActive(true);
                ao_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (tidsuppfattning_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                tidsuppfattning_active.SetActive(false);
                tidsuppfattning.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (tidsuppfattning_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                tidsuppfattning_active.SetActive(false);
                tidsuppfattning.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (social_berttelse_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                social_berttelse_active.SetActive(false);
                social_berttelse.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (miljoanpassning_lss_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                miljoanpassning_lss_active.SetActive(false);
                miljoanpassning_lss.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (valja_aktivitet_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                valja_aktivitet_active.SetActive(false);
                valja_aktivitet.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        if (plotsliga_handelser_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                plotsliga_handelser_active.SetActive(false);
                plotsliga_handelser.SetActive(true);
                lss_menu_item_active.SetActive(true);
                click_controls.SetActive(false);
                controls.SetActive(false);
                third_menu_active.SetActive(false);
                forth_menu_active.SetActive(false);
                categories_active.SetActive(false);
                ao_menu_active.SetActive(false);
                ao_menu_item_active.SetActive(false);
                lss_menu_active.SetActive(false);
                lss_menu_item_active.SetActive(false);
                intro_ao_active.SetActive(false);
                intro_lss_active.SetActive(false);
                bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
            }
            if (Input.GetKey(KeyCode.JoystickButton0))
            {
                controls.SetActive(true);
            }
        }

        //menu back button
        if (third_menu_active.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
             second_screen.SetActive(true);
             third_screen.SetActive(false);
             third_menu_active.SetActive(false);
         }
     }

     if (forth_menu_active.activeSelf)
     {
        if (Input.GetKey(KeyCode.Escape))
        {
            third_screen.SetActive(true);
            audio_player.SetActive(false);
            forth_menu_active.SetActive(false);
        }
    }

    if (categories_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            audio_player.SetActive(true);
            categories.SetActive(false);
            categories_active.SetActive(false);
        }
    }

    if (ao_menu_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            categories.SetActive(true);
            ao_open.SetActive(false);
            ao_menu_active.SetActive(false);
        }
    }

    if (ao_menu_item_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ao_open.SetActive(true);
            ao_menu_active.SetActive(true);
            vanfrestllningar.SetActive(false);
            hallucinationer.SetActive(false);
            miljoanpassning.SetActive(false);
            ensamhet.SetActive(false);
            kommunikation.SetActive(false);
            ao_menu_item_active.SetActive(false);
        }
    }

    if (lss_menu_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            categories.SetActive(true);
            lss_open.SetActive(false);
            lss_menu_active.SetActive(false);
        }
    }

    if (lss_menu_item_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            lss_open.SetActive(true);
            tidsuppfattning.SetActive(false);
            social_berttelse.SetActive(false);
            miljoanpassning_lss.SetActive(false);
            valja_aktivitet.SetActive(false);
            plotsliga_handelser.SetActive(false);
            lss_menu_item_active.SetActive(false);
        }
    }

    if (intro_lss_active.activeSelf)
    {
        if (Input.GetKey(KeyCode.Escape))
        {
           lss_open.SetActive(true);
           lss_active.SetActive(false);
           introduction.SetActive(false);
           intro_lss_active.SetActive(false);
       }
   }

   if (intro_ao_active.activeSelf)
   {
    if (Input.GetKey(KeyCode.Escape))
    {
        ao_open.SetActive(true);
        ao_active.SetActive(false);
        introduction.SetActive(false);
        intro_ao_active.SetActive(false);
    }
}

}

IEnumerator ExecuteAfterTime(float time)
{
    yield return new WaitForSeconds(time);
    first_screen.SetActive(false);
    second_screen.SetActive(true);
}

public void back_onboard()
{
    ao_open.SetActive(false);
    lss_open.SetActive(false);
    categories.SetActive(false);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    intro_lss_active.SetActive(false);
    second_screen.SetActive(true);
}

public void second_screen_show()
{
    second_screen.SetActive(false);
    third_screen.SetActive(true);
    third_menu_active.SetActive(true);
}

public void third_screen_show()
{
    third_screen.SetActive(false);
    audio_player.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(true);
}

public void categories_show()
{
    audio_player.SetActive(false);
    categories.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(true);
}

public void ao_show()
{
    categories.SetActive(false);
    ao_open.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(true);
}

public void lss_show()
{
    categories.SetActive(false);
    lss_open.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(true);
}

public void vanfrestllningar_show()
{
    ao_open.SetActive(false);
    vanfrestllningar.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(true);
}

public void hallucinationer_show()
{
    ao_open.SetActive(false);
    hallucinationer.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(true);
}

public void miljoanpassning_show()
{
    ao_open.SetActive(false);
    miljoanpassning.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(true);
}

public void ensamhet_show()
{
    ao_open.SetActive(false);
    ensamhet.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(true);
}

public void kommunikation_show()
{
    ao_open.SetActive(false);
    kommunikation.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(true);
}



public void tidsuppfattning_show()
{
    lss_open.SetActive(false);
    tidsuppfattning.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(true);
}

public void social_berttelse_show()
{
    lss_open.SetActive(false);
    social_berttelse.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(true);
}

public void miljoanpassning_lss_show()
{
    lss_open.SetActive(false);
    miljoanpassning_lss.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(true);
}

public void valja_aktivitet_show()
{
    lss_open.SetActive(false);
    valja_aktivitet.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(true);
}

public void plotsliga_handelser_show()
{
    lss_open.SetActive(false);
    plotsliga_handelser.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    lss_menu_active.SetActive(false);
    ao_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(true);
}

public void ao_back()
{
    vanfrestllningar.SetActive(false);
    hallucinationer.SetActive(false);
    miljoanpassning.SetActive(false);
    ensamhet.SetActive(false);
    kommunikation.SetActive(false);

    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(true);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    intro_lss_active.SetActive(false);

    ao_open.SetActive(true);
}

public void lss_back()
{
    tidsuppfattning.SetActive(false);
    social_berttelse.SetActive(false);
    miljoanpassning_lss.SetActive(false);
    valja_aktivitet.SetActive(false);
    plotsliga_handelser.SetActive(false);

    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(true);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    intro_lss_active.SetActive(false);

    lss_open.SetActive(true);
}

public void home_button()
{
    vanfrestllningar.SetActive(false);
    hallucinationer.SetActive(false);
    miljoanpassning.SetActive(false);
    ensamhet.SetActive(false);
    kommunikation.SetActive(false);

    tidsuppfattning.SetActive(false);
    social_berttelse.SetActive(false);
    miljoanpassning_lss.SetActive(false);
    valja_aktivitet.SetActive(false);
    plotsliga_handelser.SetActive(false);

    vanforestallningar_active.SetActive(false);
    hallucinationer_active.SetActive(false);
    miljoanpassning_active.SetActive(false);
    ensamhet_active.SetActive(false);
    kommunikation_active.SetActive(false);

    tidsuppfattning_active.SetActive(false);
    social_berttelse_active.SetActive(false);
    miljoanpassning_lss_active.SetActive(false);
    valja_aktivitet_active.SetActive(false);
    plotsliga_handelser_active.SetActive(false);


    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(true);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    intro_lss_active.SetActive(false);

    ao_open.SetActive(false);
    lss_open.SetActive(false);

    introduction.SetActive(false);

    categories.SetActive(true);
    controls.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("first-screen.mp4", MediaPathType.RelativeToStreamingAssetsFolder), autoPlay: true);
}

public void play_audio()
{
    m_MyAudioSource.Play();
}

public void show_controls()
{
    controls.SetActive(true);
}

public void enter_intro_lss()
{
    lss_open.SetActive(false);
    lss_active.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    introduction.SetActive(true);
    intro_lss_active.SetActive(true);
}

public void enter_intro_ao()
{
    ao_open.SetActive(false);
    ao_active.SetActive(true);
    third_menu_active.SetActive(false);
    forth_menu_active.SetActive(false);
    categories_active.SetActive(false);
    ao_menu_active.SetActive(false);
    ao_menu_item_active.SetActive(false);
    lss_menu_active.SetActive(false);
    lss_menu_item_active.SetActive(false);
    intro_ao_active.SetActive(false);
    introduction.SetActive(true);
    intro_ao_active.SetActive(true);
}

public void intro_back()
{
    if (ao_active.activeSelf)
    {
        ao_open.SetActive(true);
        ao_active.SetActive(false);
        third_menu_active.SetActive(false);
        forth_menu_active.SetActive(false);
        categories_active.SetActive(false);
        ao_menu_active.SetActive(true);
        ao_menu_item_active.SetActive(false);
        lss_menu_active.SetActive(false);
        lss_menu_item_active.SetActive(false);
        intro_ao_active.SetActive(false);
        intro_lss_active.SetActive(false);
    }
    else if (lss_active.activeSelf)
    {
        lss_open.SetActive(true);
        third_menu_active.SetActive(false);
        forth_menu_active.SetActive(false);
        categories_active.SetActive(false);
        ao_menu_active.SetActive(false);
        ao_menu_item_active.SetActive(false);
        lss_menu_active.SetActive(true);
        lss_menu_item_active.SetActive(false);
        intro_ao_active.SetActive(false);
        intro_lss_active.SetActive(false);
        lss_active.SetActive(false);
    }
    introduction.SetActive(false);
}

public void close_controls()
{
    controls.SetActive(false);
}

public void play_vanfrestllningar_1()
{
    vanforestallningar_active.SetActive(true);
    vanfrestllningar.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card1ao-vanforestallninga1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_vanfrestllningar_2_()
{
    vanforestallningar_active.SetActive(true);

    vanfrestllningar.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card1ao-vanforestallningar2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_hallucinationer_1()
{
    hallucinationer_active.SetActive(true);

    hallucinationer.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card2ao-halucinationer1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_hallucinationer_2()
{
    hallucinationer_active.SetActive(true);

    hallucinationer.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card2ao-halucinationer2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_miljoanpassning_1()
{
    miljoanpassning_active.SetActive(true);

    miljoanpassning.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card3ao-miljo1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_miljoanpassning_2()
{
    miljoanpassning_active.SetActive(true);

    miljoanpassning.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card3ao-miljo2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_ensamhet_1()
{
    ensamhet_active.SetActive(true);

    ensamhet.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card4ao-ensamhet1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_ensamhet_2()
{
    ensamhet_active.SetActive(true);

    ensamhet.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card4ao-ensamhet2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_kommunikation_1()
{
    kommunikation_active.SetActive(true);

    kommunikation.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card5ao-kommunikation1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_kommunikation_2()
{
    kommunikation_active.SetActive(true);

    kommunikation.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card5ao-kommunikation2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_tidsuppfattning_1()
{
    tidsuppfattning_active.SetActive(true);

    tidsuppfattning.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card1-tidsuppfattning1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_tidsuppfattning_2()
{
    tidsuppfattning_active.SetActive(true);

    tidsuppfattning.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card1-tidsuppfattning2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_social_berttelse_1()
{
    social_berttelse_active.SetActive(true);

    social_berttelse.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card2-socialberattelse1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_social_berttelse_2()
{
    social_berttelse_active.SetActive(true);

    social_berttelse.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card2-socialberattelsse2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_miljoanpassning_lss_1()
{
    miljoanpassning_lss_active.SetActive(true);

    miljoanpassning_lss.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card3-miljoanpassning1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_miljoanpassning_lss_2()
{
    miljoanpassning_lss_active.SetActive(true);

    miljoanpassning_lss.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card3-miljoanpassning_2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_valja_aktivitet_1()
{
    valja_aktivitet_active.SetActive(true);

    valja_aktivitet.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card4-valjaaktivitet1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_valja_aktivitet_2()
{
    valja_aktivitet_active.SetActive(true);

    valja_aktivitet.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card4-valjaaktivtet2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_plotsliga_handelser_1()
{
    plotsliga_handelser_active.SetActive(true);

    plotsliga_handelser.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card5-plotsligahandelser1.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

public void play_plotsliga_handelser_2()
{
    plotsliga_handelser_active.SetActive(true);

    plotsliga_handelser.SetActive(false);
    bool isOpening = mediaPlayer.OpenMedia(new MediaPath("/storage/emulated/0/Android/data/com.DefaultCompany.PicoNeo3/files/card5-plotsligahandelser2.mp4", MediaPathType.RelativeToPersistentDataFolder), autoPlay: true);
}

}
