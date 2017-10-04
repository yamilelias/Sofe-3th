using System;
using Xunit;

namespace Sofe.extra
{
    public class ReverseParenthesisTest 
    {

        [Fact]
        public void TestReverseParenthesisTestOne() 
        {
            string text = "ni(ppo)n";
            string reversedText = ReverseParenthesis.ReverseParenthesis(text);
            Assert.Equal("nioppn", reversedText);
        }


        [Fact]
        public void TestReverseParenthesisTestTwo() 
        {
            string text = "ne(ar(soft) is aw(eso)me)";
            string reversedText = ReverseParenthesis.ReverseParenthesis(text);
            Assert.Equal("neemesowa si softra", reversedText);
        }


        [Fact]
        public void TestReverseParenthesisTestThree() 
        {
            string text = "The ((quick (brown) (fox) jumps over the lazy) dog)";
            string reversedText = ReverseParenthesis.ReverseParenthesis(text);
            Assert.Equal("The god quick nworb xof jumps over the lazy", reversedText);
        }

        [Fact]
        public void TestReverseParenthesisTestFour() 
        {
            string text = "(Preecla(mpsia is a p(regnancy compl(ication cha)racterize(d by hig)h blood )pres)su)re and signs of damage to a(nother organ syste)m";
            string reversedText = ReverseParenthesis.ReverseParenthesis(text);
            Assert.Equal("usmpsia is a p doolb hd by higeziretcarication chalpmoc ycnangerpresalceerPre and signs of damage to aetsys nagro rehtonm", reversedText);
        }

    }
}