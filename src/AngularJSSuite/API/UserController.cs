﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AngularJSSuite.Models;
using System.Net.Http;
using AngularJSSuite.Services.Entities;
using AngularJSSuite.Service.Interface;
using AngularJSSuite.Service.Entities;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularJSSuite.API
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        [FromServices]
        public IUserService UserService { get; set; }


        //readonly List<User> _user = new List<User>() {
        //    new User { ID = 1, UserName = "Bristleback", Name="Strength"},
        //    new User { ID = 2, UserName ="Abbadon", Name="Strength"},
        //    new User { ID = 3, UserName ="Spectre", Name="Agility"},
        //    new User { ID = 4, UserName ="Juggernaut", Name="Agility"},
        //    new User { ID = 5, UserName ="Lion", Name="Intelligence"},
        //    new User { ID = 6, UserName ="Zues", Name="Intelligence"},
        //    new User { ID = 7, UserName ="Trent", Name="Strength"},
        //};


        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserService.GetAll().AsEnumerable();
        }

        //// GET api/values/7
        //[HttpGet("{id}")]
        //public User Get(int id)
        //{
        //    var ur = _user.FirstOrDefault(u => u.ID == id);
        //    return ur;
        //}

        [Route("RegisterUser")]
        [HttpPost]
        public AccountsApiModel RegisterUser(UserDTO registerUserDTO)
        {
            //Context.Response.HttpContext.
            AccountsApiModel accountsWebApiModel = new AccountsApiModel();
            TransactionalInformation transaction = new TransactionalInformation();

            return null;

        }
    }
}
