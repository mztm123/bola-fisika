﻿using System;
using System.Collections.Generic;
using System.Text;

[Serializable]
public class Question
{
    public int angle, speed, speedX, speedY, maxH, maxX, flightTime, timePassed, distance, height, result;

    public static List<QuestionType> angleDominantQuestionTypes = new List<QuestionType>() { QuestionType.Speed_AngleToMaxH, QuestionType.Speed_AngleToFlightTime,QuestionType.MaxHToFlightTime,QuestionType.Speed_AngleToTc,QuestionType.Speed_Time_AngleToHeight,QuestionType.SpeedYToMaxH,QuestionType.SpeedYToFlightTime };
    public static List<QuestionType> speedDominantQuestionTypes = new List<QuestionType>() { QuestionType.Speed_AngleToMaxX ,QuestionType.MaxH_AngleToMaxX,QuestionType.MaxH_AngleToSpeed ,QuestionType.SpeedX_FlightTimeToSpeed ,QuestionType.Angle_Time_DistanceToSpeed ,QuestionType.Speed_Time_AngleToDistance ,QuestionType.SpeedX_FlightTimeToDistance };

    // Prints all not empty variables of this question
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        if (angle != 0)
        {
            stringBuilder.Append("Angle: " + angle + " ");
        }
        if (speed != 0)
        {
            stringBuilder.Append("speed: " + speed + " ");
        }
        if (speedX != 0)
        {
            stringBuilder.Append("speedX: " + speedX + " ");
        }
        if (speedY != 0)
        {
            stringBuilder.Append("speedY: " + speedY + " ");
        }
        if (maxH != 0)
        {
            stringBuilder.Append("maxH: " + maxH + " ");
        }
        if (maxX != 0)
        {
            stringBuilder.Append("maxX: " + maxX + " ");
        }
        if (flightTime != 0)
        {
            stringBuilder.Append("flightTime: " + flightTime + " ");
        }
        if (timePassed != 0)
        {
            stringBuilder.Append("timePassed: " + timePassed + " ");
        }
        if (distance != 0)
        {
            stringBuilder.Append("distance: " + distance + " ");
        }
        if (height != 0)
        {
            stringBuilder.Append("height: " + height + " ");
        }

        return stringBuilder.ToString();
    }
}

public enum QuestionType
{
    Speed_AngleToMaxH,
    Speed_AngleToMaxX,
    Speed_AngleToFlightTime,
    MaxH_AngleToMaxX,
    MaxH_AngleToSpeed,
    MaxHToFlightTime,
    SpeedX_FlightTimeToSpeed,
    Angle_Time_DistanceToSpeed,
    Speed_AngleToTc,
    Speed_Time_AngleToHeight,
    Speed_Time_AngleToDistance,
    SpeedYToMaxH,
    SpeedX_FlightTimeToDistance,
    SpeedYToFlightTime
}


