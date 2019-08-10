/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controlforxocharactersequality;

import java.util.Scanner;

/**
 *
 * @author ABUGRA
 */
public class Controlforxocharactersequality {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int xcntr=0,ocntr=0;
        Scanner scnr = new Scanner(System.in);
        System.out.print("Enter a text:");
        String input = scnr.nextLine();
        for(char i : input.toCharArray()){
            if(i == 'x') xcntr++;
            else if(i == 'o') ocntr++;
        }
        if(xcntr == ocntr) System.out.println("X and O characters amount is equal each other");
    }    
}
