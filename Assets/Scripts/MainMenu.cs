using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    /* Use this for initialization
	 * TODO el codigo va aqui
	 */
    public Canvas helpMenu;
    public Button startText;
    public Button optionText;
    public Button helpButton;
    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;

	void Start () {
        cameraTransform = Camera.main.transform;
        helpMenu = helpMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        optionText = optionText.GetComponent<Button>();
        helpButton = helpButton.GetComponent<Button>();
        helpMenu.enabled = false;
    }

    void Update(){
        if(cameraDesiredLookAt != null) {
            cameraTransform.position = Vector3.Lerp(
                new Vector3 (cameraTransform.position.x, cameraTransform.position.y, -2),
                cameraDesiredLookAt.position,
                3 * Time.deltaTime);
        }
    }
    /*
     * Metodo que muestra el menu de ayuda del menu principal
     */
    public void helpPress(){
        helpMenu.enabled = true;
        startText.enabled = false;
        optionText.enabled = false;
        helpButton.enabled = false;
    }
    /*
     *Metodo que cierra la ventana emergente del menu de ayuda
     */
    public void closePress(){
        helpMenu.enabled = false;
        startText.enabled = true;
        optionText.enabled = true;
        helpButton.enabled = true;
    }

	/* Metodo utilizado al presionar el boton start que mandara a la seleccion de nivel
	 * se encarga de activar los niveles y desactivar los demas botones de la ventana principal
	 * 
	 */
	public void lookAtMenu(Transform targetPosition){
        cameraDesiredLookAt = targetPosition;
        //Camera.main.transform.position = new Vector3 (targetPosition.position.x,targetPosition.position.y, -2);
    }
    
	//El metodo sera movido a el script de la seleccion de los niveles a no ser que se haga todo el script del menu en uno solo
	public void startLevel(){
        UnityEngine.SceneManagement.LoadSceneMode mode;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1, mode = UnityEngine.SceneManagement.LoadSceneMode.Single);
		//Application.LoadLevel (1); obsolete
        
	}
}
