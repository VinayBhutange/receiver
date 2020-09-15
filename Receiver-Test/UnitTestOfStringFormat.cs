using Xunit;
namespace Receiver.Test
{
    public class UnitTestOfStringFormat
    {
        [Fact]
        public void CheckForInvalidStringWhenStringEndsWithInvalidCharacter()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "hello@96";
            Assert.True(formatComment.RemoveInvalidCharacters(testString) == "hello");
        }

        [Fact]
        public void CheckForInvalidStringWhenStringStartsWithInvalidCharacter()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "67,remove";
            Assert.True(formatComment.RemoveInvalidCharacters(testString) == "remove");

        }

        [Fact]
        public void CheckForInvalidStringWhenStringHasInvalidCharactersInBetween()
        {
            FormatComment formatComment = new FormatComment();
            string testString = "rem12}o{ve";
            Assert.True(formatComment.RemoveInvalidCharacters(testString) == "remove");

        }
    }
}
