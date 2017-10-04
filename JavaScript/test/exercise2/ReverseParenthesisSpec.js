(function () {
    describe("ReverseParenthesis", function () {

        it("testReverseParenthesisTestOne", function () {
            var text = "ni(ppo)n";
            var reversedText = ReverseParenthesis.reverseParenthesis(text);
            expect(reversedText).toBe("nioppn");
        });

        it("testReverseParenthesisTestTwo", function () {
            var text = "ne(ar(soft) is aw(eso)me)";
            var reversedText = ReverseParenthesis.reverseParenthesis(text);
            expect(reversedText).toBe("neemesowa si softra");
        });

        it("testReverseParenthesisTestThree", function () {
            var text = "The ((quick (brown) (fox) jumps over the lazy) dog)";
            var reversedText = ReverseParenthesis.reverseParenthesis(text);
            expect(reversedText).toBe("The god quick nworb xof jumps over the lazy");
        });

        it("testReverseParenthesisTestFour", function () {
            var text = "(Preecla(mpsia is a p(regnancy compl(ication cha)racterize(d by hig)h blood )pres)su)re and signs of damage to a(nother organ syste)m";
            var reversedText = ReverseParenthesis.reverseParenthesis(text);
            expect(reversedText).toBe("usmpsia is a p doolb hd by higeziretcarication chalpmoc ycnangerpresalceerPre and signs of damage to aetsys nagro rehtonm");
        });

    });
})();