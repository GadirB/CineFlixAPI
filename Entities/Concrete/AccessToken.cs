using Core.Entities;

namespace Entities.Concrete;

public class AccessToken : IEntity
{
    public long Id { get; set; }
    public string Token { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime CreateDate { get; set; }
    public long CreateUserId { get; set; }
    public DateTime ModifyDate { get; set; }
    public long ModifyUserId { get; set; }
    public bool IsDeleted { get; set; }
}
