using System.Threading.Tasks;
using Xunit;

namespace FluentHttpExtensions.Tests.EndToEndTests
{
    public class JsonPlaceholderTests
    {
        [Fact]
        public async Task It_Can_Retrieve_A_User()
        {
            var user = await "https://jsonplaceholder.typicode.com/users/1"
                .AsAGetRequest()
                .ReadJsonResponseAs<User>();

            Assert.Equal(1, user.Id);
            Assert.Equal("Leanne Graham", user.Name);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
