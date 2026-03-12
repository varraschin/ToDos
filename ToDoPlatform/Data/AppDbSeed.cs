using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToDoPlatform.Models;

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

        #region  Popular dados de Usuário
        List<AppUser> users = new()
        {
            new AppUser()
            {
                Id = "0a1d1605-71d1-4ea5-8940-c75234d82850",
                Email = "marcelo@gmail.com",
                NormalizedEmail = "MARCELO@GMAIL.COM",
                UserName = "marcelo@gmail.com",
                NormalizedUserName = "MARCELO@GMAIL.COM",
                LockoutEnabled = false,
                EmailConfirmed = true,
                Name = "Marcelo",
                ProfilePicture = "/img/users/0a1d1605-71d1-4ea5-8940-c75234d82850.png"
            },

            new AppUser()
            {
                Id = "c9a69c72-4c02-4702-84a8-f60f9323069d",
                Email = "pedrocertezas@gmail.com",
                NormalizedEmail = "PEDROCERTEZAS@GMAIL.COM",
                UserName = "pedrocertezas@gmail.com",
                NormalizedUserName = "PEDROCERTEZAS@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Name = "Pedro Certezas",
                ProfilePicture = "/img/users/0a1d1605-71d1-4ea5-8940-c75234d82850.png"
            },

        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<AppUser>().HasData(users);
        #endregion

        #region Popular Dados de Usuário Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {

            new IdentityUserRole<string>()
            {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>()
            {
                UserId = users[1].Id,
                RoleId = roles[1].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region Popular as Tarefas do usuário
        List<ToDo> toDos = new()
        {
            new ToDo()
            {
                Id = 1,
                Title = "Dormir",
                Description = "dormir dormir",
                UserId = users[1].Id
            },
            new ToDo()
            {
                Id = 2,
                Title = "Roupa Lavar",
                Description = "roupa roupa",
                UserId = users[1].Id
            },
            new ToDo()
            {
                Id = 3,
                Title = "Lavar Roupa",
                Description = "lavar lavar",
                UserId = users[1].Id
            },
        };
        builder.Entity<ToDo>().HasData(toDos);
        #endregion
    }
}
