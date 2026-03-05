using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ToDoPlatform.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Perfis de Usuários
        List<IdentityRole> roles = new()
        {
            new()
            {
                Id = "e41c0ae5-b573-4c33-9413-a7a2c52d7c7c",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new()
            {
                Id = "105d7585-f875-478c-8420-add36d05f532",
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular Usuário
        
        #endregion
    }
}
