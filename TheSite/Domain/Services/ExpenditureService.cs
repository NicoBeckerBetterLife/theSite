using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Domain.interfaces;
using Domain.Models;
using AutoMapper;
using Domain.AutoMapper;

namespace Domain.Services
{
    public class ExpenditureService : IExpenditure
    {
        private ArchdioceseEntities DB;
        private IMapper mapper;
        public ExpenditureService()
        {
            //todo Move to different class
            var config = new AutoMapperConfiguration().Configure();
            mapper = config.CreateMapper();




            DB = new ArchdioceseEntities();
        }
        public void CreateNewExpenditure(ExpenditureModel expenditureService)
        {

        }
        public void UpdateExpenditure(ExpenditureModel expenditureService)
        {

        }
        public void removeExpenditure()
        {

        }

        public ExpenditureModel GetExpenditureById(int id)
        {
            var items = DB.Expenses.SingleOrDefault(x => x.ID == id);


            return new ExpenditureModel();
        }

        public List<ExpenditureModel> GetExpenditureByparishUserId(int id)
        {
            return mapper.Map<List<Expens>, List < ExpenditureModel >> (DB.Expenses.ToList());
        }

        public List<UserModel> GetParishUsers()
        {
            return mapper.Map<List<User>, List<UserModel>>(DB.Users.ToList());
        }
        public List<ExpenseTypeModel> GetExpenceTypes()
        {
            return mapper.Map<List<ExpenseType>, List<ExpenseTypeModel>>(DB.ExpenseTypes.ToList());
        }
    }
}

