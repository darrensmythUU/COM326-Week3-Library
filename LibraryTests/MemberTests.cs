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

        [TestMethod]
        public void NameProperty_ShouldGetAndSet()
        {
            // Arrange
            Library.Member member = new Member(1, "John Doe", "123 Main Street", 123456789);
            string newName = "Jane Doe";

            // Act
            member.Name = newName;

            // Assert
            Assert.AreEqual(newName, member.Name);
        }

        [TestMethod]
        public void AddressProperty_ShouldGetAndSet()
        {
            // Arrange
            Library.Member member = new Member(1, "John Doe", "123 Main Street", 123456789);
            string newAddress = "456 Main Street";

            // Act
            member.Address = newAddress;

            // Assert
            Assert.AreEqual(newAddress, member.Address);
        }

        [TestMethod]
        public void PhoneProperty_ShouldGetAndSet()
        {
            // Arrange
            Library.Member member = new Member(1, "John Doe", "123 Main Street", 123456789);
            int phone = 987654321;

            // Act
            member.Phone = phone;

            // Assert
            Assert.AreEqual(phone, member.Phone);
        }
    }
}
