﻿
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Globalization;

public class CalendarPopup : MonoBehaviour
{

    public GameObject[] dayLabels;         //Holds 35 labels
    public string[] Months;             //Holds the months
    public Text HeaderLabel;         //The label used to show the Month

    [SerializeField]
    private int monthCounter = DateTime.Now.Month - 1;
    [SerializeField]
    private int yearCounter = 0;

    [SerializeField]
    private DateTime iMonth;
    [SerializeField]
    private DateTime curDisplay;
    public int Nbrejourmois;

    void Start()
    {
        Debug.Log("Montcounter = " + monthCounter);
        CreateMonths();
        CreateCalendar();
        Nbrejourmois = (DateTime.Now.Day);
    }

    /*Adds al the months to the Months Array and sets the current month
    in the header label*/
    void CreateMonths()
    {
        Months = new string[12];
        iMonth = new DateTime(2000, 1, 1);

        for (int i = 0; i < 12; ++i)
        {
            iMonth = new DateTime(DateTime.Now.Year, i + 1, 1);
            Months[i] = iMonth.ToString("MMMM");
        }
        iMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // The magical Line :)
        HeaderLabel.text = Months[DateTime.Now.Month - 1] + " " + DateTime.Now.Year;
    }

    /*Sets the days to their correct labels*/
    void CreateCalendar()
    {
        curDisplay = iMonth;
        Debug.Log(iMonth);
        while (curDisplay.Month == iMonth.Month)
        {
            dayLabels[curDisplay.Day - 1].GetComponentInChildren<Text>().text = curDisplay.Day.ToString();
            curDisplay = curDisplay.AddDays(1);
        }
    }



    /*when right arrow clicked go to next month */
    public void NextMonth()
    {
        monthCounter++;
        if (monthCounter > 11)
        {
            monthCounter = 0;
            yearCounter++;
        }

        HeaderLabel.text = Months[monthCounter] + " " + (DateTime.Now.Year + yearCounter);
        clearLabels();
        iMonth = iMonth.AddMonths(1);
        CreateCalendar();
    }

    /*when left arrow clicked go to previous month */
    public void PreviousMonth()
    {
        monthCounter--;
        if (monthCounter < 0)
        {
            monthCounter = 11;
            yearCounter--;
        }

        HeaderLabel.text = Months[monthCounter] + " " + (DateTime.Now.Year + yearCounter);
        clearLabels();
        iMonth = iMonth.AddMonths(-1);
        CreateCalendar();
    }

    /*clears all the day labels*/
    void clearLabels()
    {
        for (int x = 0; x < dayLabels.Length; x++)
        {
            dayLabels[x].GetComponentInChildren<Text>().text = null;
        }
    }
}
