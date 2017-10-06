using System;
using Xunit;

namespace Sofe.Exercise3
{
    public class MaxPathTreeCountTest
    {
        [Fact]
        public void TestMaxPathCountShouldReturn2()
        {
            TreeNode E1 = new TreeNode(1);
            TreeNode E2 = new TreeNode(2);
            TreeNode E3 = new TreeNode(1);
            TreeNode E4 = new TreeNode(2);
            TreeNode E5 = new TreeNode(2);
            TreeNode E6 = new TreeNode(3);
            TreeNode E7 = new TreeNode(2);
            TreeNode E8 = new TreeNode(2);
            TreeNode E9 = new TreeNode(2);
            TreeNode E0 = new TreeNode(3);
            TreeNode EA = new TreeNode(1);
            TreeNode EB = new TreeNode(3);
            TreeNode EC = new TreeNode(1);
            TreeNode ED = new TreeNode(3);
            TreeNode EE = new TreeNode(1);
            TreeNode EF = new TreeNode(3);

            TreeNode D1 = new TreeNode(1, E1, E2);
            TreeNode D2 = new TreeNode(2, E3, E4);
            TreeNode D3 = new TreeNode(3, E5, E6);
            TreeNode D4 = new TreeNode(2, E7, E8);
            TreeNode D5 = new TreeNode(3, E9, E0);
            TreeNode D6 = new TreeNode(2, EA, EB);
            TreeNode D7 = new TreeNode(2, EC, ED);
            TreeNode D8 = new TreeNode(1, EE, EF);

            TreeNode C1 = new TreeNode(2, D1, D2);
            TreeNode C2 = new TreeNode(1, D3, D4);
            TreeNode C3 = new TreeNode(2, D5, D6);
            TreeNode C4 = new TreeNode(2, D7, D8);

            TreeNode B1 = new TreeNode(2, C1, C2);
            TreeNode B2 = new TreeNode(1, C3, C4);

            TreeNode tree = new TreeNode(3, B1, B2);

            Assert.Equal(2, MaxPathTreeCount.MaxPathCount(tree));
        }

        [Fact]
        public void TestMaxPathCountShouldReturn16()
        {
            TreeNode E1 = new TreeNode(3);
            TreeNode E2 = new TreeNode(3);
            TreeNode E3 = new TreeNode(3);
            TreeNode E4 = new TreeNode(3);
            TreeNode E5 = new TreeNode(3);
            TreeNode E6 = new TreeNode(3);
            TreeNode E7 = new TreeNode(3);
            TreeNode E8 = new TreeNode(3);
            TreeNode E9 = new TreeNode(3);
            TreeNode E0 = new TreeNode(3);
            TreeNode EA = new TreeNode(3);
            TreeNode EB = new TreeNode(3);
            TreeNode EC = new TreeNode(3);
            TreeNode ED = new TreeNode(3);
            TreeNode EE = new TreeNode(3);
            TreeNode EF = new TreeNode(3);

            TreeNode D1 = new TreeNode(3, E1, E2);
            TreeNode D2 = new TreeNode(3, E3, E4);
            TreeNode D3 = new TreeNode(3, E5, E6);
            TreeNode D4 = new TreeNode(3, E7, E8);
            TreeNode D5 = new TreeNode(3, E9, E0);
            TreeNode D6 = new TreeNode(3, EA, EB);
            TreeNode D7 = new TreeNode(3, EC, ED);
            TreeNode D8 = new TreeNode(3, EE, EF);

            TreeNode C1 = new TreeNode(2, D1, D2);
            TreeNode C2 = new TreeNode(2, D3, D4);
            TreeNode C3 = new TreeNode(2, D5, D6);
            TreeNode C4 = new TreeNode(2, D7, D8);

            TreeNode B1 = new TreeNode(1, C1, C2);
            TreeNode B2 = new TreeNode(1, C3, C4);

            TreeNode tree = new TreeNode(3, B1, B2);

            Assert.Equal(16, MaxPathTreeCount.MaxPathCount(tree));
        }

        [Fact]
        public void TestMaxPathCountShouldReturn9()
        {
            TreeNode E1 = new TreeNode(2);
            TreeNode E2 = new TreeNode(2);
            TreeNode E3 = new TreeNode(2);
            TreeNode E4 = new TreeNode(2);
            TreeNode E5 = new TreeNode(2);
            TreeNode E6 = new TreeNode(2);
            TreeNode E7 = new TreeNode(3);
            TreeNode E8 = new TreeNode(3);
            TreeNode E9 = new TreeNode(3);
            TreeNode E0 = new TreeNode(3);
            TreeNode EA = new TreeNode(3);
            TreeNode EB = new TreeNode(3);
            TreeNode EC = new TreeNode(3);
            TreeNode ED = new TreeNode(4);
            TreeNode EE = new TreeNode(4);
            TreeNode EF = new TreeNode(4);

            TreeNode D1 = new TreeNode(3, E1, E2);
            TreeNode D2 = new TreeNode(3, E3, E4);
            TreeNode D3 = new TreeNode(3, E5, E6);
            TreeNode D4 = new TreeNode(3, E7, E8);
            TreeNode D5 = new TreeNode(3, E9, E0);
            TreeNode D6 = new TreeNode(3, EA, EB);
            TreeNode D7 = new TreeNode(2, EC, ED);
            TreeNode D8 = new TreeNode(2, EE, EF);

            TreeNode C1 = new TreeNode(2, D1, D2);
            TreeNode C2 = new TreeNode(2, D3, D4);
            TreeNode C3 = new TreeNode(2, D5, D6);
            TreeNode C4 = new TreeNode(2, D7, D8);

            TreeNode B1 = new TreeNode(1, C1, C2);
            TreeNode B2 = new TreeNode(1, C3, C4);

            TreeNode tree = new TreeNode(3, B1, B2);

            Assert.Equal(9, MaxPathTreeCount.MaxPathCount(tree));
        }
    }
}