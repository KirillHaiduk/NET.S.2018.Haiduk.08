using System.Collections.Generic;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class that describes Bank client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Firstname of client
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Lastname of client
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Passport number of client
        /// </summary>
        public string Passport { get; set; }

        /// <summary>
        /// Email adress of client
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Overriding of System.Object method Equals
        /// </summary>
        /// <param name="obj">Given object to compare with Client instance</param>
        /// <returns>True if Client instance is equal to given object; otherwise, false</returns>        
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   Firstname == client.Firstname &&
                   Lastname == client.Lastname &&
                   Passport == client.Passport &&
                   Email == client.Email;
        }

        /// <summary>
        /// Overriding of System.Object method GetHashCode
        /// </summary>
        /// <returns>Hashcode of Client instance</returns>
        public override int GetHashCode()
        {
            var hashCode = 2056398814;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Firstname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lastname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Passport);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }

        /// <summary>
        /// String representation of Client instance
        /// </summary>
        /// <returns>Information about client as string</returns>
        public override string ToString() => string.Format("Firstame: {0}\nLastname: {1}\nPassport number: {2}\nEmail: {3}", this.Firstname, this.Lastname, this.Passport, this.Email);

        /// <summary>
        /// Defining operator '==' for comparing two Client instances
        /// </summary>
        /// <param name="clientA">1st Client instance</param>
        /// <param name="clientB">2nd Client instance</param>
        /// <returns>True if instances are equal; otherwise, false</returns>
        public static bool operator ==(Client clientA, Client clientB) => clientA.Firstname == clientB.Firstname && clientA.Lastname == clientB.Lastname && clientA.Passport == clientB.Passport;

        /// <summary>
        /// Defining operator '!=' for comparing two Client instances
        /// </summary>
        /// <param name="clientA">1st Client instance</param>
        /// <param name="clientB">2nd Client instance</param>
        /// <returns>True if instances are not equal; otherwise, false</returns>
        public static bool operator !=(Client clientA, Client clientB) => clientA.Firstname != clientB.Firstname || clientA.Lastname != clientB.Lastname || clientA.Passport != clientB.Passport;
    }
}
