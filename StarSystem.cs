using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsystem : MonoBehaviour
{
public GameObject OriginalObject;
public GameObject one1star;
public GameObject two2star;
public GameObject three3star;
public int minmistake1;
public int maxmistake1;
public int minmistake2;
public int maxmistake2;
public int minmistake3;
public int maxmistake3;
    void Update()
    {
if(OriginalObject.gameObject.GetComponent<MistakesCounter>().nonmistakes >= minmistake1 && OriginalObject.gameObject.GetComponent<MistakesCounter>().nonmistakes  <= maxmistake1)
{
onestar();
}
if(OriginalObject.gameObject.GetComponent<MistakesCounter>().nonmistakes >= minmistake2 && OriginalObject.gameObject.GetComponent<MistakesCounter>().nonmistakes <= maxmistake2)
{
twostar();
}
if(OriginalObject.gameObject.GetComponent<MistakesCounter>().nonmistakes >= maxmistake3)
{
threestar();
}
}
void onestar()
{
print("onestar");
one1star.SetActive(true);
}
void twostar()
{
print("twostar");
two2star.SetActive(true);
one1star.SetActive(false);
}
void threestar()
{
print("threestar");
three3star.SetActive(true);
two2star.SetActive(false);
one1star.SetActive(false);
}     
}
