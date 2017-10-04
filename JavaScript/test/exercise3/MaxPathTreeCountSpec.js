(function () {
    describe("MaxPathTreeCountSpec", function () {

        it("testMaxPathTreeCountOne", function () {
            var tree = {};
            var result = MaxPathTreeCount.maxPathCount(tree);
            expect(result).toBe(4);
        });

    });
})();