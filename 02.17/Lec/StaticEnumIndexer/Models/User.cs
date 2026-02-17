using StaticEnumIndexer.Enums;

namespace StaticEnumIndexer.Models;

internal class User
{
    public string Name { get; set; }
    public UserStatus Status { get; set; }

    public User()
    {
        Status = UserStatus.Active;
    }
}
