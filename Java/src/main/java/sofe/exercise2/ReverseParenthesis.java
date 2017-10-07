package sofe.exercise2;

import java.util.regex.*;
import java.lang.StringBuilder;

public class ReverseParenthesis {
    public static void main(String[] args) {
       
        String text = "The ((quick (brown) (fox) jumps over the lazy) dog)";
        reverseParenthesis(text);
    }
    public static String reverseParenthesis(String text) {
        String s = "";
        String ds = "";
     Matcher m = Pattern.compile("\\(.+\\)").matcher(text);
     while(m.find()) {
        String aux = m.group(1);
        System.out.println(aux);
        String ss =  reverseParenthesis(aux);
        char[] hola = ss.toCharArray();
        
        for (int i=hola.length-1; i>0; i--) 
        {
            ds+=hola[i];
        }
//        s = new StringBuilder(ss).reverse().toString();
        System.out.println(ds);
     }
        return ds;
    }
    
    private static String getParenthesesContent(String str){
        return str.substring(str.indexOf("(")+1,str.indexOf(")"));
    }
}
