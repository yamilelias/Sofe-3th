package sofe.exercise2;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ReverseParenthesisTest {

    @Test
    public void testReverseParenthesisTestOne() {
        String text = "ni(ppo)n";
        String reversedText = ReverseParenthesis.reverseParenthesis(text);
        assertEquals("nioppn", reversedText);
    }


    @Test
    public void testReverseParenthesisTestTwo() {
        String text = "ne(ar(soft) is aw(eso)me)";
        String reversedText = ReverseParenthesis.reverseParenthesis(text);
        assertEquals("neemesowa si softra", reversedText);
    }


    @Test
    public void testReverseParenthesisTestThree() {
        String text = "The ((quick (brown) (fox) jumps over the lazy) dog)";
        String reversedText = ReverseParenthesis.reverseParenthesis(text);
        assertEquals("The god quick nworb xof jumps over the lazy", reversedText);
    }

    @Test
    public void testReverseParenthesisTestFour() {
        String text = "(Preecla(mpsia is a p(regnancy compl(ication cha)racterize(d by hig)h blood )pres)su)re and signs of damage to a(nother organ syste)m";
        String reversedText = ReverseParenthesis.reverseParenthesis(text);
        assertEquals("usmpsia is a p doolb hd by higeziretcarication chalpmoc ycnangerpresalceerPre and signs of damage to aetsys nagro rehtonm", reversedText);
    }

}
