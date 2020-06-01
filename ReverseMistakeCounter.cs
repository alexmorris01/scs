using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityEngine.UI;
public class ReverseMistakesCounter : MonoBehaviour 
{
public Text mistakecounter;
public Text correctemailcounter;
public AudioSource correctsound;
public AudioSource wrongsound;
public int mistakes;
public int nonmistakes;
public GameObject email;
public GameObject copy;
public float daynumber;
void OnTriggerEnter2D(Collider2D other) 
{
//hide the email once it's finished its loop
other.gameObject.SetActive(false);
//spawn another email
email.gameObject.GetComponent<spawner>().NewSpawn();
if(other.name.Contains("INBOX"))
{
//check if email is spam, if so, +1 to the nonmistake counter.
nonmistakes = nonmistakes + 1;
print("Incorrect Inbox");
//store the nonmistakes in an deactivated gameobject for use later
correctemailcounter.text  = ("Day ") + daynumber + (" Complete! You got ") + nonmistakes + (" Correct Emails");
//play the correct email sound
correctsound.Play();
}
if(other.name.Contains("SPAM"))
{
//check if email is a legit email, if so, +1 to the mistakes counter.
mistakes = mistakes + 1;
//play the incorrect email sound
wrongsound.Play();
print("Correct Spam");
//store the mistakes in an deactivated gameobject for use later
mistakecounter.text = ("Mistakes : ") + mistakes.ToString();
}
}
}