using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UI_Contr : MonoBehaviour {
	public GameObject Target;
	public GameObject Light; 
	public bool TargetExists = true;
	public GameObject UI_Filter_Text;
	public GameObject UI; 
	public GameObject MenuButton; 
	public GameObject PlayButton; 
	public GameObject PauseButton; 
	public GameObject PrevButton; 
	public GameObject NextButton; 
	public GameObject MenuPlane; 


	public GameObject Paragraph1; 
	public GameObject Paragraph2; 
	public GameObject Paragraph3; 
	public GameObject Paragraph4; 
	public GameObject Paragraph5; 
	public GameObject Paragraph6; 
	public GameObject Paragraph7;
	//public GameObject Paragraph8;
	//public GameObject Paragraph9;

	public GameObject SelectModel;

	public GameObject Desk;

	public GameObject Model_First;
	public GameObject Model_Second;
	public GameObject FirstLighted; 
	public GameObject SecondLighted; 
	public GameObject ThirdLighted; 
	//public GameObject FourthLighted;
	//public GameObject FifthLighted;
	//public GameObject SixthLighted;



	public float ButtonsCounter; 
	public float NeedStart; 
	public GameObject PausedParag; 

	void Start ()
	{ 
		UI_Filter_Text.SetActive (true); 

		PlayButton.SetActive (false);
		MenuButton.SetActive(false);
		PauseButton.SetActive (false);
		NextButton.SetActive(false);
		PrevButton.SetActive(false);
		
		ButtonsCounter = 1f; 
		NeedStart = 0f; 
		PausedParag = Paragraph1;
		 
	}
	void FixedUpdate()
	{
		if (TargetExists)
		{
			StartCoroutine(TargetSaw());
		}
	}

	public IEnumerator TargetSaw()
	{
		yield return new WaitForSeconds (3);
		if (Target.transform.position != Light.transform.position)
		{
			TargetExists = false;

			UI_Filter_Text.SetActive(false);

			PlayButton.SetActive (true);
			MenuButton.SetActive(true);
			PauseButton.SetActive (false);
			NextButton.SetActive(false);
			PrevButton.SetActive(false);
		}
	}
	






	public void PlaytoPause ()
		{ 
		if (NeedStart == 0) { 
			NeedStart++; 
		} 
		if (ButtonsCounter == 1) { 
			Model_First.SetActive (true); 
		}
		if (ButtonsCounter == 2) { 
			Model_First.SetActive (true); 
		}  
		if (ButtonsCounter == 3) { 
			FirstLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 4) { 
			SecondLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 6) { 
			ThirdLighted.SetActive (true); 
		} /* 
		if (ButtonsCounter == 5) { 
			FourthLighted.SetActive (true); 
		} 
		if (ButtonsCounter == 6) { 
			FifthLighted.SetActive (true); 
		}
		if (ButtonsCounter == 7) { 
			SixthLighted.SetActive (true); 
		} */


		Light.SetActive (true); 
		Desk.SetActive (true); 
		PausedParag.SetActive (true); 
		PlayButton.SetActive (false); 
		PauseButton.SetActive (true);
		NextButton.SetActive(true);
		PrevButton.SetActive(true);  
	} 



	public void PausetoPlay (){ 

		if (NeedStart == 1) { 
			NeedStart--;} 



		if (Paragraph1.activeInHierarchy == true) { 
			PausedParag = Paragraph1; 
		} 
		if (Paragraph2.activeInHierarchy == true) { 
			PausedParag = Paragraph2; 
		} 
		if (Paragraph3.activeInHierarchy == true) { 
			PausedParag = Paragraph3; 
		} 
		if (Paragraph4.activeInHierarchy == true) { 
			PausedParag = Paragraph4; 
		} 
		if (Paragraph5.activeInHierarchy == true) { 
			PausedParag = Paragraph5; 
		} 
		if (Paragraph6.activeInHierarchy == true) { 
			PausedParag = Paragraph6; 
		} 
		if (Paragraph7.activeInHierarchy == true) { 
			PausedParag = Paragraph7; 
		}/* 
		if (Paragraph8.activeInHierarchy == true) { 
			PausedParag = Paragraph8; 
		}
		if (Paragraph9.activeInHierarchy == true) { 
			PausedParag = Paragraph9; 
		}*/


		FirstLighted.SetActive (false);
		SecondLighted.SetActive (false);
		ThirdLighted.SetActive (false); 
		/*FourthLighted.SetActive (false); 
		FifthLighted.SetActive (false); 
		SixthLighted.SetActive (false); */


		/*Paragraph9.SetActive (false);
		Paragraph8.SetActive (false);*/
		Paragraph7.SetActive (false);
		Paragraph6.SetActive (false); 
		Paragraph5.SetActive (false); 
		Paragraph4.SetActive (false); 
		Paragraph3.SetActive (false); 
		Paragraph2.SetActive (false); 
		Paragraph1.SetActive (false); 


		Desk.SetActive (false); 
		PauseButton.SetActive (false); 
		PlayButton.SetActive (true);
		NextButton.SetActive(false);
		PrevButton.SetActive(false); 
	} 




	public void PauseMenuu (){ 
		UI.SetActive (false); 
		MenuPlane.SetActive (true); 
	} 
	public void PauseMenuuBack (){ 
		MenuPlane.SetActive (false); 
		UI.SetActive (true); 

	} 
	public void PauseMenuuBacktoStart (){ 
		//SceneManager.LoadScene (0); 

	} 










	public void Next (){ 
		if (NeedStart>0f){ 
			ButtonsCounter++; 
		} 


		if (ButtonsCounter == 8) { 
			ButtonsCounter--; 
		}//Verhnya granica ButtonsCounter'a
		Checkk();
	} 





	public void Prev(){ 
		if (NeedStart > 0f) { 
			ButtonsCounter--; 
		} 
		if (ButtonsCounter == 0) {
			ButtonsCounter++; 
		} 
		Checkk ();
	} 




	
	public void SelectedModel(){
		SelectModel.SetActive (true);
	}
	public void SelectedModelStop(){
		SelectModel.SetActive (false);
	}




	public void Checkk (){


		SelectModel.SetActive (false);
		if ((ButtonsCounter == 1)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph4.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false);
			//Paragraph8.SetActive (false);
			Paragraph7.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph1.SetActive (true); 
			FirstLighted.SetActive (false);
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (false); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 
		} 
		if ((ButtonsCounter == 2)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph4.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph2.SetActive (true); 
			FirstLighted.SetActive (false);
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (false); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 
		} 
		if ((ButtonsCounter == 3)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph3.SetActive (true); 
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (false);
			FirstLighted.SetActive (true); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 
		} 
		if ((ButtonsCounter == 4)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph3.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph4.SetActive (true); 
			FirstLighted.SetActive (false);
			ThirdLighted.SetActive (false);
			SecondLighted.SetActive (true); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 

		} 
		if ((ButtonsCounter == 5)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false); 
			Paragraph5.SetActive (true); 
			FirstLighted.SetActive (false);
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (false); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 

		} 
		if ((ButtonsCounter == 6)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true); 
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph7.SetActive (false);
			//Paragraph8.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (true); 
			FirstLighted.SetActive (false);
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (true); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false);  

		}
		if ((ButtonsCounter == 7)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Desk.SetActive (true);
			//Paragraph8.SetActive (false);
			Paragraph7.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false);
			//Paragraph9.SetActive (false);
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false);
			Paragraph7.SetActive (true); 
			FirstLighted.SetActive (false);
			SecondLighted.SetActive (false);
			ThirdLighted.SetActive (false); 
			//FourthLighted.SetActive (false); 
			//FifthLighted.SetActive (false); 
			//SixthLighted.SetActive (false); 

		} 
		/*if ((ButtonsCounter == 8)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			Paragraph7.SetActive (false); 
			Paragraph5.SetActive (false); 
			Paragraph9.SetActive (false);
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false);
			Paragraph8.SetActive (true); 
			MembranaLighted.SetActive (false); 
			MitohondriyaLighted.SetActive(false); 
			VakuolLighted.SetActive (false); 
			RibosomyLighted.SetActive (false);
			GoldzhyLighted.SetActive (false);
			YadroLighted.SetActive (true);

		}
		if ((ButtonsCounter == 9)&&(NeedStart>0)) { 

			Light.SetActive (true); 
			Plane.SetActive (true);
			Paragraph7.SetActive (false);
			Paragraph5.SetActive (false); 
			Paragraph1.SetActive (false); 
			Paragraph2.SetActive (false); 
			Paragraph3.SetActive (false); 
			Paragraph4.SetActive (false); 
			Paragraph6.SetActive (false);
			Paragraph8.SetActive (false);
			Paragraph9.SetActive (true);
			MembranaLighted.SetActive (false); 
			MitohondriyaLighted.SetActive(false); 
			VakuolLighted.SetActive (false); 
			RibosomyLighted.SetActive (false);
			GoldzhyLighted.SetActive (false);
			YadroLighted.SetActive (false);

		}*/









	}



}
