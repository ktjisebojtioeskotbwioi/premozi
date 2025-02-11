﻿using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace premozi.Models
{
    public class User
    {
        public User(string username, string password, string email)
        {

            creation_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        [Required] public int id { get; set; }
        [Required, MinLength(6), MaxLength(20)] public string username { get; set; }
        [Required, MinLength(8), MaxLength(20)] public string password { get; set; }
        [Required, EmailAddress, MinLength(3), MaxLength(40)] public string email { get; set; }
        [Required] public int status { get; set; } = 1;
        [Required] public string creation_Time { get; set; }
    }
}