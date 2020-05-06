using System;
using System.IO;
using Xunit;

namespace SystemIO.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Can_read_bucket_list()
        {
            // Arrange | Given
            string path = "BucketList.txt";
            string[] initialContents = new[] { "See Lady Gaga" };

            File.WriteAllLines(path, initialContents);


            // Act | When
           string[] lines = File.ReadAllLines(path);

            // Assert | Then
            Assert.Equal(new[] { "See Lady Gaga" }, lines);

        }

        [Fact]
        public void Can_append_bucket_list()
        {
            // Arrange | Given
            string path = "BucketList.txt";
            string[] initialContents = new[] { "See Lady Gaga" };

            File.WriteAllLines(path, initialContents);

            string[] contentsToAppend = new[] { "base jump into a canyon" };


            // Act | When
            File.AppendAllLines(path, contentsToAppend);

            // Assert | Then
            string[] expectedContents = new[] { "See Lady Gaga", "base jump into a canyon" };
            string[] actualContents = File.ReadAllLines(path);
            Assert.Equal(expectedContents, actualContents);
        }
    }
}
