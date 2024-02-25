using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DontDestroyOnLoadScript : MonoBehaviour
{
    public char[] splitCode;
    public int[] decodedInt;

    [Header("Wave1")]
    public GameObject normalZombie1, fastZombie1, deadZombie1, scientistZombie1, spawnerZombie1, slowZombie1, shadowZombie1;
    [Header("Wave2")]
    public GameObject normalZombie2, fastZombie2, deadZombie2, scientistZombie2, spawnerZombie2, slowZombie2, shadowZombie2;
    [Header("Wave3")]
    public GameObject normalZombie3, fastZombie3, deadZombie3, scientistZombie3, spawnerZombie3, slowZombie3, shadowZombie3;
    [Header("Wave4")]
    public GameObject normalZombie4, fastZombie4, deadZombie4, scientistZombie4, spawnerZombie4, slowZombie4, shadowZombie4;
    [Header("Wave5")]
    public GameObject normalZombie5, fastZombie5, deadZombie5, scientistZombie5, spawnerZombie5, slowZombie5, shadowZombie5;
    [Header("Wave6")]
    public GameObject normalZombie6, fastZombie6, deadZombie6, scientistZombie6, spawnerZombie6, slowZombie6, shadowZombie6;
    [Header("Wave7")]
    public GameObject normalZombie7, fastZombie7, deadZombie7, scientistZombie7, spawnerZombie7, slowZombie7, shadowZombie7;
    [Header("Wave8")]
    public GameObject normalZombie8, fastZombie8, deadZombie8, scientistZombie8, spawnerZombie8, slowZombie8, shadowZombie8;
    [Header("Wave9")]
    public GameObject normalZombie9, fastZombie9, deadZombie9, scientistZombie9, spawnerZombie9, slowZombie9, shadowZombie9;
    [Header("Wave10")]
    public GameObject normalZombie10, fastZombie10, deadZombie10, scientistZombie10, spawnerZombie10, slowZombie10, shadowZombie10;
    [Header("Wave11")]
    public GameObject normalZombie11, fastZombie11, deadZombie11, scientistZombie11, spawnerZombie11, slowZombie11, shadowZombie11;
    [Header("Wave12")]
    public GameObject normalZombie12, fastZombie12, deadZombie12, scientistZombie12, spawnerZombie12, slowZombie12, shadowZombie12;
    [Header("Wave13")]
    public GameObject normalZombie13, fastZombie13, deadZombie13, scientistZombie13, spawnerZombie13, slowZombie13, shadowZombie13;
    [Header("Wave14")]
    public GameObject normalZombie14, fastZombie14, deadZombie14, scientistZombie14, spawnerZombie14, slowZombie14, shadowZombie14;
    [Header("Wave15")]
    public GameObject normalZombie15, fastZombie15, deadZombie15, scientistZombie15, spawnerZombie15, slowZombie15, shadowZombie15;
    [Header("Wave16")]
    public GameObject normalZombie16, fastZombie16, deadZombie16, scientistZombie16, spawnerZombie16, slowZombie16, shadowZombie16;
    [Header("Wave17")]
    public GameObject normalZombie17, fastZombie17, deadZombie17, scientistZombie17, spawnerZombie17, slowZombie17, shadowZombie17;
    [Header("Wave18")]
    public GameObject normalZombie18, fastZombie18, deadZombie18, scientistZombie18, spawnerZombie18, slowZombie18, shadowZombie18;
    [Header("Wave19")]
    public GameObject normalZombie19, fastZombie19, deadZombie19, scientistZombie19, spawnerZombie19, slowZombie19, shadowZombie19;
    [Header("Wave20")]
    public GameObject normalZombie20, fastZombie20, deadZombie20, scientistZombie20, spawnerZombie20, slowZombie20, shadowZombie20;

    [Header("Other")]
    public GameObject startingWaveObject;
    public GameObject startingMoneyObject;

    public int[] wave1;
    public int[] wave2;
    public int[] wave3;
    public int[] wave4;
    public int[] wave5;
    public int[] wave6;
    public int[] wave7;
    public int[] wave8;
    public int[] wave9;
    public int[] wave10;
    public int[] wave11;
    public int[] wave12;
    public int[] wave13;
    public int[] wave14;
    public int[] wave15;
    public int[] wave16;
    public int[] wave17;
    public int[] wave18;
    public int[] wave19;
    public int[] wave20;

    public int startingWave, startingMoney, number;

    public GameObject CodeObject, DecodeObject;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoadNumbers()
    {
        startingWave = int.Parse(startingWaveObject.GetComponentInChildren<TMP_InputField>().text);
        startingMoney = int.Parse(startingMoneyObject.GetComponentInChildren<TMP_InputField>().text);

        //Wave1
        wave1[0] = int.Parse(normalZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[1] = int.Parse(fastZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[2] = int.Parse(slowZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[3] = int.Parse(deadZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[4] = int.Parse(scientistZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[5] = int.Parse(shadowZombie1.GetComponentInChildren<TMP_InputField>().text);
        wave1[6] = int.Parse(spawnerZombie1.GetComponentInChildren<TMP_InputField>().text);

        //Wave2
        wave2[0] = int.Parse(normalZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[1] = int.Parse(fastZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[2] = int.Parse(slowZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[3] = int.Parse(deadZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[4] = int.Parse(scientistZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[5] = int.Parse(shadowZombie2.GetComponentInChildren<TMP_InputField>().text);
        wave2[6] = int.Parse(spawnerZombie2.GetComponentInChildren<TMP_InputField>().text);

        //Wave3
        wave3[0] = int.Parse(normalZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[1] = int.Parse(fastZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[2] = int.Parse(slowZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[3] = int.Parse(deadZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[4] = int.Parse(scientistZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[5] = int.Parse(shadowZombie3.GetComponentInChildren<TMP_InputField>().text);
        wave3[6] = int.Parse(spawnerZombie3.GetComponentInChildren<TMP_InputField>().text);

        //Wave4
        wave4[0] = int.Parse(normalZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[1] = int.Parse(fastZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[2] = int.Parse(slowZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[3] = int.Parse(deadZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[4] = int.Parse(scientistZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[5] = int.Parse(shadowZombie4.GetComponentInChildren<TMP_InputField>().text);
        wave4[6] = int.Parse(spawnerZombie4.GetComponentInChildren<TMP_InputField>().text);

        //wave5
        wave5[0] = int.Parse(normalZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[1] = int.Parse(fastZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[2] = int.Parse(slowZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[3] = int.Parse(deadZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[4] = int.Parse(scientistZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[5] = int.Parse(shadowZombie5.GetComponentInChildren<TMP_InputField>().text);
        wave5[6] = int.Parse(spawnerZombie5.GetComponentInChildren<TMP_InputField>().text);

        //wave6
        wave6[0] = int.Parse(normalZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[1] = int.Parse(fastZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[2] = int.Parse(slowZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[3] = int.Parse(deadZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[4] = int.Parse(scientistZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[5] = int.Parse(shadowZombie6.GetComponentInChildren<TMP_InputField>().text);
        wave6[6] = int.Parse(spawnerZombie6.GetComponentInChildren<TMP_InputField>().text);

        //wave7
        wave7[0] = int.Parse(normalZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[1] = int.Parse(fastZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[2] = int.Parse(slowZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[3] = int.Parse(deadZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[4] = int.Parse(scientistZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[5] = int.Parse(shadowZombie7.GetComponentInChildren<TMP_InputField>().text);
        wave7[6] = int.Parse(spawnerZombie7.GetComponentInChildren<TMP_InputField>().text);

        //wave8
        wave8[0] = int.Parse(normalZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[1] = int.Parse(fastZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[2] = int.Parse(slowZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[3] = int.Parse(deadZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[4] = int.Parse(scientistZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[5] = int.Parse(shadowZombie8.GetComponentInChildren<TMP_InputField>().text);
        wave8[6] = int.Parse(spawnerZombie8.GetComponentInChildren<TMP_InputField>().text);

        //wave9
        wave9[0] = int.Parse(normalZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[1] = int.Parse(fastZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[2] = int.Parse(slowZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[3] = int.Parse(deadZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[4] = int.Parse(scientistZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[5] = int.Parse(shadowZombie9.GetComponentInChildren<TMP_InputField>().text);
        wave9[6] = int.Parse(spawnerZombie9.GetComponentInChildren<TMP_InputField>().text);

        //wave10
        wave10[0] = int.Parse(normalZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[1] = int.Parse(fastZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[2] = int.Parse(slowZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[3] = int.Parse(deadZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[4] = int.Parse(scientistZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[5] = int.Parse(shadowZombie10.GetComponentInChildren<TMP_InputField>().text);
        wave10[6] = int.Parse(spawnerZombie10.GetComponentInChildren<TMP_InputField>().text);

        //wave11
        wave11[0] = int.Parse(normalZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[1] = int.Parse(fastZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[2] = int.Parse(slowZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[3] = int.Parse(deadZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[4] = int.Parse(scientistZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[5] = int.Parse(shadowZombie11.GetComponentInChildren<TMP_InputField>().text);
        wave11[6] = int.Parse(spawnerZombie11.GetComponentInChildren<TMP_InputField>().text);

        //wave12
        wave12[0] = int.Parse(normalZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[1] = int.Parse(fastZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[2] = int.Parse(slowZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[3] = int.Parse(deadZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[4] = int.Parse(scientistZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[5] = int.Parse(shadowZombie12.GetComponentInChildren<TMP_InputField>().text);
        wave12[6] = int.Parse(spawnerZombie12.GetComponentInChildren<TMP_InputField>().text);

        //wave13
        wave13[0] = int.Parse(normalZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[1] = int.Parse(fastZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[2] = int.Parse(slowZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[3] = int.Parse(deadZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[4] = int.Parse(scientistZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[5] = int.Parse(shadowZombie13.GetComponentInChildren<TMP_InputField>().text);
        wave13[6] = int.Parse(spawnerZombie13.GetComponentInChildren<TMP_InputField>().text);

        //wave14
        wave14[0] = int.Parse(normalZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[1] = int.Parse(fastZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[2] = int.Parse(slowZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[3] = int.Parse(deadZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[4] = int.Parse(scientistZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[5] = int.Parse(shadowZombie14.GetComponentInChildren<TMP_InputField>().text);
        wave14[6] = int.Parse(spawnerZombie14.GetComponentInChildren<TMP_InputField>().text);

        //wave15
        wave15[0] = int.Parse(normalZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[1] = int.Parse(fastZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[2] = int.Parse(slowZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[3] = int.Parse(deadZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[4] = int.Parse(scientistZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[5] = int.Parse(shadowZombie15.GetComponentInChildren<TMP_InputField>().text);
        wave15[6] = int.Parse(spawnerZombie15.GetComponentInChildren<TMP_InputField>().text);

        //wave16
        wave16[0] = int.Parse(normalZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[1] = int.Parse(fastZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[2] = int.Parse(slowZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[3] = int.Parse(deadZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[4] = int.Parse(scientistZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[5] = int.Parse(shadowZombie16.GetComponentInChildren<TMP_InputField>().text);
        wave16[6] = int.Parse(spawnerZombie16.GetComponentInChildren<TMP_InputField>().text);

        //wave17
        wave17[0] = int.Parse(normalZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[1] = int.Parse(fastZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[2] = int.Parse(slowZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[3] = int.Parse(deadZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[4] = int.Parse(scientistZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[5] = int.Parse(shadowZombie17.GetComponentInChildren<TMP_InputField>().text);
        wave17[6] = int.Parse(spawnerZombie17.GetComponentInChildren<TMP_InputField>().text);

        //wave18
        wave18[0] = int.Parse(normalZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[1] = int.Parse(fastZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[2] = int.Parse(slowZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[3] = int.Parse(deadZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[4] = int.Parse(scientistZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[5] = int.Parse(shadowZombie18.GetComponentInChildren<TMP_InputField>().text);
        wave18[6] = int.Parse(spawnerZombie18.GetComponentInChildren<TMP_InputField>().text);

        //wave19
        wave19[0] = int.Parse(normalZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[1] = int.Parse(fastZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[2] = int.Parse(slowZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[3] = int.Parse(deadZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[4] = int.Parse(scientistZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[5] = int.Parse(shadowZombie19.GetComponentInChildren<TMP_InputField>().text);
        wave19[6] = int.Parse(spawnerZombie19.GetComponentInChildren<TMP_InputField>().text);

        //wave20
        wave20[0] = int.Parse(normalZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[1] = int.Parse(fastZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[2] = int.Parse(slowZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[3] = int.Parse(deadZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[4] = int.Parse(scientistZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[5] = int.Parse(shadowZombie20.GetComponentInChildren<TMP_InputField>().text);
        wave20[6] = int.Parse(spawnerZombie20.GetComponentInChildren<TMP_InputField>().text);
    }

    public void Code()
    {
        LoadNumbers();
        CodeObject.GetComponentInChildren<TMP_InputField>().text = "";

        string[] Letters;
        Letters = new string[145];

        int foreachPosition = 0;
        foreach (int i in wave1)
        {
            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave2)
        {
            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }
            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;

        }

        foreach (int i in wave3)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;

        }

        foreach (int i in wave4)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave5)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave6)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave7)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave8)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave9)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave10)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave11)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave12)
        {
            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave13)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave14)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave15)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave16)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave17)
        {
            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave18)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave19)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }

        foreach (int i in wave20)
        {

            if (i == 0)
            {
                Letters[foreachPosition] = "A";
            }
            else if (i == 1)
            {
                Letters[foreachPosition] = "a";
            }
            else if (i == 2)
            {
                Letters[foreachPosition] = "B";
            }
            else if (i == 3)
            {
                Letters[foreachPosition] = "b";
            }
            else if (i == 4)
            {
                Letters[foreachPosition] = "C";
            }
            else if (i == 5)
            {
                Letters[foreachPosition] = "c";
            }
            else if (i == 6)
            {
                Letters[foreachPosition] = "D";
            }
            else if (i == 7)
            {
                Letters[foreachPosition] = "d";
            }
            else if (i == 8)
            {
                Letters[foreachPosition] = "E";
            }
            else if (i == 9)
            {
                Letters[foreachPosition] = "e";
            }
            else if (i == 10)
            {
                Letters[foreachPosition] = "F";
            }
            else if (i == 11)
            {
                Letters[foreachPosition] = "f";
            }
            else if (i == 12)
            {
                Letters[foreachPosition] = "G";
            }
            else if (i == 13)
            {
                Letters[foreachPosition] = "g";
            }
            else if (i == 14)
            {
                Letters[foreachPosition] = "H";
            }
            else if (i == 15)
            {
                Letters[foreachPosition] = "h";
            }
            else if (i == 16)
            {
                Letters[foreachPosition] = "I";
            }
            else if (i == 17)
            {
                Letters[foreachPosition] = "i";
            }
            else if (i == 18)
            {
                Letters[foreachPosition] = "J";
            }
            else if (i == 19)
            {
                Letters[foreachPosition] = "j";
            }
            else if (i == 20)
            {
                Letters[foreachPosition] = "K";
            }
            else if (i == 21)
            {
                Letters[foreachPosition] = "k";
            }
            else if (i == 22)
            {
                Letters[foreachPosition] = "L";
            }
            else if (i == 23)
            {
                Letters[foreachPosition] = "l";
            }
            else if (i == 24)
            {
                Letters[foreachPosition] = "M";
            }
            else if (i == 25)
            {
                Letters[foreachPosition] = "m";
            }
            else if (i == 26)
            {
                Letters[foreachPosition] = "N";
            }
            else if (i == 27)
            {
                Letters[foreachPosition] = "n";
            }
            else if (i == 28)
            {
                Letters[foreachPosition] = "O";
            }
            else if (i == 29)
            {
                Letters[foreachPosition] = "o";
            }
            else if (i == 30)
            {
                Letters[foreachPosition] = "P";
            }
            else if (i == 31)
            {
                Letters[foreachPosition] = "p";
            }
            else if (i == 32)
            {
                Letters[foreachPosition] = "Q";
            }
            else if (i == 33)
            {
                Letters[foreachPosition] = "q";
            }
            else if (i == 34)
            {
                Letters[foreachPosition] = "R";
            }
            else if (i == 35)
            {
                Letters[foreachPosition] = "r";
            }
            else if (i == 36)
            {
                Letters[foreachPosition] = "S";
            }
            else if (i == 37)
            {
                Letters[foreachPosition] = "s";
            }
            else if (i == 38)
            {
                Letters[foreachPosition] = "T";
            }
            else if (i == 39)
            {
                Letters[foreachPosition] = "t";
            }
            else if (i == 40)
            {
                Letters[foreachPosition] = "U";
            }
            else if (i == 41)
            {
                Letters[foreachPosition] = "u";
            }
            else if (i == 42)
            {
                Letters[foreachPosition] = "V";
            }
            else if (i == 43)
            {
                Letters[foreachPosition] = "v";
            }
            else if (i == 44)
            {
                Letters[foreachPosition] = "W";
            }
            else if (i == 45)
            {
                Letters[foreachPosition] = "w";
            }
            else if (i == 46)
            {
                Letters[foreachPosition] = "X";
            }
            else if (i == 47)
            {
                Letters[foreachPosition] = "x";
            }
            else if (i == 48)
            {
                Letters[foreachPosition] = "Y";
            }
            else if (i == 49)
            {
                Letters[foreachPosition] = "y";
            }
            else if (i == 50)
            {
                Letters[foreachPosition] = "Z";
            }
            else if (i == 51)
            {
                Letters[foreachPosition] = "z";
            }

            CodeObject.GetComponentInChildren<TMP_InputField>().text = CodeObject.GetComponentInChildren<TMP_InputField>().text + Letters[foreachPosition];

            foreachPosition++;
        }
    }

    public void Decode()
    {
        DecodeObject.GetComponentInChildren<TMP_InputField>().text = "";

        if (number == 0)
        {
            string code = CodeObject.GetComponentInChildren<TMP_InputField>().text;
            splitCode = new char[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                splitCode[i] = code[i];
            }
        }

        int stringPos = 0;
        decodedInt = new int[145];

        foreach(char i in splitCode)
        {
            if (splitCode[stringPos].ToString() == "A")
            {
                decodedInt[stringPos] = 0;
            }
            else if (splitCode[stringPos].ToString() == "a")
            {
                decodedInt[stringPos] = 1;
            }
            else if (splitCode[stringPos].ToString() == "B")
            {
                decodedInt[stringPos] = 2;
            }
            else if (splitCode[stringPos].ToString() == "b")
            {
                decodedInt[stringPos] = 3;
            }
            else if (splitCode[stringPos].ToString() == "C")
            {
                decodedInt[stringPos] = 4;
            }
            else if (splitCode[stringPos].ToString() == "c")
            {
                decodedInt[stringPos] = 5;
            }
            else if (splitCode[stringPos].ToString() == "D")
            {
                decodedInt[stringPos] = 6;
            }
            else if (splitCode[stringPos].ToString() == "d")
            {
                decodedInt[stringPos] = 7;
            }
            else if (splitCode[stringPos].ToString() == "E")
            {
                decodedInt[stringPos] = 8;
            }
            else if (splitCode[stringPos].ToString() == "e")
            {
                decodedInt[stringPos] = 9;
            }
            else if (splitCode[stringPos].ToString() == "F")
            {
                decodedInt[stringPos] = 10;
            }
            else if (splitCode[stringPos].ToString() == "f")
            {
                decodedInt[stringPos] = 11;
            }
            else if (splitCode[stringPos].ToString() == "G")
            {
                decodedInt[stringPos] = 12;
            }
            else if (splitCode[stringPos].ToString() == "g")
            {
                decodedInt[stringPos] = 13;
            }
            else if (splitCode[stringPos].ToString() == "H")
            {
                decodedInt[stringPos] = 14;
            }
            else if (splitCode[stringPos].ToString() == "h")
            {
                decodedInt[stringPos] = 15;
            }
            else if (splitCode[stringPos].ToString() == "I")
            {
                decodedInt[stringPos] = 16;
            }
            else if (splitCode[stringPos].ToString() == "i")
            {
                decodedInt[stringPos] = 17;
            }
            else if (splitCode[stringPos].ToString() == "J")
            {
                decodedInt[stringPos] = 18;
            }
            else if (splitCode[stringPos].ToString() == "j")
            {
                decodedInt[stringPos] = 19;
            }
            else if (splitCode[stringPos].ToString() == "K")
            {
                decodedInt[stringPos] = 20;
            }
            else if (splitCode[stringPos].ToString() == "k")
            {
                decodedInt[stringPos] = 21;
            }
            else if (splitCode[stringPos].ToString() == "L")
            {
                decodedInt[stringPos] = 22;
            }
            else if (splitCode[stringPos].ToString() == "l")
            {
                decodedInt[stringPos] = 23;
            }
            else if (splitCode[stringPos].ToString() == "M")
            {
                decodedInt[stringPos] = 24;
            }
            else if (splitCode[stringPos].ToString() == "m")
            {
                decodedInt[stringPos] = 25;
            }
            else if (splitCode[stringPos].ToString() == "N")
            {
                decodedInt[stringPos] = 26;
            }
            else if (splitCode[stringPos].ToString() == "n")
            {
                decodedInt[stringPos] = 27;
            }
            else if (splitCode[stringPos].ToString() == "O")
            {
                decodedInt[stringPos] = 28;
            }
            else if (splitCode[stringPos].ToString() == "o")
            {
                decodedInt[stringPos] = 29;
            }
            else if (splitCode[stringPos].ToString() == "P")
            {
                decodedInt[stringPos] = 30;
            }
            else if (splitCode[stringPos].ToString() == "p")
            {
                decodedInt[stringPos] = 31;
            }
            else if (splitCode[stringPos].ToString() == "Q")
            {
                decodedInt[stringPos] = 32;
            }
            else if (splitCode[stringPos].ToString() == "q")
            {
                decodedInt[stringPos] = 33;
            }
            else if (splitCode[stringPos].ToString() == "R")
            {
                decodedInt[stringPos] = 34;
            }
            else if (splitCode[stringPos].ToString() == "r")
            {
                decodedInt[stringPos] = 35;
            }
            else if (splitCode[stringPos].ToString() == "S")
            {
                decodedInt[stringPos] = 36;
            }
            else if (splitCode[stringPos].ToString() == "s")
            {
                decodedInt[stringPos] = 37;
            }
            else if (splitCode[stringPos].ToString() == "T")
            {
                decodedInt[stringPos] = 38;
            }
            else if (splitCode[stringPos].ToString() == "t")
            {
                decodedInt[stringPos] = 39;
            }
            else if (splitCode[stringPos].ToString() == "U")
            {
                decodedInt[stringPos] = 40;
            }
            else if (splitCode[stringPos].ToString() == "u")
            {
                decodedInt[stringPos] = 41;
            }
            else if (splitCode[stringPos].ToString() == "V")
            {
                decodedInt[stringPos] = 42;
            }
            else if (splitCode[stringPos].ToString() == "v")
            {
                decodedInt[stringPos] = 43;
            }
            else if (splitCode[stringPos].ToString() == "W")
            {
                decodedInt[stringPos] = 44;
            }
            else if (splitCode[stringPos].ToString() == "w")
            {
                decodedInt[stringPos] = 45;
            }
            else if (splitCode[stringPos].ToString() == "X")
            {
                decodedInt[stringPos] = 46;
            }
            else if (splitCode[stringPos].ToString() == "x")
            {
                decodedInt[stringPos] = 47;
            }
            else if (splitCode[stringPos].ToString() == "Y")
            {
                decodedInt[stringPos] = 48;
            }
            else if (splitCode[stringPos].ToString() == "y")
            {
                decodedInt[stringPos] = 49;
            }
            else if (splitCode[stringPos].ToString() == "Z")
            {
                decodedInt[stringPos] = 50;
            }
            else if (splitCode[stringPos].ToString() == "z")
            {
                decodedInt[stringPos] = 51;
            }

            DecodeObject.GetComponentInChildren<TMP_InputField>().text = DecodeObject.GetComponentInChildren<TMP_InputField>().text + decodedInt[stringPos];
            stringPos++;

            number = 0;
        }

        ImportZombieAmount();
    }

    public void ImportZombieAmount()
    {
        int arrayPos = 0;
        normalZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie1.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie2.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie3.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie4.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

       
        normalZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie5.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie6.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie7.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie8.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie9.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie10.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie11.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie12.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie13.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie14.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie15.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie16.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie17.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie18.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie19.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;

        normalZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        fastZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        slowZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        deadZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        scientistZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        shadowZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
        arrayPos++;
        spawnerZombie20.GetComponentInChildren<TMP_InputField>().text = decodedInt[arrayPos].ToString();
    }
}
