using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Canvas selectLevel; //menu de seleccion de niveles
	public Button startText;//boton start
	public Button optionText;//boton de opciones
	public Button backText;// boton para regresar al menu principal
	public GameObject background;//pensado para mover la imagen al presionar un boton 
	public float speed;//velocidad que seria utilizada para mover el fondo


	/* Use this for initialization
	 * TODO el codigo va aqui
	 */

	void Start () {
		selectLevel = selectLevel.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		selectLevel.enabled = false;
		backText.enabled = false;
		backText.gameObject.SetActive (false);//metodo que oculta el boton back
	}
	/* Metodo utilizado al presionar el boton start que mandara a la seleccion de nivel
	 * se encarga de activar los niveles y desactivar los demas botones de la ventana principal
	 * 
	 */
	public void startPress(){
		backgroundMover ();
		selectLevel.enabled = true;
		startText.enabled = false;
		startText.gameObject.SetActive (false);
		optionText.enabled = false;
		optionText.gameObject.SetActive (false);
		backText.enabled = true;
		backText.gameObject.SetActive (true);
	}
	/* Metodo utilizado al presionar el boton atras en el menu de seleccion de niveles o de
	 * opciones, que regresa a la pantana principal del menu del juego
	 * 
	 */
	public void backPress(){
		selectLevel.enabled = false;
		startText.enabled = true;
		startText.gameObject.SetActive (true);
		optionText.enabled = true;
		optionText.gameObject.SetActive (true);
		backText.enabled = false;
		backText.gameObject.SetActive (false);
	}
	/* 
	 * 
	 */
	public void optionPress(){
		
	}

	public void backgroundMover(){
		Debug.Log ("Se entro al metodo backgroundMover");
		background.transform.position = Vector3.left * speed;
		Debug.Log ("Se leyo el codigo del background transform");
	}
	//El metodo sera movido a el script de la seleccion de los niveles a no ser que se haga todo el script del menu en uno solo
	public void startLevel(){
		Application.LoadLevel (1);
	}
}
