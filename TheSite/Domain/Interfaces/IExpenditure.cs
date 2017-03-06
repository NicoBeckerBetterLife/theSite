using System.Collections.Generic;
using Domain.Models;
using Domain.Services;

namespace Domain.interfaces
{
    public interface IExpenditure
    {
        void CreateNewExpenditure(ExpenditureModel expenditureService);
        void UpdateExpenditure(ExpenditureModel expenditureService);
        void removeExpenditure();
        ExpenditureModel GetExpenditureById(int id);
        List<ExpenditureModel> GetExpenditureByparishUserId(int id);
        List<UserModel> GetParishUsers();
        List<ExpenseTypeModel> GetExpenceTypes();
    }
}