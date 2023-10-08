using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoDeIdentity.Identity;

public class MyIdentityDBContext : IdentityDbContext<MyUser, MyRol, String>
{
    public MyIdentityDBContext(DbContextOptions options) : base(options)
    {
    }
}
