namespace PosLibrary
{
    public partial class User
    {
        /// <summary>
        /// Хэрэглэгчийн ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Хэрэглэгчийн нэр
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Хэрэглэгчийн нууц үг
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Хэрэглэгчийн эрх
        /// </summary>
        public string Role { get; set; } // manager, cashier

       
    }
}
