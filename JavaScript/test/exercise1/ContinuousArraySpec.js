(function () {
    describe("ContinuousArray", function () {

        it("testAlmostIncreasingSequenceOne", function () {
            var array = [-30, -19, 123, -17, -5, 1, 2, 3, 12, 43, 45];
            var isSequence = ContinuousArray.isAlmostIncreasingSequence(array);
            expect(isSequence).toBe(true);

        });

        it("testAlmostIncreasingSequenceTwo", function () {
            var array = [1, 2, 3, 6, 3, 7];
            var isSequence = ContinuousArray.isAlmostIncreasingSequence(array);
            expect(isSequence).toBe(true);
        });

        it("testAlmostIncreasingSequenceThree", function () {
            var array = [10, 1, 2, 3, 4, 5, 6, 1];
            var isSequence = ContinuousArray.isAlmostIncreasingSequence(array);
            expect(isSequence).toBe(false);
        });

        it("testAlmostIncreasingSequenceFour", function () {
            var array = [-127, -64, -50, -10, 2, 4, 5, 6, 7, 8, 12, 16, 40];
            var isSequence = ContinuousArray.isAlmostIncreasingSequence(array);
            expect(isSequence).toBe(true);
        });

    });
})();