using Core.Persistence.Repositories;

namespace Domain.Entities.Users
{
    /// <summary>
    /// Tüm kullanıcıların tutulduğu tablodur.
    /// </summary>
    public class User : Entity
    {
        public User()
        {
        }

        public User(int id, string name, string surname, string fullName, string userName, string password, string email, DataStatus dataStatus, int? createdUserId, int? updatedUserId, DateTime createdAt, DateTime updatedAt) :this()
        {
            Id = id;
            Name = name;
            Surname = surname;
            FullName = fullName;
            UserName = userName;
            Password = password;
            Email = email;
            DataStatus = dataStatus;
            CreatedUserId = createdUserId;
            UpdatedUserId = updatedUserId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Tablo tekil bilgisidir.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kullanıcı isim bilgisinin tutulduğu alandır
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Kullanıcı soyisim bilgisinin tutulduğu alandır
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// İsim ve soyisim bilgisinin toplu tutulduğu alandır
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Kullanıcı ad bilgisidir.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Kullanıcı şifre bilgisidir.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Kullanıcı email bilgisidir.
        /// </summary>
        public string Email { get; set; }

    }
}
