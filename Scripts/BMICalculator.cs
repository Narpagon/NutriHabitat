using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BMICalculator : MonoBehaviour
{
   

    //public TextMeshProUGUI age;
    public TMP_InputField fieldHeight;
    public TMP_InputField fieldWeight;
    public Text textResult;
    public TMP_Dropdown age;
    public TMP_Dropdown gender;
    //public Text BMI;
    [SerializeField]
    private FloatSO statusSO;
    //private StringSO categorySO;


    /*private void Awake()
    {
        statusSO.SetToInitialValue();
    }*/

    public void BMIresult()
    {

        //Get fieldHeight and fieldWeight from input field options and pass to float val
        float h = float.Parse(fieldHeight.text);
        float w = float.Parse(fieldWeight.text);
        int a = age.value;
        int g = gender.value;

        Debug.Log("Age is" + a.ToString());
        // Debug.Log("Height is " + h.ToString());
        // Debug.Log("Weight is: " + w.ToString());

        float BMIcalculation = w / ((h/100) * (h/100));
        //[SerializeField] BMIcalculation;
        string category = string.Empty;
        //Debug.Log("BMI is " + BMIcalculation.ToString());
        string result = string.Empty;

        //get gender
        if (g == 0) //if Female
        {
            // 14 options in dropdown menu starting 0-14
            if (a == 0) //5 years Female
            {
                if (BMIcalculation < 13.5)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.5)";
                    //categorySO = "Underweight";
                    statusSO.Value = 1;
                }

                else if (BMIcalculation >= 13.5 && BMIcalculation <= 16.8)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.5 - 16.8)";
                    statusSO.Value = 2;
                }

                else if (BMIcalculation >= 16.9 && BMIcalculation <= 18.3)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 16.9 - 18.3)";
                    statusSO.Value = 3;
                }

                else if (BMIcalculation >= 18.4)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 18.4)";
                    statusSO.Value = 4;
                }

            }
            if (a == 1) //6 years Female
            {
                if (BMIcalculation < 13.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.4)";
                }

                else if (BMIcalculation >= 13.4 && BMIcalculation <= 17.2)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.4 - 17.2)";
                }

                else if (BMIcalculation >= 17.3 && BMIcalculation <= 18.8)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 17.3 - 18.8)";
                }

                else if (BMIcalculation >= 18.9)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 18.9)";
                }

            }
            if (a == 2) //7 years Female
            {
                if (BMIcalculation < 13.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.4)";
                }

                else if (BMIcalculation >= 13.4 && BMIcalculation <= 17.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.4 - 17.6)";
                }

                else if (BMIcalculation >= 17.7 && BMIcalculation <= 19.6)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 17.7 - 19.6)";
                }

                else if (BMIcalculation >= 19.7)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 19.7)";
                }

            }
            if (a == 3) //8 years Female
            {
                if (BMIcalculation < 13.5)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.5)";
                }

                else if (BMIcalculation >= 13.5 && BMIcalculation <= 18.4)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.5 - 18.4)";
                }

                else if (BMIcalculation >= 18.5 && BMIcalculation <= 20.6)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 18.5 - 20.6)";
                }

                else if (BMIcalculation >= 20.7)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 20.7)";
                }

            }
            if (a == 4) //9 years Female
            {
                if (BMIcalculation < 13.7)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.7)";
                }

                else if (BMIcalculation >= 13.7 && BMIcalculation <= 19.2)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.7 - 19.2)";
                }

                else if (BMIcalculation >= 19.3 && BMIcalculation <= 21.8)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 19.3 - 21.8)";
                }

                else if (BMIcalculation >= 21.9)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 21.9)";
                }

            }
            if (a == 5) //10 years Female
            {
                if (BMIcalculation < 14)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 14)";
                }

                else if (BMIcalculation >= 14 && BMIcalculation <= 19.9)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14 - 19.9)";
                }

                else if (BMIcalculation >= 20 && BMIcalculation <= 22.9)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 20 - 22.9)";
                }

                else if (BMIcalculation >= 30)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 30)";
                }

            }
            if (a == 6) //11 years Female
            {
                if (BMIcalculation < 14.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 14.4)";
                }

                else if (BMIcalculation >= 14.4 && BMIcalculation <= 20.8)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14.4 - 20.8)";
                }

                else if (BMIcalculation >= 20.9 && BMIcalculation <= 24.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 20.9 - 24.2)";
                }

                else if (BMIcalculation >= 24.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 24.3)";
                }

            }
            if (a == 7) //12 years Female
            {
                if (BMIcalculation < 14.8)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 14.8)";
                }

                else if (BMIcalculation >= 14.8 && BMIcalculation <= 21.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14.8 - 21.6)";
                }

                else if (BMIcalculation >= 21.7 && BMIcalculation <= 25.3)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 21.7 - 25.3)";
                }

                else if (BMIcalculation >= 25.4)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 25.4)";
                }

            }
            if (a == 8) //13 years Female
            {
                if (BMIcalculation < 15.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 15.4)";
                }

                else if (BMIcalculation >= 15.4 && BMIcalculation <= 22.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 15.4 - 22.6)";
                }

                else if (BMIcalculation >= 22.7 && BMIcalculation <= 26.4)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 22.7 - 26.4)";
                }

                else if (BMIcalculation >= 26.5)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 26.5)";
                }

            }
            if (a == 9) //14 years Female
            {
                if (BMIcalculation < 15.8)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 15.8)";
                }

                else if (BMIcalculation >= 15.8 && BMIcalculation <= 23.4)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 15.8 - 23.4)";
                }

                else if (BMIcalculation >= 23.5 && BMIcalculation <= 27.5)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 23.5 - 27.5)";
                }

                else if (BMIcalculation >= 27.6)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 27.6)";
                }

            }
            if (a == 10) //15 years Female
            {
                if (BMIcalculation < 16.5)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 16.5)";
                }

                else if (BMIcalculation >= 16.5 && BMIcalculation <= 24.1)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 16.5 - 24.1)";
                }

                else if (BMIcalculation >= 24.2 && BMIcalculation <= 28.1)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 24.2 - 28.1)";
                }

                else if (BMIcalculation >= 28.2)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 28.2)";
                }

            }
            if (a == 11) //16 years Female
            {
                if (BMIcalculation < 16.8)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 16.8)";
                }

                else if (BMIcalculation >= 16.8 && BMIcalculation <= 24.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 16.8 - 24.6)";
                }

                else if (BMIcalculation >= 24.7 && BMIcalculation <= 28.9)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 24.7 - 28.9)";
                }

                else if (BMIcalculation >= 29)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 29)";
                }

            }
            if (a == 12) //17 years Female
            {
                if (BMIcalculation < 17.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 17.4)";
                }

                else if (BMIcalculation >= 17.4 && BMIcalculation <= 25.3)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 17.4 - 25.3)";
                }

                else if (BMIcalculation >= 25.4 && BMIcalculation <= 29.6)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 25.4 - 29.6)";
                }

                else if (BMIcalculation >= 29.7)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 29.7)";
                }

            }
            if (a == 13) //18 years Female
            {
                if (BMIcalculation < 17.5)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 17.5)";
                }

                else if (BMIcalculation >= 17.5 && BMIcalculation <= 25.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 17.5 - 25.6)";
                }

                else if (BMIcalculation >= 25.7 && BMIcalculation <= 30.3)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 25.7 - 30.3)";
                }

                else if (BMIcalculation >= 30.4)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 30.4)";
                }

            }
            if (a == 14) //19 years Female
            {
                if (BMIcalculation < 17.8)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 17.8)";
                }

                else if (BMIcalculation >= 17.8 && BMIcalculation <= 26.1)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 17.8 - 26.1)";
                }

                else if (BMIcalculation >= 26.2 && BMIcalculation <= 31)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 26.2 - 31)";
                }

                else if (BMIcalculation >= 31.1)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 31.1)";
                }

            }
        }

        
        if (g == 1)//if Male
        {
            // 14 options in dropdown menu array starting 0-14
            if (a == 0) //5 years Male
            {
                if (BMIcalculation < 13.8)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.8)";
                }

                else if (BMIcalculation >= 13.8 && BMIcalculation <= 16.8)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.8 - 16.8)";
                }

                else if (BMIcalculation >= 16.9 && BMIcalculation <= 17.9)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 16.9 - 17.9)";
                }

                else if (BMIcalculation >= 18)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 18)";
                }

            }
            if (a == 1) //6 years Male
            {
                if (BMIcalculation < 13.7)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.7)";
                }

                else if (BMIcalculation >= 13.7 && BMIcalculation <= 17)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.7 - 17)";
                }

                else if (BMIcalculation >= 17.1 && BMIcalculation <= 18.4)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 17.1 - 18.4)";
                }

                else if (BMIcalculation >= 18.5)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 18.5)";
                }

            }
            if (a == 2) //7 years Male
            {
                if (BMIcalculation < 13.6)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.6)";
                }

                else if (BMIcalculation >= 13.6 && BMIcalculation <= 17.4)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.6 - 17.4)";
                }

                else if (BMIcalculation >= 17.5 && BMIcalculation <= 19.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 17.5 - 19.2)";
                }

                else if (BMIcalculation >= 19.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 19.3)";
                }

            }
            if (a == 3) //8 years Male
            {
                if (BMIcalculation < 13.7)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.7)";
                }

                else if (BMIcalculation >= 13.7 && BMIcalculation <= 17.9)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 13.7 - 17.9)";
                }

                else if (BMIcalculation >= 18 && BMIcalculation <= 20)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 18 - 20)";
                }

                else if (BMIcalculation >= 20.1)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 20.1)";
                }

            }
            if (a == 4) //9 years Male
            {
                if (BMIcalculation < 13.9)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 13.9)";
                }

                else if (BMIcalculation >= 14 && BMIcalculation <= 18.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14 - 18.6)";
                }

                else if (BMIcalculation >= 18.7 && BMIcalculation <= 21.1)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 18.7 - 21.1)";
                }

                else if (BMIcalculation >= 21.2)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 21.2)";
                }

            }
            if (a == 5) //10 years Male
            {
                if (BMIcalculation < 14)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 14)";
                }

                else if (BMIcalculation >= 14 && BMIcalculation <= 19.9)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14 - 19.9)";
                }

                else if (BMIcalculation >= 20 && BMIcalculation <= 22.9)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 20 - 22.9)";
                }

                else if (BMIcalculation >= 23)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 23)";
                }

            }
            if (a == 6) //11 years Male
            {
                if (BMIcalculation < 14.6)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 14.6)";
                }

                else if (BMIcalculation >= 14.6 && BMIcalculation <= 20.2)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 14.6 - 20.2)";
                }

                else if (BMIcalculation >= 20.3 && BMIcalculation <= 21.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 20.3 - 21.2)";
                }

                else if (BMIcalculation >= 21.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 21.3)";
                }

            }
            if (a == 7) //12 years Male
            {
                if (BMIcalculation < 15)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 15)";
                }

                else if (BMIcalculation >= 15 && BMIcalculation <= 21)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 15 - 21)";
                }

                else if (BMIcalculation >= 21.1 && BMIcalculation <= 24.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 21.1 - 24.2)";
                }

                else if (BMIcalculation >= 24.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 24.3)";
                }

            }
            if (a == 8) //13 years Male
            {
                if (BMIcalculation < 15.4)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 15.4)";
                }

                else if (BMIcalculation >= 15.4 && BMIcalculation <= 21.8)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 15.4 - 21.8)";
                }

                else if (BMIcalculation >= 21.9 && BMIcalculation <= 25.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 21.9 - 25.2)";
                }

                else if (BMIcalculation >= 25.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 25.3)";
                }

            }
            if (a == 9) //14 years Male
            {
                if (BMIcalculation < 15.9)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 15.9)";
                }

                else if (BMIcalculation >= 15.9 && BMIcalculation <= 22.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 15.9 - 22.6)";
                }

                else if (BMIcalculation >= 22.7 && BMIcalculation <= 26)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 22.7 - 26)";
                }

                else if (BMIcalculation >= 26.1)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 26.1)";
                }

            }
            if (a == 10) //15 years Male
            {
                if (BMIcalculation < 16.5)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 16.5)";
                }

                else if (BMIcalculation >= 16.5 && BMIcalculation <= 23.4)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 16.5 - 23.4)";
                }

                else if (BMIcalculation >= 23.5 && BMIcalculation <= 26.8)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 23.5 - 26.8)";
                }

                else if (BMIcalculation >= 26.9)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 26.9)";
                }

            }
            if (a == 11) //16 years Male
            {
                if (BMIcalculation < 17.1)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 17.1)";
                }

                else if (BMIcalculation >= 17.1 && BMIcalculation <= 24.2)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 17.1 - 24.2)";
                }

                else if (BMIcalculation >= 24.3 && BMIcalculation <= 27.6)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 24.3 - 27.6)";
                }

                else if (BMIcalculation >= 27.7)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 27.7)";
                }

            }
            if (a == 12) //17 years Male
            {
                if (BMIcalculation < 17.6)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 17.6)";
                }

                else if (BMIcalculation >= 17.6 && BMIcalculation <= 24.8)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 17.6 - 24.8)";
                }

                else if (BMIcalculation >= 24.9 && BMIcalculation <= 28.2)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 24.9 - 28.2)";
                }

                else if (BMIcalculation >= 28.3)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 28.3)";
                }

            }
            if (a == 13) //18 years Male
            {
                if (BMIcalculation < 18.2)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 18.2)";
                }

                else if (BMIcalculation >= 18.2 && BMIcalculation <= 25.6)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 18.2 - 25.6)";
                }

                else if (BMIcalculation >= 25.7 && BMIcalculation <= 28.8)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 25.7 - 28.8)";
                }

                else if (BMIcalculation >= 28.9)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 28.9)";
                }

            }
            if (a == 14) //19 years Male
            {
                if (BMIcalculation < 18.7)
                {
                    category = "Underweight, less than the 5th percentile (BMI > 18.7)";
                }

                else if (BMIcalculation >= 18.7 && BMIcalculation <= 26.4)
                {
                    category = "Healthy weight." + "\n" + "Between the 5th - 85th percentile (BMI Range: 18.7 - 26.4)";
                }

                else if (BMIcalculation >= 26.5 && BMIcalculation <= 29.7)
                {
                    category = "Overweight." + "\n" + "Between the 85th to less than the 95th percentile (BMI Range: 26.5 - 29.7)";
                }

                else if (BMIcalculation >= 29.8)
                {
                    category = "Obese." + "\n" + "Equal to or greater then the 95th percentile (BMI >= 29.8)";
                }

            }
        }

        BMICalculator bMICalculator = new BMICalculator();
        textResult.text = "Your BMI is :" + BMIcalculation.ToString("#.#") + "\n" 
            + "You are: " + category;

        //BMIcalculation = 

        //Initialise the Text to say the first value of the Dropdown
       // m_Text.text = "First Value : " + m_Dropdown.value;
    }

    
}
