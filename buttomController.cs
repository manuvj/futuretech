using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class buttomController : MonoBehaviour {

	public Transform aboutPanel;
	public Transform tripPanel;
	public Transform selectedPanel;
	public Transform mapPanel;
	public Transform exitPanel;

	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(aboutPanel.gameObject.activeInHierarchy == true)
			{
				aboutPanel.gameObject.SetActive(false);
			}
			else if(tripPanel.gameObject.activeInHierarchy == true)
			{
				if(selectedPanel.gameObject.activeInHierarchy == true)
				{
					if(mapPanel.gameObject.activeInHierarchy == true)
					{
						mapPanel.gameObject.SetActive(false);
					}
					else
					    selectedPanel.gameObject.SetActive(false);					
				}
				
			    else
			  		tripPanel.gameObject.SetActive(false);
			}
			else
			{
				if(exitPanel.gameObject.activeInHierarchy == false)
				{
					exitPanel.gameObject.SetActive(true);
				}
				else
				{
					exitPanel.gameObject.SetActive(false);
				}

			}
		}
	}

	public void quit()
	{
		Application.Quit();
	}

	public void cancelPanel()
	{
		exitPanel.gameObject.SetActive(false);
	}


	public void tripSelection()
	{
		selectedPanel.gameObject.SetActive(true);
	}
	public void about()
	{
		aboutPanel.gameObject.SetActive(true);
	}
	public void pamphlet()
	{
		SceneManager.LoadScene("pamphet");
	}
	public void rajaview()
	{
		SceneManager.LoadScene("TripPlannerBox");
	} 
	public void trip()
	{
		tripPanel.gameObject.SetActive(true);
	}
	public void arActive()
	{
		// SceneManager.LoadScene("TripPlannerBox");
	}
	public void mapselected()
	{
		// mapPanel.gameObject.SetActive(true);
	}
}
