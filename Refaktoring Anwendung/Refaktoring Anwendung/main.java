/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.myheincompany.refactoringjava;

import com.myheincompany.refactroingJava.dataStore.DataStore;
import com.sun.glass.ui.SystemClipboard;
import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Random;

/**
 *
 * @author Ocean
 */
public class main {
    
    public static void main(String[] args)
    {
        try
        {
            MySingleSuperClass superclass = new MySingleSuperClass();
        
            String[] answers = new String[] {"a", "b", "d"};
            Date today = new Date();
            today.setHours(0); today.setMinutes(0); today.setSeconds(0);

            System.out.println("Master GUI: Bitte machen Sie ihre Eingabe für die Lotterie (3STück):");
            System.out.print("Email: ");
            String email =  new BufferedReader(new InputStreamReader(System.in)).readLine();
            System.out.print("Message:");
            String message =  new BufferedReader(new InputStreamReader(System.in)).readLine();
            System.out.print("CreditCar: ");
            String creditCardNumber = new BufferedReader(new InputStreamReader(System.in)).readLine();
            
            int luckyNumber = new Random().nextInt() % 30;

            String result = superclass.getBestProgrammer(new DataStore().getProgrammers(), "Chef",answers, today, email,message,creditCardNumber ,luckyNumber);
            System.out.print("Und der Gewinner ist "+result);
            new BufferedReader(new InputStreamReader(System.in)).readLine();
            
        }catch(Exception ex)
        {
             System.out.print("Ups "+ex.getMessage());
        }
       
    }
    
}
