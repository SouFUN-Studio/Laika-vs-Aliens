using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    /* Use this for initialization
	 * TODO el codigo va aqui
	 */
    public Canvas helpMenu;
    public Canvas selectWeaponMenu;
    public Button startText;
    public Button optionText;
    public Button helpButton;
    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;
    //efectos
    public AudioSource startAudio;
    //canvas select level 
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;
    public Button back;
   
    void Start ()
    {
        cameraTransform = Camera.main.transform;
        helpMenu = helpMenu.GetComponent<Canvas>();
        selectWeaponMenu = selectWeaponMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        optionText = optionText.GetComponent<Button>();
        helpButton = helpButton.GetComponent<Button>();
        helpMenu.enabled = false;
        selectWeaponMenu.enabled = false;
        //canvas select level 
        level1 = level1.GetComponent<Button>();
        level2 = level2.GetComponent<Button>();
        level3 = level3.GetComponent<Button>();
        level4 = level4.GetComponent<Button>();
        level5 = level5.GetComponent<Button>();
        level6 = level6.GetComponent<Button>();
        level7 = level7.GetComponent<Button>();
        level8 = level8.GetComponent<Button>();
        level9 = level9.GetComponent<Button>();
        level10 = level10.GetComponent<Button>();
        back = back.GetComponent<Button>();
    }

    void Update()
    {
        if(cameraDesiredLookAt != null)
        {
            cameraTransform.position = Vector3.Lerp(
                new Vector3 (cameraTransform.position.x, cameraTransform.position.y, -2),
                cameraDesiredLookAt.position,
                3 * Time.deltaTime);
        }
    }
    /*
     * Metodo que muestra el menu de ayuda del menu principal
     */
    public void helpPress()
    {
        helpMenu.enabled = true;
        startText.enabled = false;
        optionText.enabled = false;
        helpButton.enabled = false;
    }
    /*
     *Metodo que cierra la ventana emergente del menu de ayuda
     */
    public void helpClosePress()
    {
        helpMenu.enabled = false;
        startText.enabled = true;
        optionText.enabled = true;
        helpButton.enabled = true;
    }
    /*
    *Metodo que muestra el seleccionador de armas de cualquier nivel, FORMA SENCILLA DEL MENU QUE SOLO SE MUESTRA
    *COMPLETAR CODIGO PARA TODOS LOS NIVELES CON LAS DOIFERENTES ARMAS
    */
    public void selecLevelPress()
    {
        selectWeaponMenu.enabled = true;
        level1.enabled = false;
        level2.enabled = false;
        level3.enabled = false;
        level4.enabled = false;
        level5.enabled = false;
        level6.enabled = false;
        level7.enabled = false;
        level8.enabled = false;
        level9.enabled = false;
        level10.enabled = false;
        back.enabled = false;
    }
    /*
    *Metodo que cierra el seleccionador de armas 
    */
    public void selectWeaponclose()
    {
        selectWeaponMenu.enabled = false;
        level1.enabled = true;
        level2.enabled = true;
        level3.enabled = true;
        level4.enabled = true;
        level5.enabled = true;
        level6.enabled = true;
        level7.enabled = true;
        level8.enabled = true;
        level9.enabled = true;
        level10.enabled = true;
        back.enabled = true;
    }

	/* Metodo utilizado al presionar el boton start que mandara a la seleccion de nivel
	 * se encarga de activar los niveles y desactivar los demas botones de la ventana principal
	 * 
	 */
	public void lookAtMenu(Transform targetPosition)
    {
        cameraDesiredLookAt = targetPosition;
        //Camera.main.transform.position = new Vector3 (targetPosition.position.x,targetPosition.position.y, -2);
    }
    /*
    *
    */
    public void pressStart()
    {
        startAudio.enabled = true;
    }
	//El metodo sera movido a el script de la seleccion de los niveles a no ser que se haga todo el script del menu en uno solo
	public void startLevel()
    {
        UnityEngine.SceneManagement.LoadSceneMode mode;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1, mode = UnityEngine.SceneManagement.LoadSceneMode.Single);
		//Application.LoadLevel (1); obsolete
        
	}
}
