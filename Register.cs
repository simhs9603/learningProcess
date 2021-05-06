using AspTest01.DateContext;
using AspTest01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTest01.Controllers
{
    public class AccountController : Controller
    {

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// get에서 값을 받아 포스트로 던진다 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(User model)
        {
            return View();
        }


        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }


        /// <summary>
        /// 동일 이름으로 정의하면 에러 > why? 메서드 이기 때문 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            ///validation check
            ///사용자에게 필수로 입력 받을 내용들이 모두 입력이 되었는가?
            ///어떤값? Model에 [Required]
            if (ModelState.IsValid)
            {
                ///Using 문의 밖으로 나가면 자동으로 Close
                using (var db = new AspNetNoteDbContext())
                {
                    db.Users.Add(model);
                    ///실제로 sql에 적용할 구문 
                    db.SaveChanges();
                }

                ///해당 구문을 Home Controller 의 Index로 넘기겠다
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

    }
}
