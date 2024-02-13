using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Hackathone.Areas.ACC_AccountGroup.Models;

namespace Hackathone.Areas.ACC_AccountGroup.Controllers
{
    [Area("ACC_AccountGroup")]
    [Route("ACC_AccountGroup/[controller]/[action]")]
    public class ACC_AccountGroupController : Controller
    {

        #region Global
        public IConfiguration Configuration;
        public ACC_AccountGroupController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private String url = "https://testapi.gncms.in/AccountGroupSelectPage/CommonAccount/getAccountGroupSelectPage";
        private String baseurl = "https://localhost:44369/api/Role?RoleID=";
        private HttpClient client = new HttpClient();
        #endregion
        #region Index
        [HttpGet]
        public IActionResult Index()
        {
            List<ACC_AccountGroupModel> role = new List<ACC_AccountGroupModel>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                String data = response.Content.ReadAsStringAsync().Result;
                dynamic jsonObject = JsonConvert.DeserializeObject(data);
                var dataOfObject = jsonObject.data;
                var extDataJason = JsonConvert.SerializeObject(dataOfObject, Formatting.Indented);
                role = JsonConvert.DeserializeObject<List<ACC_AccountGroupModel>>(extDataJason);

            }
            return View(role);
        }
    }
}
