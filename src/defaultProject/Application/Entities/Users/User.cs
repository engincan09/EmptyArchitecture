using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities.Users
{
    /// <summary>
    /// Tüm kullanıcıların tutulduğu tablodur.
    /// </summary>
    public class User : Entity
    {
        public User()
        {
        }

        public User(int id, string name, string surname, string fullName, string userName, string password, DataStatus dataStatus, int? createdUserId, DateTime createdAt):this()
        {
            Id = id;
            Name = name;
            Surname = surname;
            FullName = fullName;
            UserName = userName;
            Password = password;
            DataStatus = dataStatus;
            CreatedUserId = createdUserId;
            CreatedAt = createdAt;
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

    }
}
