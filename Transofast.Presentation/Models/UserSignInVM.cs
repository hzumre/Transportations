﻿namespace Transofast.Presentation.Models
{
    public class UserSignInVM
    {
        //[Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        //[Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
