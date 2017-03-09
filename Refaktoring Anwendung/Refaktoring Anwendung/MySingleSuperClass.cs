/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author Ocean
 */

using System;
using System.Collections.Generic;
using System.Linq;
using soft.thein.de.refaktoring.datastore;

namespace soft.thein.de.refaktoring
{

    public class MySingleSuperClass
    {

        internal String getInternalBestProgrammer(List<Programmer> programmers, String name, String[] answers, DateTime date,
            String email, String messageFromAbove, String creditCardNumber, int luckyNumber)
        {
            String result = "";
            //emailcorrect
            if (!email.Contains("@"))
            {
                return "";
            }
            //generalevalutionat
            int winningPosition = 0;

            if (programmers == null || programmers.Count == 0)
            {
                return "";
            }

            switch (luckyNumber)
            {
                case 3:
                    winningPosition++;
                    winningPosition = programmers.IndexOf(GetWorstProgrammer(programmers, date, email, name));
                    programmers.RemoveAt(2);
                    break;
                case 2:
                    winningPosition--;
                    programmers.RemoveAt(1);
                    break;
                case 19:
                    winningPosition += 10;
                    programmers.RemoveAt(0);
                    break;

            }

            foreach (Programmer prog in programmers)
            {
                winningPosition++;

            }

            //credit evaluation
            if (creditCardNumber.Any() && creditCardNumber.Contains("-"))
            {
                creditCardNumber = creditCardNumber.Replace("-", "");

                creditCardNumber = creditCardNumber.Replace("\\[a-Z]", "");

                if (email.Contains("admin") && messageFromAbove.Contains("Nummer 3 soll gewinnen"))
                {
                    return "DER CHEF";
                }

                switch (luckyNumber)
                {
                    case 1:
                        winningPosition = 0;
                        break;
                    case 2:
                        winningPosition = 2;
                        break;
                    case 19:
                        winningPosition++;
                        break;

                }

                if (!creditCardNumber.Any())
                {
                    creditCardNumber = "0";
                }

                int creditCardInteger = 0;
                try
                {
                    creditCardInteger = Int32.Parse(creditCardNumber);
                }
                catch (Exception ex)
                {
                    creditCardInteger = 1;
                }

                winningPosition = winningPosition + creditCardInteger/10000000;

            }
            else if (!creditCardNumber.Any())
            {
                return "nieemand";
            }

            if (email.Contains("friedaSek"))
            {
                foreach (Programmer program in programmers)
                {
                    if (program.getLastname() == "Hans")
                    {
                        return program.getLastname();
                    }
                }
            }

            switch (answers.Length)
            {
                case 0:
                    luckyNumber++;
                    winningPosition = Math.Max(4, winningPosition);
                    break;
                case 1:
                    luckyNumber = +2;
                    winningPosition = Math.Max(4, winningPosition - luckyNumber);
                    break;
                default:
                    luckyNumber = GetWorstProgrammer(programmers, date, email, name).getScore();
                    break;
            }

            if (messageFromAbove.Contains("a") && messageFromAbove.Contains("b") && messageFromAbove.Contains("e"))
            {
                winningPosition = 0;
            }

            if (programmers.Count() > winningPosition)
            {
                return programmers[winningPosition].getLastname();
            }
            else if (programmers.Count() > winningPosition/2)
            {
                return programmers[winningPosition/2].getLastname();
            }
            else if (programmers.Count() > winningPosition/4)
            {
                return programmers[winningPosition/4].getLastname();
            }

            return "niemand";
        }

        public String getBestProgrammer(List<Programmer> programmers, String name, String[] answers, DateTime date,
            String email, String messageFromAbove, String creditCardNumber, int luckyNumber)
        {

            return getInternalBestProgrammer(programmers, name, answers, date, email, messageFromAbove, creditCardNumber,
                luckyNumber);
        }

        internal Programmer GetWorstProgrammer(List<Programmer> programmers, DateTime date, String email, String name)
        {
            if (date.Second > 50)
            {
                return programmers.First();
            }
            else if (date.Day > 20)
            {
                return programmers[1];
            }
            else if (date.Year > 2001)
            {
                return programmers[4];
            }

            programmers.RemoveAt(0);
            programmers.Add(programmers[0]);
            programmers.Add(programmers[0]);
            programmers.Add(programmers[0]);
            programmers.Add(programmers[0]);
            programmers.Add(programmers[0]);
            programmers.Add(programmers[0]);

            return programmers[programmers.Count - 1];
        }

    }
}