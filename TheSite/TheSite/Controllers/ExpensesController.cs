using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.interfaces;
using Domain.Models;
using Microsoft.Practices.Unity;


namespace TheSite.Controllers
{
    public class ExpensesController : BaseController
    {
        [Dependency]
        public IExpenditure Expenditure { get; set; }
        // GET: Expenses
        public ActionResult Index()
        {
            var model = Expenditure.GetExpenditureByparishUserId(0);
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            
           
            ViewBag.parishUsers = GetParishUsersSelectList(0);
            ViewBag.expenseTypes = GetExpenseTypesSelectList(0);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(ExpenditureModel model)
        {
            ViewBag.parishUsers = GetParishUsersSelectList(0);
            ViewBag.expenseTypes = GetExpenseTypesSelectList(0);

            return View();
        }

        private List<SelectListItem> GetExpenseTypesSelectList(int selectedId)
        {
            var types = Expenditure.GetExpenceTypes();

            List<SelectListItem> listSelectListItems = new List<SelectListItem>();
            SelectListItem selectListTemp = new SelectListItem()
            {
                Text = "Please Select",
                Value = "0",
                Selected = false
            };
            listSelectListItems.Add(selectListTemp);

            foreach (var item in types)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = item.description,
                    Value = item.ID.ToString(),
                    Selected = selectedId == item.ID
                };
                listSelectListItems.Add(selectList);
            }
            return listSelectListItems;
        }
        private List<SelectListItem> GetParishUsersSelectList(int selectedId)
        {
            var types = Expenditure.GetParishUsers();

            List<SelectListItem> listSelectListItems = new List<SelectListItem>();
            SelectListItem selectListTemp = new SelectListItem()
            {
                Text = "Please Select",
                Value = "0",
                Selected = false
            };
            listSelectListItems.Add(selectListTemp);

            foreach (var item in types)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = item.username,
                    Value = item.ID.ToString(),
                    Selected = selectedId == item.ID
                };
                listSelectListItems.Add(selectList);
            }
            return listSelectListItems;
        }
    }
}