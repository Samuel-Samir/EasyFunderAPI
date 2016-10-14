using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyFunder.Models.ResponsePayload;
using EasyFunder.Models.RequestPayload;
using EasyFunder.Models.DataBaseTables;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyFunder.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        [HttpPost, Route("signin")]
        public SigninResponse signin([FromBody] SigninRequest SigninUser)
        {
            SigninResponse response = new SigninResponse();
            return response;
        }


        [HttpPost, Route("signup")]
        public SignupResponse signup([FromBody] SignupRequest SigninUser)
        {
            SignupResponse response = new SignupResponse();
            return response;
        }

        [HttpGet, Route("get/user/data")]
        public UserInfo getUserData(string email, bool isEmail , string id , bool isID)
        {
            UserInfo response = new UserInfo();
            return response;
        }


        [HttpGet, Route("create/code")]
        public VerifyCodeResponse createVerifyCode(string email)
        {
            VerifyCodeResponse response = new VerifyCodeResponse();
            return response;
        }

        [HttpGet, Route("get/verification/code")]
        public VerifyCodeResponse getVerifyCode(string email)
        {
            VerifyCodeResponse response = new VerifyCodeResponse();
            return response;
        }


        [HttpGet, Route("bank/account/details")]
        public BankInfo getBankDetails(string id)
        {
            BankInfo response = new BankInfo();
            return response;
        }

        [HttpGet, Route("spend/categories")]
        public SpendingCategoriesResponse getSpendingCategories(string id)
        {
            SpendingCategoriesResponse response = new SpendingCategoriesResponse();
            return response;
        }

        [HttpGet, Route("donation/charities")]
        public DonationCharitiesResponse getDonationCharities(string id)
        {
            DonationCharitiesResponse response = new DonationCharitiesResponse();
            return response;
        }




    }
}
