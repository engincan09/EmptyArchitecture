namespace Core.Persistence.Repositories;

/// <summary>
/// Base entity
/// </summary>
public class Entity
{
    /// <summary>
    /// Verinin durum bilgisidir.
    /// </summary>
    public DataStatus DataStatus { get; set; }

    /// <summary>
    /// Kaydın oluşturan kullanıcı bilgisidir.
    /// </summary>
    public int? CreatedUserId { get; set; }

    /// <summary>
    /// Kaydın oluşturulma tarih bilgisidir.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public Entity()
    {
    }

    public Entity(DataStatus dataStatus, int? createdUserId, DateTime createdAt) : this()
    {
        DataStatus = dataStatus;
        CreatedUserId = createdUserId;
        CreatedAt = createdAt;
    }
}

/// <summary>
/// Verilerin durum bilgisini tutan alandır. Sistem üzerinde hiçbir veri silinmez
/// </summary>
public enum DataStatus
{
    /// <summary>
    /// Verilerin silinme durum bilgisidir.
    /// </summary>
    Deleted = 1,

    /// <summary>
    /// Verilen aktiflik durum bilgisidir.
    /// </summary>
    Activated,

    /// <summary>
    /// Veriyi pasife alınıp/alınmadığının bilgisidir.
    /// </summary>
    DeActivated
}