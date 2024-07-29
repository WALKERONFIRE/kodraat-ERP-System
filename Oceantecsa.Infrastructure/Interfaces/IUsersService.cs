using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oceantecsa.Infrastructure.DTOS.SP;
using Oceantecsa.Infrastructure.DTOS.User;
using Oceantecsa.Shared.DTOs;

namespace Oceantecsa.Infrastructure.Interfaces
{
    public interface IUsersService
    {
        PaginationObject<Sp_UserDto> GetAllUsers(Sp_UsersSelectParamsDto searchParams, int pageNum, int PageSize);
        Task<UserDTo> GetById(int UserID);
        Task<bool> CreateUser(UserDTo UserDto);
        Task<bool> UpdateUser(UserDTo UserDto);
        Task<bool> DeleteUser(int UserID);
        Task<bool> ChangePassword(ChangePaswordDto changePasswordDto, UserInfoDTO userInfoDTO);
        string EncryptPassword(string UserName, string Password);
        Task<LoggedUserInfoDTO> GetUserInfo(int loggedUserid);
        Task<bool> ChangeLanguage(int userID, Shared.Enum.Language language);
    }
}
