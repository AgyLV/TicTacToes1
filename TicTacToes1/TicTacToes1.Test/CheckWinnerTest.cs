using Xunit;

namespace TicTacToes1.Test
{
    public class CheckWinnerTest
    {
        [Theory]
        [InlineData(new object[] { new string[] { "X", "X", "X", "a", "b", "c", "d", "e", "f" } })]
        [InlineData(new object[] { new string[] { "a", "b", "a", "X", "X", "X", "d", "e", "f" } })]
        [InlineData(new object[] { new string[] { "a", "c", "t", "a", "b", "c", "X", "X", "X" } })]
        [InlineData(new object[] { new string[] { "X", "b", "a", "X", "c", "v", "X", "e", "f" } })]
        [InlineData(new object[] { new string[] { "e", "X", "p", "a", "X", "c", "d", "X", "f" } })]
        [InlineData(new object[] { new string[] { "a", "b", "X", "q", "p", "X", "d", "e", "X" } })]
        [InlineData(new object[] { new string[] { "X", "p", "e", "a", "X", "c", "d", "e", "X" } })]
        [InlineData(new object[] { new string[] { "f", "d", "X", "a", "X", "c", "X", "e", "f" } })]
       

        public void Winner_WhenWinner_ThenReturns1(string[] gameBoard)
        {
            int response = CheckWinner.Winner(gameBoard);

            Assert.Equal(1, response);
        }







       
        [Fact]
        public void Winner_WhenDraw_ThenReturns2()
        {


            string[] checkWinner1 = new string[] { "0", "O", "X", "O","X", "X", "X" };
            int response = CheckWinner.Winner(checkWinner1);

            Assert.Equal(1, response);



        }
    }
}