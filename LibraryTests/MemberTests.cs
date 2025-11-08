using Library;

namespace LibraryTests
{
    [TestClass]
    public sealed class MemberTests
    {
        [TestMethod]
        public void MemberConstructor_ShouldInitializeProperties()
        {
            // Arrange
            int memberId = 1;
            string name = "John Doe";
            string address = "123 Main Street";
            int phone = 123456789;

            // Act
            Library.Member member = new Library.Member(memberId, name, address, phone);

            // Assert
            Assert.AreEqual(memberId, member.MemberID);
            Assert.AreEqual(name, member.Name);
            Assert.AreEqual(address, member.Address);
            Assert.AreEqual(phone, member.Phone);
        }
    }
}
