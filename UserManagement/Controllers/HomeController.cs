using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement.ServiceReference;
using UserManagement.Models;
using AutoMapper;
using System.ServiceModel;
using System.Threading.Tasks;
using PagedList.Mvc;
using PagedList;
using System.Linq.Expressions;
using System.ServiceModel.Channels;

namespace UserManagement.Controllers
{
    public class HomeController : Controller
    {
        private UserServiceClient _client;

        public HomeController()
        {
            _client = new UserServiceClient();
        }

        const int PAGE_SIZE = 4;

        const int FIRST_PAGE = 1;

        public async Task<ActionResult> Index(int? page)
        {
            int pageNumber = (page ?? 1);
            IEnumerable<UserViewModel> users = new List<UserViewModel>(1);
            IPagedList<UserViewModel> usersForException = users.ToPagedList(1, FIRST_PAGE);
            try
            {
                IEnumerable<UserViewModel> usersAsync = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(await _client.GetAllAsync());
                return View(usersAsync.ToPagedList(pageNumber, PAGE_SIZE));
            }
            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                return View(usersForException);
            }
            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                return View(usersForException);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View(usersForException);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Index(string search)
        {
            IEnumerable<UserViewModel> users = new List<UserViewModel>(1);
            IPagedList<UserViewModel> usersForException = users.ToPagedList(1, FIRST_PAGE);

            try
            {
                if (search == "") return RedirectToAction("Index");
                IEnumerable<UserViewModel> usersAsync = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(await _client.GetAllAsync());

                Func<UserViewModel, bool> predicate = user => (user.FirstName.ToLower()).Contains(search.ToLower()) ||
                    ((user.LastName.ToLower()).Contains(search.ToLower()));

                IEnumerable<UserViewModel> resultFind = usersAsync.Where(predicate);

                if (resultFind.Count() == 0)
                {
                    TempData["errorMessage"] = "Совпадения не найдены";
                    return RedirectToAction("Index");
                }

                return View(resultFind.ToPagedList(1, resultFind.Count()));
            }

            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                return View(usersForException);
            }
            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                return View(usersForException);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View(usersForException);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, int? page)
        {
            try
            {
                await _client.DeleteAsync(id);
                TempData["successMessage"] = string.Format("Пользователь с ID:{0} успешно удален", id);
                return RedirectToAction("Index", new { page = page ?? 1 });

            }
            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                return RedirectToAction("Index");
            }
            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            UserViewModel userView;
            try
            {
                ViewBag.returnUrl = Request.UrlReferrer;
                userView = Mapper.Map<User, UserViewModel>(await _client.GetAsync(id));
                if (userView == null)
                {
                    TempData["errorMessage"] = string.Format("Пользователя с ID:{0} нет в базе", id);
                    return RedirectToAction("Index");
                }
                return View(userView);
            }
            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                userView = new UserViewModel();
                return View(userView);
            }

            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                userView = new UserViewModel();
                return View(userView);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                userView = new UserViewModel();
                return View(userView);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UserViewModel userView, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ServiceReference.User user = Mapper.Map<UserViewModel, User>(userView);
                    await _client.UpdateAsync(user);
                    TempData["successMessage"] = string.Format("Пользователь с ID:{0} успешно обновлен", userView.id);
                    //return RedirectToAction("Index");
                    return Redirect(returnUrl);
                }
                else
                {
                    return View(userView);
                }
            }
            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                return View(userView);
            }
            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                return View(userView);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View(userView);
            }
        }

        public ActionResult Create()
        {
            UserViewModel userView = new UserViewModel();
            userView.DOB = Convert.ToDateTime("01.01.1950");
            return View(userView);
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserViewModel userView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ServiceReference.User user = Mapper.Map<UserViewModel, User>(userView);
                    await _client.CreateAsync(user);
                    TempData["successMessage"] = "Пользователь успешно добавлен";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(userView);
                }
            }
            catch (EndpointNotFoundException)
            {
                TempData["errorMessage"] = "Удаленный веб-сервис не доступен";
                return View(userView);
            }
            catch (FaultException<WcfExceptionFault> fault)
            {
                TempData["errorMessage"] = fault.Detail.Message;
                return View(userView);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View(userView);
            }
        }


        protected override void Dispose(bool disposing)
        {
            _client.Close();
            base.Dispose(disposing);
        }
    }
}