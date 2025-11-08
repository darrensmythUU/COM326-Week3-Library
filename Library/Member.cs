using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member
    {
        // Private Fields
        private int memberID;
        private string name;
        private string address;
        private int phone;

        // Get/Set Constructors
        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for Member object
        public Member(int memberMemberID, string memberName, string memberAddress, int memberPhone)
        {
            this.MemberID = memberMemberID;
            this.Name = memberName;
            this.Address = memberAddress;
            this.Phone = memberPhone;
        }

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone Number: {Phone}");
            Console.WriteLine();
        }
    }
}
